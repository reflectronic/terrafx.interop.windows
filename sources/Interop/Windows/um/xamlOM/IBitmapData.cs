// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D1A34EF2-CAD8-4635-A3D2-FCDA8D3F3CAF")]
    [NativeTypeName("struct IBitmapData : IUnknown")]
    public unsafe partial struct IBitmapData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBitmapData*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBitmapData*, uint>)(lpVtbl[1]))((IBitmapData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBitmapData*, uint>)(lpVtbl[2]))((IBitmapData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyBytesTo([NativeTypeName("unsigned int")] uint sourceOffsetInBytes, [NativeTypeName("unsigned int")] uint maxBytesToCopy, byte* pvBytes, [NativeTypeName("unsigned int *")] uint* numberOfBytesCopied)
        {
            return ((delegate* unmanaged<IBitmapData*, uint, uint, byte*, uint*, int>)(lpVtbl[3]))((IBitmapData*)Unsafe.AsPointer(ref this), sourceOffsetInBytes, maxBytesToCopy, pvBytes, numberOfBytesCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStride([NativeTypeName("unsigned int *")] uint* pStride)
        {
            return ((delegate* unmanaged<IBitmapData*, uint*, int>)(lpVtbl[4]))((IBitmapData*)Unsafe.AsPointer(ref this), pStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitmapDescription(BitmapDescription* pBitmapDescription)
        {
            return ((delegate* unmanaged<IBitmapData*, BitmapDescription*, int>)(lpVtbl[5]))((IBitmapData*)Unsafe.AsPointer(ref this), pBitmapDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceBitmapDescription(BitmapDescription* pBitmapDescription)
        {
            return ((delegate* unmanaged<IBitmapData*, BitmapDescription*, int>)(lpVtbl[6]))((IBitmapData*)Unsafe.AsPointer(ref this), pBitmapDescription);
        }
    }
}
