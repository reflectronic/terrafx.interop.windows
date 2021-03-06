// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03FAF64D-F26F-4B2C-AAF7-8FE7789B8BCA")]
    [NativeTypeName("struct IAppxManifestProperties : IUnknown")]
    public unsafe partial struct IAppxManifestProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestProperties*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestProperties*, uint>)(lpVtbl[1]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestProperties*, uint>)(lpVtbl[2]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBoolValue([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("BOOL *")] int* value)
        {
            return ((delegate* unmanaged<IAppxManifestProperties*, ushort*, int*, int>)(lpVtbl[3]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringValue([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("LPWSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IAppxManifestProperties*, ushort*, ushort**, int>)(lpVtbl[4]))((IAppxManifestProperties*)Unsafe.AsPointer(ref this), name, value);
        }
    }
}
