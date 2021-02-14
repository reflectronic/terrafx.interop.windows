// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9C53912-ABC4-46FF-8A2B-DC9D7FA6E52F")]
    [NativeTypeName("struct IUserDataPaths : IInspectable")]
    public unsafe partial struct IUserDataPaths
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserDataPaths*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataPaths*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserDataPaths*, uint>)(lpVtbl[1]))((IUserDataPaths*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserDataPaths*, uint>)(lpVtbl[2]))((IUserDataPaths*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserDataPaths*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataPaths*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[4]))((IUserDataPaths*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserDataPaths*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataPaths*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CameraRoll([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[6]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Cookies([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[7]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Desktop([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[8]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Documents([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[9]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Downloads([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[10]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Favorites([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[11]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_History([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[12]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InternetCache([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[13]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocalAppData([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[14]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocalAppDataLow([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[15]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Music([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[16]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pictures([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[17]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Profile([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[18]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Recent([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[19]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RoamingAppData([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[20]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SavedPictures([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[21]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Screenshots([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[22]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Templates([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[23]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Videos([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUserDataPaths*, IntPtr*, int>)(lpVtbl[24]))((IUserDataPaths*)Unsafe.AsPointer(ref this), value);
        }
    }
}
