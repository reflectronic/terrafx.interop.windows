// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A2A7520-4802-452D-9AD9-4351ADA7EC35")]
    [NativeTypeName("struct IKnownFoldersStatics : IInspectable")]
    public unsafe partial struct IKnownFoldersStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, uint>)(lpVtbl[1]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, uint>)(lpVtbl[2]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IntPtr*, int>)(lpVtbl[4]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MusicLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[6]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PicturesLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[7]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VideosLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[8]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DocumentsLibrary([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[9]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HomeGroup([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[10]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RemovableDevices([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[11]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MediaServerDevices([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics*, IStorageFolder**, int>)(lpVtbl[12]))((IKnownFoldersStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
