using CK_QOL.Core;
using CK_QOL.Core.Config;
using CK_QOL.Core.Features;
using CoreLib.RewiredExtension;
using Rewired;

namespace CK_QOL.Features.QuickSummon
{
    /// <summary>
    /// Represents the "Summon Binding" feature in the game, which allows players to quickly use the Tome of the Dark (TomeOfRange) from their inventory.
    /// This feature provides a key binding to trigger summoning actions and automatically manages the inventory to locate and equip the Tome efficiently.
    /// </summary>
    internal sealed class QuickSummon : FeatureBase<QuickSummon>
    {
        #region IFeature

        public override string Name => nameof(QuickSummon);
        public override string DisplayName => "Quick Summon";
        public override string Description => "Adds a binding to quickly summon using the Tome of the Dark.";
        public override FeatureType FeatureType => FeatureType.Client;

        #endregion IFeature

        #region Configurations

        private const string KeyBindAction = "Quick Summon";
        internal string KeyBindName => $"{ModSettings.ShortName}_{Name}";
        internal int EquipmentSlotIndex { get; private set; }

        private void ApplyConfigurations()
        {
            ConfigBase.Create(this);
            IsEnabled = QuickSummonConfig.ApplyIsEnabled(this);
            EquipmentSlotIndex = QuickSummonConfig.ApplyEquipmentSlotIndex(this);
        }

        private void ApplyKeyBinds()
        {
            RewiredExtensionModule.AddKeybind(KeyBindName, KeyBindAction, KeyboardKeyCode.V);
        }

        #endregion Configurations

        private int _previousSlotIndex = -1;
        private int _fromSlotIndex = -1;

        public QuickSummon()
        {
            ApplyConfigurations();
            ApplyKeyBinds();
        }

        public override bool CanExecute() =>
            base.CanExecute() &&
            Entry.RewiredPlayer != null &&
            Manager.main.player != null &&
            !(Manager.input?.textInputIsActive ?? false);

        public override void Execute()
        {
            if (!CanExecute())
            {
                return;
            }

            var player = Manager.main.player;

            if (TryFindSummonable(player))
            {
                UseTomeOfTheDark(player);
            }
        }

        public override void Update()
        {
            if (!CanExecute())
            {
                return;
            }

            if (Entry.RewiredPlayer.GetButtonDown(KeyBindName))
            {
                Execute();
            }

            if (Entry.RewiredPlayer.GetButtonUp(KeyBindName))
            {
                SwapBackToPreviousSlot();
            }
        }

        private bool TryFindSummonable(PlayerController player)
        {
            _previousSlotIndex = player.equippedSlotIndex;

            // Check if the Tome of the Dark is in the predefined slot.
            if (IsSummonable(player.playerInventoryHandler.GetObjectData(EquipmentSlotIndex)))
            {
                return true;
            }

            // If it's not in the slot, search the inventory.
            var playerInventorySize = player.playerInventoryHandler.size;
            for (var i = 0; i < playerInventorySize; i++)
            {
                if (IsSummonable(player.playerInventoryHandler.GetObjectData(i)))
                {
                    _fromSlotIndex = i; // Store the original slot index
                    // Swap the item to the summonable slot.
                    player.playerInventoryHandler.Swap(player, _fromSlotIndex, player.playerInventoryHandler, EquipmentSlotIndex);
                    return true;
                }
            }

            return false;
        }

        private static bool IsSummonable(ObjectDataCD objectData) =>
            objectData.objectID == ObjectID.TomeOfRange;

        private void UseTomeOfTheDark(PlayerController player)
        {
            player.EquipSlot(EquipmentSlotIndex);

            // Get the input history component and reset the secondInteractUITriggered flag to 'false'.
            var inputHistory = EntityUtility.GetComponentData<ClientInputHistoryCD>(player.entity, player.world);
            inputHistory.secondInteractUITriggered = false;
            EntityUtility.SetComponentData(player.entity, player.world, inputHistory);

            // Re-equip the slot to ensure proper use.
            player.EquipSlot(EquipmentSlotIndex);

            // Set the secondInteractUITriggered flag to 'true' to simulate the "use" action.
            inputHistory.secondInteractUITriggered = true;
            EntityUtility.SetComponentData(player.entity, player.world, inputHistory);
        }

        /// <summary>
        /// Swaps back to the previously equipped slot after using the Tome of the Dark.
        /// </summary>
        private void SwapBackToPreviousSlot()
        {
            if (_previousSlotIndex != -1)
            {
                var player = Manager.main.player;
                player.EquipSlot(_previousSlotIndex); // Equip the previous slot

                if (_fromSlotIndex != -1)
                {
                    // Swap back the Tome to its original slot
                    player.playerInventoryHandler.Swap(player, EquipmentSlotIndex, player.playerInventoryHandler, _fromSlotIndex);
                }
            }
        }
    }
}
