// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C719D963-2B2D-415E-ACF7-7EB7CA596FF4")]
    [NativeTypeName("struct IDedupBackupSupport : IUnknown")]
    public unsafe partial struct IDedupBackupSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDedupBackupSupport*, Guid*, void**, int>)(lpVtbl[0]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDedupBackupSupport*, uint>)(lpVtbl[1]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDedupBackupSupport*, uint>)(lpVtbl[2]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreFiles([NativeTypeName("ULONG")] uint NumberOfFiles, [NativeTypeName("BSTR *")] ushort** FileFullPaths, [NativeTypeName("IDedupReadFileCallback *")] IDedupReadFileCallback* Store, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HRESULT *")] int* FileResults)
        {
            return ((delegate* unmanaged<IDedupBackupSupport*, uint, ushort**, IDedupReadFileCallback*, uint, int*, int>)(lpVtbl[3]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this), NumberOfFiles, FileFullPaths, Store, Flags, FileResults);
        }
    }
}
