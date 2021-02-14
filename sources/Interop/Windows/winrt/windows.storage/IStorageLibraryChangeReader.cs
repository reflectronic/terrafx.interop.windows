// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F205BC83-FCA2-41F9-8954-EE2E991EB96F")]
    [NativeTypeName("struct IStorageLibraryChangeReader : IInspectable")]
    public unsafe partial struct IStorageLibraryChangeReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, uint>)(lpVtbl[1]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, uint>)(lpVtbl[2]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBatchAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageLibraryChange_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AcceptChangesAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageLibraryChangeReader*, IAsyncAction**, int>)(lpVtbl[7]))((IStorageLibraryChangeReader*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
