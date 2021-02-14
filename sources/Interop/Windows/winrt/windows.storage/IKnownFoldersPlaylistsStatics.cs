// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DAD5ECD6-306F-4D6A-B496-46BA8EB106CE")]
    [NativeTypeName("struct IKnownFoldersPlaylistsStatics : IInspectable")]
    public unsafe partial struct IKnownFoldersPlaylistsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, uint>)(lpVtbl[1]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, uint>)(lpVtbl[2]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, IntPtr*, int>)(lpVtbl[4]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Playlists([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersPlaylistsStatics*, IStorageFolder**, int>)(lpVtbl[6]))((IKnownFoldersPlaylistsStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
