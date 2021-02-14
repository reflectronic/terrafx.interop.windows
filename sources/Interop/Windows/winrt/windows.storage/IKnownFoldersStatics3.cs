// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5194341-9742-4ED5-823D-FC1401148764")]
    [NativeTypeName("struct IKnownFoldersStatics3 : IInspectable")]
    public unsafe partial struct IKnownFoldersStatics3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, uint>)(lpVtbl[1]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, uint>)(lpVtbl[2]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, IntPtr*, int>)(lpVtbl[4]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::KnownFolderId")] KnownFolderId folderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics3*, IUser*, KnownFolderId, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IKnownFoldersStatics3*)Unsafe.AsPointer(ref this), user, folderId, operation);
        }
    }
}
