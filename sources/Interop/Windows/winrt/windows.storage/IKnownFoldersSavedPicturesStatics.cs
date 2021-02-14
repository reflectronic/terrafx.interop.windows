// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("055C93EA-253D-467C-B6CA-A97DA1E9A18D")]
    [NativeTypeName("struct IKnownFoldersSavedPicturesStatics : IInspectable")]
    public unsafe partial struct IKnownFoldersSavedPicturesStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, uint>)(lpVtbl[1]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, uint>)(lpVtbl[2]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, IntPtr*, int>)(lpVtbl[4]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SavedPictures([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersSavedPicturesStatics*, IStorageFolder**, int>)(lpVtbl[6]))((IKnownFoldersSavedPicturesStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
