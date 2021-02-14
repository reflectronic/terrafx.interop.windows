// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8EB2AFE-A9D9-4B14-B999-E3921379D903")]
    [NativeTypeName("struct IAppDataPathsStatics : IInspectable")]
    public unsafe partial struct IAppDataPathsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, uint>)(lpVtbl[1]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, uint>)(lpVtbl[2]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, IntPtr*, int>)(lpVtbl[4]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForUser([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Storage::IAppDataPaths **")] IAppDataPaths** result)
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, IUser*, IAppDataPaths**, int>)(lpVtbl[6]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this), user, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefault([NativeTypeName("ABI::Windows::Storage::IAppDataPaths **")] IAppDataPaths** result)
        {
            return ((delegate* unmanaged<IAppDataPathsStatics*, IAppDataPaths**, int>)(lpVtbl[7]))((IAppDataPathsStatics*)Unsafe.AsPointer(ref this), result);
        }
    }
}
