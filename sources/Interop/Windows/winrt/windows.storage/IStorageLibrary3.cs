// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8A281291-2154-4201-8113-D2C05CE1AD23")]
    [NativeTypeName("struct IStorageLibrary3 : IInspectable")]
    public unsafe partial struct IStorageLibrary3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibrary3*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibrary3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibrary3*, uint>)(lpVtbl[1]))((IStorageLibrary3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibrary3*, uint>)(lpVtbl[2]))((IStorageLibrary3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibrary3*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibrary3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibrary3*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibrary3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibrary3*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibrary3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AreFolderSuggestionsAvailableAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<IStorageLibrary3*, IAsyncOperation<byte>**, int>)(lpVtbl[6]))((IStorageLibrary3*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
