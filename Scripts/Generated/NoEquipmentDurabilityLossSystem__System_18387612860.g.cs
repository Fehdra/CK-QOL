#pragma warning disable 0219
#line 1 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoEquipmentDurabilityLossSystem__System_18387612860.g.cs"
using PlayerEquipment;
using Unity.Entities;
namespace CK_QOL.Features.NoEquipmentDurabilityLoss.Systems
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public partial class NoEquipmentDurabilityLossSystem
    {
        [global::Unity.Entities.DOTSCompilerPatchedMethod("OnUpdate_T0")]

		void __OnUpdate_450AADF4()
		{
			#line 53 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
			if (!NoEquipmentDurabilityLoss.Instance.IsEnabled)
			#line 54 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
			{
				#line 55 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				return;
			}
			#line 58 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"

			foreach (var (allTrigger, entity) in IFE_1312021069_0.Query(__query_1312021069_0, __TypeHandle.__IFE_1312021069_0_TypeHandle, ref this.CheckedStateRef))
			#line 59 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
			{
				#line 60 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				allTrigger.ValueRW.damage = 0;
				#line 61 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				allTrigger.ValueRW.percentage = 0f;
				#line 62 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
global::Unity.Entities.Internal.InternalCompilerInterface.SetComponentEnabledAfterCompletingDependency<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>(ref __TypeHandle.__PlayerEquipment_ReduceDurabilityOfAllEquipmentTriggerCD_RW_ComponentLookup, ref this.CheckedStateRef, entity, false);
			}
			#line 65 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"

			foreach (var (equippedTrigger, entity) in IFE_1312021069_1.Query(__query_1312021069_1, __TypeHandle.__IFE_1312021069_1_TypeHandle, ref this.CheckedStateRef))
			#line 66 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
			{
				#line 67 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				equippedTrigger.ValueRW.triggerCounter = 0;
				#line 68 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
global::Unity.Entities.Internal.InternalCompilerInterface.SetComponentEnabledAfterCompletingDependency<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>(ref __TypeHandle.__PlayerEquipment_ReduceDurabilityOfEquippedTriggerCD_RW_ComponentLookup, ref this.CheckedStateRef, entity, false);
			}
			#line 71 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"

			foreach (var equippedObject in IFE_1312021069_2.Query(__query_1312021069_2, __TypeHandle.__IFE_1312021069_2_TypeHandle, ref this.CheckedStateRef))
			#line 72 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
			{
				#line 73 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				if (equippedObject.ValueRO.containedObject.objectID is ObjectID.None or ObjectID.CattleCage)
				#line 74 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				{
					#line 75 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
					continue;
				}
				#line 78 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"

				if (!global::Unity.Entities.Internal.InternalCompilerInterface.HasComponentAfterCompletingDependency<global::DurabilityCD>(ref __TypeHandle.__DurabilityCD_RO_ComponentLookup, ref this.CheckedStateRef, equippedObject.ValueRO.equipmentPrefab))
				#line 79 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				{
					#line 80 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
					continue;
				}
				#line 83 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"

				var durabilityComponent = global::Unity.Entities.Internal.InternalCompilerInterface.GetComponentAfterCompletingDependency<global::DurabilityCD>(ref __TypeHandle.__DurabilityCD_RO_ComponentLookup, ref this.CheckedStateRef, equippedObject.ValueRO.equipmentPrefab);
				#line 84 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"
				equippedObject.ValueRW.containedObject.objectData.amount = durabilityComponent.IsReinforced(equippedObject.ValueRW.containedObject.objectData.amount)
					? durabilityComponent.maxDurability * 2
					: durabilityComponent.maxDurability;
			}
			#line 89 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoEquipmentDurabilityLoss/Systems/NoEquipmentDurabilityLossSystem.cs"

			base.OnUpdate();
#line hidden
		}

        #line 78 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoEquipmentDurabilityLossSystem__System_18387612860.g.cs"
        readonly struct IFE_1312021069_0
        {
            public struct ResolvedChunk
            {
                public global::System.IntPtr item1_IntPtr;
                public global::System.IntPtr Entity_IntPtr;
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>> Get(int index) => new Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>>(Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>(item1_IntPtr, index),Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Unity.Entities.Entity>(Entity_IntPtr, index));
            }
            public struct TypeHandle
            {
                Unity.Entities.ComponentTypeHandle<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD> item1_ComponentTypeHandle_RW;
                Unity.Entities.EntityTypeHandle Entity_TypeHandle;
                public TypeHandle(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW = systemState.GetComponentTypeHandle<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>(isReadOnly: false);
                    Entity_TypeHandle = systemState.GetEntityTypeHandle();
                }
                public void Update(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW.Update(ref systemState);
                    Entity_TypeHandle.Update(ref systemState);
                }
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public ResolvedChunk Resolve(global::Unity.Entities.ArchetypeChunk archetypeChunk)
                {
                    var resolvedChunk = new ResolvedChunk();
                    resolvedChunk.item1_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtrWithoutChecks<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>(archetypeChunk, ref item1_ComponentTypeHandle_RW);
                    resolvedChunk.Entity_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkEntityArrayIntPtr(archetypeChunk, Entity_TypeHandle);
                    return resolvedChunk;
                }
            }
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Enumerator Query(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state) => new Enumerator(entityQuery, typeHandle, ref state);
            public struct Enumerator : global::System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>>>
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
                        IFE_1312021069_0.CompleteDependencies(ref state);
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
                
                public Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>> Current => _resolvedChunk.Get(_currentEntityIndex);
                
                public Enumerator GetEnumerator() => this;
                public void Reset() => throw new global::System.NotImplementedException();
                object global::System.Collections.IEnumerator.Current => throw new global::System.NotImplementedException();
            }
            public static void CompleteDependencies(ref SystemState state)
            {
                state.EntityManager.CompleteDependencyBeforeRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>();
            }
        }
        #line 176 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoEquipmentDurabilityLossSystem__System_18387612860.g.cs"
        readonly struct IFE_1312021069_1
        {
            public struct ResolvedChunk
            {
                public global::System.IntPtr item1_IntPtr;
                public global::System.IntPtr Entity_IntPtr;
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>> Get(int index) => new Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>>(Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>(item1_IntPtr, index),Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Unity.Entities.Entity>(Entity_IntPtr, index));
            }
            public struct TypeHandle
            {
                Unity.Entities.ComponentTypeHandle<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD> item1_ComponentTypeHandle_RW;
                Unity.Entities.EntityTypeHandle Entity_TypeHandle;
                public TypeHandle(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW = systemState.GetComponentTypeHandle<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>(isReadOnly: false);
                    Entity_TypeHandle = systemState.GetEntityTypeHandle();
                }
                public void Update(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW.Update(ref systemState);
                    Entity_TypeHandle.Update(ref systemState);
                }
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public ResolvedChunk Resolve(global::Unity.Entities.ArchetypeChunk archetypeChunk)
                {
                    var resolvedChunk = new ResolvedChunk();
                    resolvedChunk.item1_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtrWithoutChecks<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>(archetypeChunk, ref item1_ComponentTypeHandle_RW);
                    resolvedChunk.Entity_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkEntityArrayIntPtr(archetypeChunk, Entity_TypeHandle);
                    return resolvedChunk;
                }
            }
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Enumerator Query(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state) => new Enumerator(entityQuery, typeHandle, ref state);
            public struct Enumerator : global::System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>>>
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
                        IFE_1312021069_1.CompleteDependencies(ref state);
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
                
                public Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>> Current => _resolvedChunk.Get(_currentEntityIndex);
                
                public Enumerator GetEnumerator() => this;
                public void Reset() => throw new global::System.NotImplementedException();
                object global::System.Collections.IEnumerator.Current => throw new global::System.NotImplementedException();
            }
            public static void CompleteDependencies(ref SystemState state)
            {
                state.EntityManager.CompleteDependencyBeforeRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>();
            }
        }
        #line 274 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoEquipmentDurabilityLossSystem__System_18387612860.g.cs"
        readonly struct IFE_1312021069_2
        {
            public struct ResolvedChunk
            {
                public global::System.IntPtr item1_IntPtr;
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::EquippedObjectCD> Get(int index) => Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRW<global::EquippedObjectCD>(item1_IntPtr, index);
            }
            public struct TypeHandle
            {
                Unity.Entities.ComponentTypeHandle<global::EquippedObjectCD> item1_ComponentTypeHandle_RW;
                public TypeHandle(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW = systemState.GetComponentTypeHandle<global::EquippedObjectCD>(isReadOnly: false);
                }
                public void Update(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW.Update(ref systemState);
                }
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public ResolvedChunk Resolve(global::Unity.Entities.ArchetypeChunk archetypeChunk)
                {
                    var resolvedChunk = new ResolvedChunk();
                    resolvedChunk.item1_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtrWithoutChecks<global::EquippedObjectCD>(archetypeChunk, ref item1_ComponentTypeHandle_RW);
                    return resolvedChunk;
                }
            }
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Enumerator Query(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state) => new Enumerator(entityQuery, typeHandle, ref state);
            public struct Enumerator : global::System.Collections.Generic.IEnumerator<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::EquippedObjectCD>>
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
                        IFE_1312021069_2.CompleteDependencies(ref state);
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
                
                public Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::EquippedObjectCD> Current => _resolvedChunk.Get(_currentEntityIndex);
                
                public Enumerator GetEnumerator() => this;
                public void Reset() => throw new global::System.NotImplementedException();
                object global::System.Collections.IEnumerator.Current => throw new global::System.NotImplementedException();
            }
            public static void CompleteDependencies(ref SystemState state)
            {
                state.EntityManager.CompleteDependencyBeforeRW<global::EquippedObjectCD>();
            }
        }
        
        TypeHandle __TypeHandle;
        global::Unity.Entities.EntityQuery __query_1312021069_0;
        global::Unity.Entities.EntityQuery __query_1312021069_1;
        global::Unity.Entities.EntityQuery __query_1312021069_2;
        struct TypeHandle
        {
            public IFE_1312021069_0.TypeHandle __IFE_1312021069_0_TypeHandle;
            public IFE_1312021069_1.TypeHandle __IFE_1312021069_1_TypeHandle;
            public IFE_1312021069_2.TypeHandle __IFE_1312021069_2_TypeHandle;
            public global::Unity.Entities.ComponentLookup<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD> __PlayerEquipment_ReduceDurabilityOfAllEquipmentTriggerCD_RW_ComponentLookup;
            public global::Unity.Entities.ComponentLookup<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD> __PlayerEquipment_ReduceDurabilityOfEquippedTriggerCD_RW_ComponentLookup;
            [global::Unity.Collections.ReadOnly] public global::Unity.Entities.ComponentLookup<global::DurabilityCD> __DurabilityCD_RO_ComponentLookup;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __IFE_1312021069_0_TypeHandle = new IFE_1312021069_0.TypeHandle(ref state);
                __IFE_1312021069_1_TypeHandle = new IFE_1312021069_1.TypeHandle(ref state);
                __IFE_1312021069_2_TypeHandle = new IFE_1312021069_2.TypeHandle(ref state);
                __PlayerEquipment_ReduceDurabilityOfAllEquipmentTriggerCD_RW_ComponentLookup = state.GetComponentLookup<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>(false);
                __PlayerEquipment_ReduceDurabilityOfEquippedTriggerCD_RW_ComponentLookup = state.GetComponentLookup<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>(false);
                __DurabilityCD_RO_ComponentLookup = state.GetComponentLookup<global::DurabilityCD>(true);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            __query_1312021069_0 = 
                entityQueryBuilder
                    .WithAllRW<global::PlayerEquipment.ReduceDurabilityOfAllEquipmentTriggerCD>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            __query_1312021069_1 = 
                entityQueryBuilder
                    .WithAllRW<global::PlayerEquipment.ReduceDurabilityOfEquippedTriggerCD>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            __query_1312021069_2 = 
                entityQueryBuilder
                    .WithAllRW<global::EquippedObjectCD>()
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
