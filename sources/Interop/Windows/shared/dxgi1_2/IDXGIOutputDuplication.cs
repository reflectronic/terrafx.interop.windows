// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("191CFAC3-A341-470D-B26E-A864F428319C")]
    [NativeTypeName("struct IDXGIOutputDuplication : IDXGIObject")]
    public unsafe partial struct IDXGIOutputDuplication
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, uint>)(lpVtbl[1]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, uint>)(lpVtbl[2]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc(DXGI_OUTDUPL_DESC* pDesc)
        {
            ((delegate* unmanaged<IDXGIOutputDuplication*, DXGI_OUTDUPL_DESC*, void>)(lpVtbl[7]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AcquireNextFrame([NativeTypeName("UINT")] uint TimeoutInMilliseconds, DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_FRAME_INFO*, IDXGIResource**, int>)(lpVtbl[8]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameDirtyRects([NativeTypeName("UINT")] uint DirtyRectsBufferSize, RECT* pDirtyRectsBuffer, [NativeTypeName("UINT *")] uint* pDirtyRectsBufferSizeRequired)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, RECT*, uint*, int>)(lpVtbl[9]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameMoveRects([NativeTypeName("UINT")] uint MoveRectsBufferSize, DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, [NativeTypeName("UINT *")] uint* pMoveRectsBufferSizeRequired)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_MOVE_RECT*, uint*, int>)(lpVtbl[10]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFramePointerShape([NativeTypeName("UINT")] uint PointerShapeBufferSize, void* pPointerShapeBuffer, [NativeTypeName("UINT *")] uint* pPointerShapeBufferSizeRequired, DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, DXGI_OUTDUPL_POINTER_SHAPE_INFO*, int>)(lpVtbl[11]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapDesktopSurface(DXGI_MAPPED_RECT* pLockedRect)
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, DXGI_MAPPED_RECT*, int>)(lpVtbl[12]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnMapDesktopSurface()
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, int>)(lpVtbl[13]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseFrame()
        {
            return ((delegate* unmanaged<IDXGIOutputDuplication*, int>)(lpVtbl[14]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
        }
    }
}
