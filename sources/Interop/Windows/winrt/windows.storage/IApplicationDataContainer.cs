// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5AEFD1E-F467-40BA-8566-AB640A441E1D")]
    [NativeTypeName("struct IApplicationDataContainer : IInspectable")]
    public unsafe partial struct IApplicationDataContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, uint>)(lpVtbl[1]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, uint>)(lpVtbl[2]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, IntPtr*, int>)(lpVtbl[4]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, IntPtr*, int>)(lpVtbl[6]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Locality([NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality *")] ApplicationDataLocality* value)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, ApplicationDataLocality*, int>)(lpVtbl[7]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Values([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")] IPropertySet** value)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, IPropertySet**, int>)(lpVtbl[8]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Containers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **")] IMapView<IntPtr, IntPtr>** value)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, IMapView<IntPtr, IntPtr>**, int>)(lpVtbl[9]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContainer([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("ABI::Windows::Storage::ApplicationDataCreateDisposition")] ApplicationDataCreateDisposition disposition, [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** container)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, IntPtr, ApplicationDataCreateDisposition, IApplicationDataContainer**, int>)(lpVtbl[10]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), name, disposition, container);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteContainer([NativeTypeName("HSTRING")] IntPtr name)
        {
            return ((delegate* unmanaged<IApplicationDataContainer*, IntPtr, int>)(lpVtbl[11]))((IApplicationDataContainer*)Unsafe.AsPointer(ref this), name);
        }
    }
}
