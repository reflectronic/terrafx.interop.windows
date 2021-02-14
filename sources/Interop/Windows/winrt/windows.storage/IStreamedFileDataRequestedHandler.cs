// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEF6A824-2FE1-4D07-A35B-B77C50B5F4CC")]
    [NativeTypeName("struct IStreamedFileDataRequestedHandler : IUnknown")]
    public unsafe partial struct IStreamedFileDataRequestedHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequestedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamedFileDataRequestedHandler*, uint>)(lpVtbl[1]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamedFileDataRequestedHandler*, uint>)(lpVtbl[2]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequestedHandler*, IOutputStream*, int>)(lpVtbl[3]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this), stream);
        }
    }
}
