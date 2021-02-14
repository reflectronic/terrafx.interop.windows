// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("75D760B0-60B9-412D-994F-26B2CD5F7812")]
    [NativeTypeName("struct IXblIdpAuthTokenResult2 : IUnknown")]
    public unsafe partial struct IXblIdpAuthTokenResult2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult2*, Guid*, void**, int>)(lpVtbl[0]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult2*, uint>)(lpVtbl[1]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult2*, uint>)(lpVtbl[2]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetModernGamertag([NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult2*, ushort**, int>)(lpVtbl[3]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetModernGamertagSuffix([NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult2*, ushort**, int>)(lpVtbl[4]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUniqueModernGamertag([NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IXblIdpAuthTokenResult2*, ushort**, int>)(lpVtbl[5]))((IXblIdpAuthTokenResult2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
