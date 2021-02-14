// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5C76A781-212E-4AF9-8F04-740CAE108974")]
    [NativeTypeName("struct IStorageFileStatics2 : IInspectable")]
    public unsafe partial struct IStorageFileStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, uint>)(lpVtbl[1]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, uint>)(lpVtbl[2]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, IntPtr*, int>)(lpVtbl[4]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileFromPathForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics2*, IUser*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageFileStatics2*)Unsafe.AsPointer(ref this), user, path, operation);
        }
    }
}
