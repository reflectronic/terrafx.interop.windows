// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C54361B2-54CD-432B-BDBC-4B19C4B470D7")]
    [NativeTypeName("struct IStorageItemExtraProperties : IInspectable")]
    public unsafe partial struct IStorageItemExtraProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, uint>)(lpVtbl[1]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, uint>)(lpVtbl[2]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, IntPtr*, int>)(lpVtbl[4]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RetrievePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMap_2_HSTRING_IInspectable_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, IIterable<IntPtr>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), propertiesToRetrieve, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SavePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_IInspectable_t *")] IIterable<IntPtr>* propertiesToSave, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[7]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), propertiesToSave, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SavePropertiesAsyncOverloadDefault([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageItemExtraProperties*, IAsyncAction**, int>)(lpVtbl[8]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
