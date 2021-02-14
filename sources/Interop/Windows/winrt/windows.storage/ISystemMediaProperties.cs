// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A42B3316-8415-40DC-8C44-98361D235430")]
    [NativeTypeName("struct ISystemMediaProperties : IInspectable")]
    public unsafe partial struct ISystemMediaProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, uint>)(lpVtbl[1]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, uint>)(lpVtbl[2]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[4]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Duration([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[6]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Producer([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[7]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Publisher([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[8]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SubTitle([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[9]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Writer([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[10]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Year([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMediaProperties*, IntPtr*, int>)(lpVtbl[11]))((ISystemMediaProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
