// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A05791E6-CC9F-4687-ACAB-A364FD785463")]
    [NativeTypeName("struct IApplicationDataSetVersionHandler : IUnknown")]
    public unsafe partial struct IApplicationDataSetVersionHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDataSetVersionHandler*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDataSetVersionHandler*, uint>)(lpVtbl[1]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDataSetVersionHandler*, uint>)(lpVtbl[2]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("ABI::Windows::Storage::ISetVersionRequest *")] ISetVersionRequest* setVersionRequest)
        {
            return ((delegate* unmanaged<IApplicationDataSetVersionHandler*, ISetVersionRequest*, int>)(lpVtbl[3]))((IApplicationDataSetVersionHandler*)Unsafe.AsPointer(ref this), setVersionRequest);
        }
    }
}
