// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F67CF363-A53D-4D94-AE2C-67232D93ACDD")]
    [NativeTypeName("struct IStorageStreamTransaction : IInspectable")]
    public unsafe partial struct IStorageStreamTransaction
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, Guid*, void**, int>)(lpVtbl[0]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, uint>)(lpVtbl[1]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, uint>)(lpVtbl[2]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, IntPtr*, int>)(lpVtbl[4]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, TrustLevel*, int>)(lpVtbl[5]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value)
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, IRandomAccessStream**, int>)(lpVtbl[6]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageStreamTransaction*, IAsyncAction**, int>)(lpVtbl[7]))((IStorageStreamTransaction*)Unsafe.AsPointer(ref this), operation);
        }
    }
}