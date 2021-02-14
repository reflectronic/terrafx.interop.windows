// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1DC7A369-B7A3-4DF2-9D61-EBA85A0343D2")]
    [NativeTypeName("struct IStorageLibraryChangeTrackerTriggerDetails : IInspectable")]
    public unsafe partial struct IStorageLibraryChangeTrackerTriggerDetails
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, uint>)(lpVtbl[1]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, uint>)(lpVtbl[2]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, IStorageFolder**, int>)(lpVtbl[6]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ChangeTracker([NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker **")] IStorageLibraryChangeTracker** value)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails*, IStorageLibraryChangeTracker**, int>)(lpVtbl[7]))((IStorageLibraryChangeTrackerTriggerDetails*)Unsafe.AsPointer(ref this), value);
        }
    }
}
