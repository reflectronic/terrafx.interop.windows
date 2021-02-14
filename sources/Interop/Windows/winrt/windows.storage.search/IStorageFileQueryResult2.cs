// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4E5DB9DD-7141-46C4-8BE3-E9DC9E27275C")]
    [NativeTypeName("struct IStorageFileQueryResult2 : IInspectable")]
    public unsafe partial struct IStorageFileQueryResult2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, uint>)(lpVtbl[1]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, uint>)(lpVtbl[2]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, IntPtr*, int>)(lpVtbl[4]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingPropertiesWithRanges([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVectorView_1_Windows__CData__CText__CTextSegment_t **")] IMap<IntPtr, IntPtr>** result)
        {
            return ((delegate* unmanaged<IStorageFileQueryResult2*, IStorageFile*, IMap<IntPtr, IntPtr>**, int>)(lpVtbl[6]))((IStorageFileQueryResult2*)Unsafe.AsPointer(ref this), file, result);
        }
    }
}
