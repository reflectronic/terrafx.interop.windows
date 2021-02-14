// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4833896F-80D1-5DD6-92A7-62A508FFEF5A")]
    [NativeTypeName("struct ISystemFunctionButtonEventArgs : IInspectable")]
    public unsafe partial struct ISystemFunctionButtonEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, uint>)(lpVtbl[1]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, uint>)(lpVtbl[2]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, IntPtr*, int>)(lpVtbl[4]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, ulong*, int>)(lpVtbl[6]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Handled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, byte*, int>)(lpVtbl[7]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Handled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ISystemFunctionButtonEventArgs*, byte, int>)(lpVtbl[8]))((ISystemFunctionButtonEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
