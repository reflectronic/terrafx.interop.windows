// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1EDD7103-0E5E-4D6C-B5E8-9318983D6A03")]
    [NativeTypeName("struct IStorageLibrary : IInspectable")]
    public unsafe partial struct IStorageLibrary
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibrary*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibrary*, uint>)(lpVtbl[1]))((IStorageLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibrary*, uint>)(lpVtbl[2]))((IStorageLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibrary*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibrary*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibrary*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibrary*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibrary*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibrary*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAddFolderAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageLibrary*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageLibrary*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestRemoveFolderAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* folder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<IStorageLibrary*, IStorageFolder*, IAsyncOperation<byte>**, int>)(lpVtbl[7]))((IStorageLibrary*)Unsafe.AsPointer(ref this), folder, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Folders([NativeTypeName("ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CStorage__CStorageFolder_t **")] IObservableVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IStorageLibrary*, IObservableVector<IntPtr>**, int>)(lpVtbl[8]))((IStorageLibrary*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SaveFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IStorageLibrary*, IStorageFolder**, int>)(lpVtbl[9]))((IStorageLibrary*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_DefinitionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CStorageLibrary_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* eventCookie)
        {
            return ((delegate* unmanaged<IStorageLibrary*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IStorageLibrary*)Unsafe.AsPointer(ref this), handler, eventCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_DefinitionChanged(EventRegistrationToken eventCookie)
        {
            return ((delegate* unmanaged<IStorageLibrary*, EventRegistrationToken, int>)(lpVtbl[11]))((IStorageLibrary*)Unsafe.AsPointer(ref this), eventCookie);
        }
    }
}
