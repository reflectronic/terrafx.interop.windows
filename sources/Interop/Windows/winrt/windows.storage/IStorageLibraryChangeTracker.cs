// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9E157316-6073-44F6-9681-7492D1286C90")]
    [NativeTypeName("struct IStorageLibraryChangeTracker : IInspectable")]
    public unsafe partial struct IStorageLibraryChangeTracker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, uint>)(lpVtbl[1]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, uint>)(lpVtbl[2]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChangeReader([NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeReader **")] IStorageLibraryChangeReader** value)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, IStorageLibraryChangeReader**, int>)(lpVtbl[6]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, int>)(lpVtbl[7]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeTracker*, int>)(lpVtbl[8]))((IStorageLibraryChangeTracker*)Unsafe.AsPointer(ref this));
        }
    }
}
