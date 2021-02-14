// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2040F715-67F8-4322-9B80-4FA9FEFB83E8")]
    [NativeTypeName("struct ISystemVideoProperties : IInspectable")]
    public unsafe partial struct ISystemVideoProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, uint>)(lpVtbl[1]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, uint>)(lpVtbl[2]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, IntPtr*, int>)(lpVtbl[4]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Director([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, IntPtr*, int>)(lpVtbl[6]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FrameHeight([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, IntPtr*, int>)(lpVtbl[7]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FrameWidth([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, IntPtr*, int>)(lpVtbl[8]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Orientation([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, IntPtr*, int>)(lpVtbl[9]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalBitrate([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemVideoProperties*, IntPtr*, int>)(lpVtbl[10]))((ISystemVideoProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
