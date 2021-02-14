// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B47988D5-67AF-4BC3-8D39-5B89022026A1")]
    [NativeTypeName("struct ISystemMusicProperties : IInspectable")]
    public unsafe partial struct ISystemMusicProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, uint>)(lpVtbl[1]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, uint>)(lpVtbl[2]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[4]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, TrustLevel*, int>)(lpVtbl[5]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AlbumArtist([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[6]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AlbumTitle([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[7]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Artist([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[8]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Composer([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[9]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Conductor([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[10]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayArtist([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[11]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Genre([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[12]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TrackNumber([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemMusicProperties*, IntPtr*, int>)(lpVtbl[13]))((ISystemMusicProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
