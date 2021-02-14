// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0F46EB4-C174-481A-BC25-921986F6A6F3")]
    [NativeTypeName("struct ISystemGPSProperties : IInspectable")]
    public unsafe partial struct ISystemGPSProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, uint>)(lpVtbl[1]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, uint>)(lpVtbl[2]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, IntPtr*, int>)(lpVtbl[4]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LatitudeDecimal([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, IntPtr*, int>)(lpVtbl[6]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LongitudeDecimal([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemGPSProperties*, IntPtr*, int>)(lpVtbl[7]))((ISystemGPSProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
