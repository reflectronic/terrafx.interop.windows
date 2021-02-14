// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4208A6DB-684A-49C6-9E59-90121EE050D6")]
    [NativeTypeName("struct IStorageLibraryStatics : IInspectable")]
    public unsafe partial struct IStorageLibraryStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, uint>)(lpVtbl[1]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, uint>)(lpVtbl[2]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLibraryAsync([NativeTypeName("ABI::Windows::Storage::KnownLibraryId")] KnownLibraryId libraryId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageLibrary_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageLibraryStatics*, KnownLibraryId, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageLibraryStatics*)Unsafe.AsPointer(ref this), libraryId, operation);
        }
    }
}
