// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B9C76B9B-1056-4E69-8330-162619956F9B")]
    [NativeTypeName("struct ISetVersionRequest : IInspectable")]
    public unsafe partial struct ISetVersionRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, Guid*, void**, int>)(lpVtbl[0]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISetVersionRequest*, uint>)(lpVtbl[1]))((ISetVersionRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISetVersionRequest*, uint>)(lpVtbl[2]))((ISetVersionRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, uint*, Guid**, int>)(lpVtbl[3]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, IntPtr*, int>)(lpVtbl[4]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, TrustLevel*, int>)(lpVtbl[5]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentVersion([NativeTypeName("UINT32 *")] uint* currentVersion)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, uint*, int>)(lpVtbl[6]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), currentVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredVersion([NativeTypeName("UINT32 *")] uint* desiredVersion)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, uint*, int>)(lpVtbl[7]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), desiredVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeferral([NativeTypeName("ABI::Windows::Storage::ISetVersionDeferral **")] ISetVersionDeferral** deferral)
        {
            return ((delegate* unmanaged<ISetVersionRequest*, ISetVersionDeferral**, int>)(lpVtbl[8]))((ISetVersionRequest*)Unsafe.AsPointer(ref this), deferral);
        }
    }
}
