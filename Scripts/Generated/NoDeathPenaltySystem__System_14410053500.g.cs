#pragma warning disable 0219
#line 1 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoDeathPenaltySystem__System_14410053500.g.cs"
using Inventory;
using Unity.Entities;
using Unity.NetCode;
namespace CK_QOL.Features.NoDeathPenalty.Systems
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public partial class NoDeathPenaltySystem
    {
        [global::Unity.Entities.DOTSCompilerPatchedMethod("OnUpdate_T0")]

		void __OnUpdate_450AADF4()
		{
			#line 52 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
			if (!NoDeathPenalty.Instance.IsEnabled) 
#line 52 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
return;
			#line 54 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"

			var initialMoveInventoryFromLookup = GetComponentLookup<InitialMoveInventoryFromCD>();
			#line 56 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"

			NoDeathPenaltySystem_56DDECA6_LambdaJob_0_Execute(initialMoveInventoryFromLookup);
			#line 65 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"

			base.OnUpdate();
#line hidden
		}

        #line 31 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoDeathPenaltySystem__System_14410053500.g.cs"
        [global::Unity.Burst.NoAlias]
        [global::Unity.Burst.BurstCompile]
        struct NoDeathPenaltySystem_56DDECA6_LambdaJob_0_Job : global::Unity.Entities.IJobChunk
        {
            public global::Unity.Entities.ComponentLookup<global::InitialMoveInventoryFromCD> initialMoveInventoryFromLookup;
            [global::Unity.Collections.ReadOnly] public global::Unity.Entities.EntityTypeHandle __entityTypeHandle;
            public global::Unity.Entities.ComponentTypeHandle<global::InitialMoveInventoryFromCD> __initialMoveInventoryFromCDTypeHandle;
            
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            void OriginalLambdaBody(global::Unity.Entities.Entity entity, [Unity.Burst.NoAlias] ref global::InitialMoveInventoryFromCD initialMoveInventoryFromCD)
            {
#line 60 "D:\CK-ModSDK\Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
initialMoveInventoryFromLookup.SetComponentEnabled(entity, false);
#line 61 "D:\CK-ModSDK\Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
initialMoveInventoryFromCD.entityFrom = Entity.Null;
				}
            #line 48 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoDeathPenaltySystem__System_14410053500.g.cs"
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            public void Execute(in global::Unity.Entities.ArchetypeChunk chunk, int batchIndex, bool useEnabledMask, in global::Unity.Burst.Intrinsics.v128 chunkEnabledMask)
            {
                #line 52 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoDeathPenaltySystem__System_14410053500.g.cs"
                var __entityArrayPtr = global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkEntityArrayIntPtr(chunk, __entityTypeHandle);
                var initialMoveInventoryFromCDArrayPtr = global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::InitialMoveInventoryFromCD>(chunk, ref __initialMoveInventoryFromCDTypeHandle);
                int chunkEntityCount = chunk.Count;
                if (!useEnabledMask)
                {
                    for(var entityIndex = 0; entityIndex < chunkEntityCount; ++entityIndex)
                    {
                        OriginalLambdaBody(global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<global::Unity.Entities.Entity>(__entityArrayPtr, entityIndex), ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::InitialMoveInventoryFromCD>(initialMoveInventoryFromCDArrayPtr, entityIndex));
                    }
                }
                else
                {
                    int edgeCount = global::Unity.Mathematics.math.countbits(chunkEnabledMask.ULong0 ^ (chunkEnabledMask.ULong0 << 1)) + global::Unity.Mathematics.math.countbits(chunkEnabledMask.ULong1 ^ (chunkEnabledMask.ULong1 << 1)) - 1;
                    bool useRanges = edgeCount <= 4;
                    if (useRanges)
                    {
                        int entityIndex = 0;
                        int batchEndIndex = 0;
                        while (global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeTryGetNextEnabledBitRange(chunkEnabledMask, batchEndIndex, out entityIndex, out batchEndIndex))
                        {
                            while (entityIndex < batchEndIndex)
                            {
                                OriginalLambdaBody(global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<global::Unity.Entities.Entity>(__entityArrayPtr, entityIndex), ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::InitialMoveInventoryFromCD>(initialMoveInventoryFromCDArrayPtr, entityIndex));
                                entityIndex++;
                            }
                        }
                    }
                    else
                    {
                        ulong mask64 = chunkEnabledMask.ULong0;
                        int count = global::Unity.Mathematics.math.min(64, chunkEntityCount);
                        for (var entityIndex = 0; entityIndex < count; ++entityIndex)
                        {
                            if ((mask64 & 1) != 0)
                            {
                                OriginalLambdaBody(global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<global::Unity.Entities.Entity>(__entityArrayPtr, entityIndex), ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::InitialMoveInventoryFromCD>(initialMoveInventoryFromCDArrayPtr, entityIndex));
                            }
                            mask64 >>= 1;
                        }
                        mask64 = chunkEnabledMask.ULong1;
                        for (var entityIndex = 64; entityIndex < chunkEntityCount; ++entityIndex)
                        {
                            if ((mask64 & 1) != 0)
                            {
                                OriginalLambdaBody(global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<global::Unity.Entities.Entity>(__entityArrayPtr, entityIndex), ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::InitialMoveInventoryFromCD>(initialMoveInventoryFromCDArrayPtr, entityIndex));
                            }
                            mask64 >>= 1;
                        }
                    }
                }
            }
        }
        void NoDeathPenaltySystem_56DDECA6_LambdaJob_0_Execute(global::Unity.Entities.ComponentLookup<global::InitialMoveInventoryFromCD> initialMoveInventoryFromLookup)
        {
            __TypeHandle.__Unity_Entities_Entity_TypeHandle.Update(ref this.CheckedStateRef);
            __TypeHandle.__InitialMoveInventoryFromCD_RW_ComponentTypeHandle.Update(ref this.CheckedStateRef);
            var __job = new NoDeathPenaltySystem_56DDECA6_LambdaJob_0_Job
            {
                initialMoveInventoryFromLookup = initialMoveInventoryFromLookup,
                __entityTypeHandle = __TypeHandle.__Unity_Entities_Entity_TypeHandle,
                __initialMoveInventoryFromCDTypeHandle = __TypeHandle.__InitialMoveInventoryFromCD_RW_ComponentTypeHandle
            };
            
            this.CheckedStateRef.Dependency = global::Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.Schedule(__job, __query_1451888495_0, this.CheckedStateRef.Dependency);
        }
        
        TypeHandle __TypeHandle;
        global::Unity.Entities.EntityQuery __query_1451888495_0;
        struct TypeHandle
        {
            [global::Unity.Collections.ReadOnly] public global::Unity.Entities.EntityTypeHandle __Unity_Entities_Entity_TypeHandle;
            public Unity.Entities.ComponentTypeHandle<global::InitialMoveInventoryFromCD> __InitialMoveInventoryFromCD_RW_ComponentTypeHandle;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __Unity_Entities_Entity_TypeHandle = state.GetEntityTypeHandle();
                __InitialMoveInventoryFromCD_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::InitialMoveInventoryFromCD>(false);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            __query_1451888495_0 = 
                entityQueryBuilder
                    .WithAllRW<global::InitialMoveInventoryFromCD>()
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
