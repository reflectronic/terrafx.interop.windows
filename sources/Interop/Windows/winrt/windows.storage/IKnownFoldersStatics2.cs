// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("194BD0CD-CF6E-4D07-9D53-E9163A2536E9")]
    [NativeTypeName("struct IKnownFoldersStatics2 : IInspectable")]
    public unsafe partial struct IKnownFoldersStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, uint>)(lpVtbl[1]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, uint>)(lpVtbl[2]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, IntPtr*, int>)(lpVtbl[4]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Objects3D([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, IStorageFolder**, int>)(lpVtbl[6]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppCaptures([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, IStorageFolder**, int>)(lpVtbl[7]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RecordedCalls([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IKnownFoldersStatics2*, IStorageFolder**, int>)(lpVtbl[8]))((IKnownFoldersStatics2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
