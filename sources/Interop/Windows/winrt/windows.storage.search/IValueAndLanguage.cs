// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B9914881-A1EE-4BC4-92A5-466968E30436")]
    [NativeTypeName("struct IValueAndLanguage : IInspectable")]
    public unsafe partial struct IValueAndLanguage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, Guid*, void**, int>)(lpVtbl[0]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IValueAndLanguage*, uint>)(lpVtbl[1]))((IValueAndLanguage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IValueAndLanguage*, uint>)(lpVtbl[2]))((IValueAndLanguage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, uint*, Guid**, int>)(lpVtbl[3]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, IntPtr*, int>)(lpVtbl[4]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, TrustLevel*, int>)(lpVtbl[5]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Language([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, IntPtr*, int>)(lpVtbl[6]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Language([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, IntPtr, int>)(lpVtbl[7]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Value([NativeTypeName("IInspectable **")] IInspectable** value)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, IInspectable**, int>)(lpVtbl[8]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Value([NativeTypeName("IInspectable *")] IInspectable* value)
        {
            return ((delegate* unmanaged<IValueAndLanguage*, IInspectable*, int>)(lpVtbl[9]))((IValueAndLanguage*)Unsafe.AsPointer(ref this), value);
        }
    }
}
