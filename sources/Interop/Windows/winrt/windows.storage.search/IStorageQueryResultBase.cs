// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C297D70D-7353-47AB-BA58-8C61425DC54B")]
    [NativeTypeName("struct IStorageQueryResultBase : IInspectable")]
    public unsafe partial struct IStorageQueryResultBase
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, Guid*, void**, int>)(lpVtbl[0]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, uint>)(lpVtbl[1]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, uint>)(lpVtbl[2]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, IntPtr*, int>)(lpVtbl[4]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, TrustLevel*, int>)(lpVtbl[5]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, IAsyncOperation<uint>**, int>)(lpVtbl[6]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** container)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, IStorageFolder**, int>)(lpVtbl[7]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), container);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_ContentsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* eventCookie)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), handler, eventCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_ContentsChanged(EventRegistrationToken eventCookie)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, EventRegistrationToken, int>)(lpVtbl[9]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), eventCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_OptionsChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* changedHandler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* eventCookie)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), changedHandler, eventCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_OptionsChanged(EventRegistrationToken eventCookie)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, EventRegistrationToken, int>)(lpVtbl[11]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), eventCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindStartIndexAsync([NativeTypeName("IInspectable *")] IInspectable* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, IInspectable*, IAsyncOperation<uint>**, int>)(lpVtbl[12]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), value, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentQueryOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** value)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, IQueryOptions**, int>)(lpVtbl[13]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyNewQueryOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* newQueryOptions)
        {
            return ((delegate* unmanaged<IStorageQueryResultBase*, IQueryOptions*, int>)(lpVtbl[14]))((IStorageQueryResultBase*)Unsafe.AsPointer(ref this), newQueryOptions);
        }
    }
}
