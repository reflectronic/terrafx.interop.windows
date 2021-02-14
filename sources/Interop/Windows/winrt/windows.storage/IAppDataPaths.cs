// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7301D60A-79A2-48C9-9EC0-3FDA092F79E1")]
    [NativeTypeName("struct IAppDataPaths : IInspectable")]
    public unsafe partial struct IAppDataPaths
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDataPaths*, Guid*, void**, int>)(lpVtbl[0]))((IAppDataPaths*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDataPaths*, uint>)(lpVtbl[1]))((IAppDataPaths*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDataPaths*, uint>)(lpVtbl[2]))((IAppDataPaths*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDataPaths*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDataPaths*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[4]))((IAppDataPaths*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDataPaths*, TrustLevel*, int>)(lpVtbl[5]))((IAppDataPaths*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Cookies([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[6]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Desktop([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[7]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Documents([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[8]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Favorites([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[9]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_History([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[10]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InternetCache([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[11]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocalAppData([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[12]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProgramData([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[13]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RoamingAppData([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppDataPaths*, IntPtr*, int>)(lpVtbl[14]))((IAppDataPaths*)Unsafe.AsPointer(ref this), value);
        }
    }
}
