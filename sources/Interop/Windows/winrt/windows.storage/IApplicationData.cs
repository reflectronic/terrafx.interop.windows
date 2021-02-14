// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C3DA6FB7-B744-4B45-B0B8-223A0938D0DC")]
    [NativeTypeName("struct IApplicationData : IInspectable")]
    public unsafe partial struct IApplicationData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationData*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationData*, uint>)(lpVtbl[1]))((IApplicationData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationData*, uint>)(lpVtbl[2]))((IApplicationData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IApplicationData*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationData*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IApplicationData*, IntPtr*, int>)(lpVtbl[4]))((IApplicationData*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IApplicationData*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationData*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Version([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IApplicationData*, uint*, int>)(lpVtbl[6]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVersionAsync([NativeTypeName("UINT32")] uint desiredVersion, [NativeTypeName("ABI::Windows::Storage::IApplicationDataSetVersionHandler *")] IApplicationDataSetVersionHandler* handler, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** setVersionOperation)
        {
            return ((delegate* unmanaged<IApplicationData*, uint, IApplicationDataSetVersionHandler*, IAsyncAction**, int>)(lpVtbl[7]))((IApplicationData*)Unsafe.AsPointer(ref this), desiredVersion, handler, setVersionOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearAllAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation)
        {
            return ((delegate* unmanaged<IApplicationData*, IAsyncAction**, int>)(lpVtbl[8]))((IApplicationData*)Unsafe.AsPointer(ref this), clearOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearAsync([NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality")] ApplicationDataLocality locality, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation)
        {
            return ((delegate* unmanaged<IApplicationData*, ApplicationDataLocality, IAsyncAction**, int>)(lpVtbl[9]))((IApplicationData*)Unsafe.AsPointer(ref this), locality, clearOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocalSettings([NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** value)
        {
            return ((delegate* unmanaged<IApplicationData*, IApplicationDataContainer**, int>)(lpVtbl[10]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RoamingSettings([NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** value)
        {
            return ((delegate* unmanaged<IApplicationData*, IApplicationDataContainer**, int>)(lpVtbl[11]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocalFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IApplicationData*, IStorageFolder**, int>)(lpVtbl[12]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RoamingFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IApplicationData*, IStorageFolder**, int>)(lpVtbl[13]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TemporaryFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IApplicationData*, IStorageFolder**, int>)(lpVtbl[14]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_DataChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IApplicationData*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IApplicationData*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_DataChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IApplicationData*, EventRegistrationToken, int>)(lpVtbl[16]))((IApplicationData*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SignalDataChanged()
        {
            return ((delegate* unmanaged<IApplicationData*, int>)(lpVtbl[17]))((IApplicationData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RoamingStorageQuota([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IApplicationData*, ulong*, int>)(lpVtbl[18]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
        }
    }
}
