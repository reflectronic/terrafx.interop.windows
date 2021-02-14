// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("01B29DEF-E062-48A1-8B0C-F2C7A9CA56C0")]
    [NativeTypeName("struct IUserDataPathsStatics : IInspectable")]
    public unsafe partial struct IUserDataPathsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, uint>)(lpVtbl[1]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, uint>)(lpVtbl[2]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, IntPtr*, int>)(lpVtbl[4]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths** result)
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, IUser*, IUserDataPaths**, int>)(lpVtbl[6]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), user, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefault([NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths** result)
        {
            return ((delegate* unmanaged<IUserDataPathsStatics*, IUserDataPaths**, int>)(lpVtbl[7]))((IUserDataPathsStatics*)Unsafe.AsPointer(ref this), result);
        }
    }
}
