// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8455293A-0CBD-4831-9B39-FBDBAB724723")]
    [NativeTypeName("struct ID3D12VideoEncodeCommandList : ID3D12CommandList")]
    public unsafe partial struct ID3D12VideoEncodeCommandList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, uint>)(lpVtbl[1]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, uint>)(lpVtbl[2]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ushort*, int>)(lpVtbl[6]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public new D3D12_COMMAND_LIST_TYPE GetType()
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, D3D12_COMMAND_LIST_TYPE>)(lpVtbl[8]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, int>)(lpVtbl[9]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset(ID3D12CommandAllocator* pAllocator)
        {
            return ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12CommandAllocator*, int>)(lpVtbl[10]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, void>)(lpVtbl[11]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResourceBarrier([NativeTypeName("UINT")] uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, uint, D3D12_RESOURCE_BARRIER*, void>)(lpVtbl[12]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DiscardResource(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12Resource*, D3D12_DISCARD_REGION*, void>)(lpVtbl[13]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pResource, pRegion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[14]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint Index)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[15]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, [NativeTypeName("UINT")] uint StartIndex, [NativeTypeName("UINT")] uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void>)(lpVtbl[16]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetPredication(ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void>)(lpVtbl[17]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetMarker([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, uint, void*, uint, void>)(lpVtbl[18]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BeginEvent([NativeTypeName("UINT")] uint Metadata, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint Size)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, uint, void*, uint, void>)(lpVtbl[19]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EndEvent()
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, void>)(lpVtbl[20]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EstimateMotion(ID3D12VideoMotionEstimator* pMotionEstimator, [NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT *")] D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_INPUT *")] D3D12_VIDEO_MOTION_ESTIMATOR_INPUT* pInputArguments)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT*, D3D12_VIDEO_MOTION_ESTIMATOR_INPUT*, void>)(lpVtbl[21]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pMotionEstimator, pOutputArguments, pInputArguments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ResolveMotionVectorHeap([NativeTypeName("const D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT *")] D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT* pOutputArguments, [NativeTypeName("const D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT *")] D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT* pInputArguments)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT*, D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT*, void>)(lpVtbl[22]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pOutputArguments, pInputArguments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void WriteBufferImmediate([NativeTypeName("UINT")] uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void>)(lpVtbl[23]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            ((delegate* unmanaged<ID3D12VideoEncodeCommandList*, ID3D12ProtectedResourceSession*, void>)(lpVtbl[24]))((ID3D12VideoEncodeCommandList*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
        }
    }
}
