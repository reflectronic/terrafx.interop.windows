// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D05D55DB-785E-4A66-BE02-9BEEC58AEA81")]
    [NativeTypeName("struct IBasicProperties : IInspectable")]
    public unsafe partial struct IBasicProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IBasicProperties*, Guid*, void**, int>)(lpVtbl[0]))((IBasicProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBasicProperties*, uint>)(lpVtbl[1]))((IBasicProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBasicProperties*, uint>)(lpVtbl[2]))((IBasicProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IBasicProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IBasicProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IBasicProperties*, IntPtr*, int>)(lpVtbl[4]))((IBasicProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IBasicProperties*, TrustLevel*, int>)(lpVtbl[5]))((IBasicProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Size([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IBasicProperties*, ulong*, int>)(lpVtbl[6]))((IBasicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DateModified([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IBasicProperties*, DateTime*, int>)(lpVtbl[7]))((IBasicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ItemDate([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IBasicProperties*, DateTime*, int>)(lpVtbl[8]))((IBasicProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
