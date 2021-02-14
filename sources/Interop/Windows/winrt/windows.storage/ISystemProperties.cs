// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("917A71C1-85F3-4DD1-B001-A50BFD21C8D2")]
    [NativeTypeName("struct ISystemProperties : IInspectable")]
    public unsafe partial struct ISystemProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemProperties*, uint>)(lpVtbl[1]))((ISystemProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemProperties*, uint>)(lpVtbl[2]))((ISystemProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[4]))((ISystemProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Author([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[6]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Comment([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[7]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ItemNameDisplay([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[8]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Keywords([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[9]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rating([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[10]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemProperties*, IntPtr*, int>)(lpVtbl[11]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Audio([NativeTypeName("ABI::Windows::Storage::ISystemAudioProperties **")] ISystemAudioProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemAudioProperties**, int>)(lpVtbl[12]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GPS([NativeTypeName("ABI::Windows::Storage::ISystemGPSProperties **")] ISystemGPSProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemGPSProperties**, int>)(lpVtbl[13]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Media([NativeTypeName("ABI::Windows::Storage::ISystemMediaProperties **")] ISystemMediaProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemMediaProperties**, int>)(lpVtbl[14]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Music([NativeTypeName("ABI::Windows::Storage::ISystemMusicProperties **")] ISystemMusicProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemMusicProperties**, int>)(lpVtbl[15]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Photo([NativeTypeName("ABI::Windows::Storage::ISystemPhotoProperties **")] ISystemPhotoProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemPhotoProperties**, int>)(lpVtbl[16]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Video([NativeTypeName("ABI::Windows::Storage::ISystemVideoProperties **")] ISystemVideoProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemVideoProperties**, int>)(lpVtbl[17]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Image([NativeTypeName("ABI::Windows::Storage::ISystemImageProperties **")] ISystemImageProperties** value)
        {
            return ((delegate* unmanaged<ISystemProperties*, ISystemImageProperties**, int>)(lpVtbl[18]))((ISystemProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
