#pragma warning disable 0219
#line 1 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//ItemPickUpNotificationSystem__System_16760277450.g.cs"
using System.Collections.Generic;
using CK_QOL.Core.Helpers;
using Inventory;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
namespace CK_QOL.Features.ItemPickUpNotifier.Systems
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public partial class ItemPickUpNotificationSystem
    {
        [global::Unity.Entities.DOTSCompilerPatchedMethod("OnUpdate_T0")]

		void __OnUpdate_450AADF4()
		{
			#line 83 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			if (isServer || !ItemPickUpNotifier.Instance.IsEnabled)
			#line 84 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			{
				#line 85 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				return;
			}
			#line 88 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

			if (_localPlayerEntity == Entity.Null)
			#line 89 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			{
				#line 90 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				var playerController = Manager.main?.player;
				#line 91 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				if (playerController?.isLocal ?? false)
				#line 92 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				{
					#line 93 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					_localPlayerEntity = playerController.entity;
				}
				else
				#line 96 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				{
					#line 97 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					return;
				}
			}
			#line 101 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

			var containedObjectsBufferLookup = GetBufferLookup<ContainedObjectsBuffer>(true);
			#line 102 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			var cachedPickups = _cachedPickups;
			#line 103 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			var localPlayerEntity = _localPlayerEntity;
			#line 105 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

			foreach (var inventoryChanges in IFE_911957050_0.Query(__query_911957050_0, __TypeHandle.__IFE_911957050_0_TypeHandle, ref this.CheckedStateRef))
			#line 106 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			{
				#line 107 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				foreach (var change in inventoryChanges)
				#line 108 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				{
					#line 109 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					if (change.inventoryChangeData.inventoryAction != InventoryAction.MoveOrDropAllItems)
					#line 110 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					{
						#line 111 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						continue;
					}
					#line 114 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

					if (change.playerEntity != localPlayerEntity)
					#line 115 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					{
						#line 116 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						continue;
					}
					#line 119 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

					var sourceInventory = change.inventoryChangeData.inventory1;
					#line 120 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					if (!containedObjectsBufferLookup.HasBuffer(sourceInventory))
					#line 121 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					{
						#line 122 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						continue;
					}
					#line 125 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

					var itemsBuffer = containedObjectsBufferLookup[sourceInventory];
					#line 126 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					foreach (var item in itemsBuffer)
					#line 127 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
					{
						#line 128 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						if (item.objectID is ObjectID.None or ObjectID.CattleCage)
						#line 129 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						{
							#line 130 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
							continue;
						}
						#line 133 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

						var objectIdHash = item.objectData.objectID.GetHashCode();
						#line 134 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						if (cachedPickups.TryGetValue(objectIdHash, out var existing))
						#line 135 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						{
							#line 136 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
							cachedPickups[objectIdHash] = (existing.totalAmount + item.amount, existing.rarity, existing.displayName);
						}
						else
						#line 139 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
						{
							#line 140 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
							var text = PlayerController.GetObjectName(item, true).text;
							#line 141 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
							var rarity = PugDatabase.GetObjectInfo(item.objectData.objectID).rarity;
							#line 143 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

							cachedPickups[objectIdHash] = (item.amount, rarity, text);
						}
					}
				}
			}
			#line 149 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

			_timeSinceLastLog += this.CheckedStateRef.WorldUnmanaged.Time.DeltaTime;
			#line 151 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

			if (_timeSinceLastLog >= ItemPickUpNotifier.Instance.AggregateDelay)
			#line 152 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
			{
				#line 153 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"
				HandleItemPickupNotifications();
			}
			#line 156 "D:/CK-ModSDK/Assets/CK-QOL/Features/ItemPickUpNotifier/Systems/ItemPickUpNotificationSystem.cs"

			base.OnUpdate();
#line hidden
		}

        #line 143 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//ItemPickUpNotificationSystem__System_16760277450.g.cs"
        readonly struct IFE_911957050_0
        {
            public struct ResolvedChunk
            {
                public Unity.Entities.BufferAccessor<global::Inventory.InventoryChangeBuffer> item1_BufferAccessor;
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public global::Unity.Entities.DynamicBuffer<global::Inventory.InventoryChangeBuffer> Get(int index) => item1_BufferAccessor[index];
            }
            public struct TypeHandle
            {
                Unity.Entities.BufferTypeHandle<global::Inventory.InventoryChangeBuffer> item1_BufferTypeHandle_RW;
                public TypeHandle(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_BufferTypeHandle_RW = systemState.GetBufferTypeHandle<global::Inventory.InventoryChangeBuffer>(isReadOnly: false);
                }
                public void Update(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_BufferTypeHandle_RW.Update(ref systemState);
                }
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public ResolvedChunk Resolve(global::Unity.Entities.ArchetypeChunk archetypeChunk)
                {
                    var resolvedChunk = new ResolvedChunk();
                    resolvedChunk.item1_BufferAccessor = archetypeChunk.GetBufferAccessor(ref item1_BufferTypeHandle_RW);
                    return resolvedChunk;
                }
            }
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Enumerator Query(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state) => new Enumerator(entityQuery, typeHandle, ref state);
            public struct Enumerator : global::System.Collections.Generic.IEnumerator<global::Unity.Entities.DynamicBuffer<global::Inventory.InventoryChangeBuffer>>
            {
                global::Unity.Entities.Internal.InternalEntityQueryEnumerator _entityQueryEnumerator;
                TypeHandle _typeHandle;
                ResolvedChunk _resolvedChunk;
                
                int _currentEntityIndex;
                int _endEntityIndex;
                
                public Enumerator(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state)
                {
                    if (!entityQuery.IsEmptyIgnoreFilter)
                    {
                        IFE_911957050_0.CompleteDependencies(ref state);
                        typeHandle.Update(ref state);
                        
                    }
                    
                    _entityQueryEnumerator = new global::Unity.Entities.Internal.InternalEntityQueryEnumerator(entityQuery);
                    
                    _currentEntityIndex = -1;
                    _endEntityIndex = -1;
                    
                    _typeHandle = typeHandle;
                    _resolvedChunk = default;
                }
                
                public void Dispose() => _entityQueryEnumerator.Dispose();
                
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public bool MoveNext()
                {
                    _currentEntityIndex++;
                    
                    if (_currentEntityIndex >= _endEntityIndex)
                    {
                        if (_entityQueryEnumerator.MoveNextEntityRange(out bool movedToNewChunk, out global::Unity.Entities.ArchetypeChunk chunk, out int entityStartIndex, out int entityEndIndex))
                        {
                            if (movedToNewChunk)
                            {
                                _resolvedChunk = _typeHandle.Resolve(chunk);
                            }
                            
                            _currentEntityIndex = entityStartIndex;
                            _endEntityIndex = entityEndIndex;
                            return true;
                        }
                        return false;
                    }
                    return true;
                }
                
                public global::Unity.Entities.DynamicBuffer<global::Inventory.InventoryChangeBuffer> Current => _resolvedChunk.Get(_currentEntityIndex);
                
                public Enumerator GetEnumerator() => this;
                public void Reset() => throw new global::System.NotImplementedException();
                object global::System.Collections.IEnumerator.Current => throw new global::System.NotImplementedException();
            }
            public static void CompleteDependencies(ref SystemState state)
            {
                state.EntityManager.CompleteDependencyBeforeRW<global::Inventory.InventoryChangeBuffer>();
            }
        }
        
        TypeHandle __TypeHandle;
        global::Unity.Entities.EntityQuery __query_911957050_0;
        struct TypeHandle
        {
            public IFE_911957050_0.TypeHandle __IFE_911957050_0_TypeHandle;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __IFE_911957050_0_TypeHandle = new IFE_911957050_0.TypeHandle(ref state);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            __query_911957050_0 = 
                entityQueryBuilder
                    .WithAllRW<global::Inventory.InventoryChangeBuffer>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            entityQueryBuilder.Dispose();
        }
        
        protected override void OnCreateForCompiler()
        {
            base.OnCreateForCompiler();
            __AssignQueries(ref this.CheckedStateRef);
            __TypeHandle.__AssignHandles(ref this.CheckedStateRef);
        }
    }
}
