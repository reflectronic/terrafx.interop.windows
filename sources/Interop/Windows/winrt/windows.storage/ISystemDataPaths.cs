// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E32ABF70-D8FA-45EC-A942-D2E26FB60BA5")]
    [NativeTypeName("struct ISystemDataPaths : IInspectable")]
    public unsafe partial struct ISystemDataPaths
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, Guid*, void**, int>)(lpVtbl[0]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemDataPaths*, uint>)(lpVtbl[1]))((ISystemDataPaths*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemDataPaths*, uint>)(lpVtbl[2]))((ISystemDataPaths*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[4]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, TrustLevel*, int>)(lpVtbl[5]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Fonts([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[6]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProgramData([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[7]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Public([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[8]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PublicDesktop([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[9]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PublicDocuments([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[10]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PublicDownloads([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[11]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PublicMusic([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[12]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PublicPictures([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[13]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PublicVideos([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[14]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_System([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[15]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SystemHost([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[16]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SystemX86([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[17]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SystemX64([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[18]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SystemArm([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[19]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UserProfiles([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[20]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Windows([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ISystemDataPaths*, IntPtr*, int>)(lpVtbl[21]))((ISystemDataPaths*)Unsafe.AsPointer(ref this), value);
        }
    }
}
