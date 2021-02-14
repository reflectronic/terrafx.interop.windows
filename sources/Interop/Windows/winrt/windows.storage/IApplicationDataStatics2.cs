// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CD606211-CF49-40A4-A47C-C7F0DBBA8107")]
    [NativeTypeName("struct IApplicationDataStatics2 : IInspectable")]
    public unsafe partial struct IApplicationDataStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, uint>)(lpVtbl[1]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, uint>)(lpVtbl[2]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, IntPtr*, int>)(lpVtbl[4]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CApplicationData_t **")] IAsyncOperation<IntPtr>** getForUserOperation)
        {
            return ((delegate* unmanaged<IApplicationDataStatics2*, IUser*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IApplicationDataStatics2*)Unsafe.AsPointer(ref this), user, getForUserOperation);
        }
    }
}
