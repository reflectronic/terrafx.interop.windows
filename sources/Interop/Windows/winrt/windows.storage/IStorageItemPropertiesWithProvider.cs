// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("861BF39B-6368-4DEE-B40E-74684A5CE714")]
    [NativeTypeName("struct IStorageItemPropertiesWithProvider : IInspectable")]
    public unsafe partial struct IStorageItemPropertiesWithProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, uint>)(lpVtbl[1]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, uint>)(lpVtbl[2]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, IntPtr*, int>)(lpVtbl[4]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Provider([NativeTypeName("ABI::Windows::Storage::IStorageProvider **")] IStorageProvider** value)
        {
            return ((delegate* unmanaged<IStorageItemPropertiesWithProvider*, IStorageProvider**, int>)(lpVtbl[6]))((IStorageItemPropertiesWithProvider*)Unsafe.AsPointer(ref this), value);
        }
    }
}
