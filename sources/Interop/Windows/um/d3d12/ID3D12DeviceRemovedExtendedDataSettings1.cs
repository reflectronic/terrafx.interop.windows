// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DBD5AE51-3317-4F0A-ADF9-1D7CEDCAAE0B")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DeviceRemovedExtendedDataSettings1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DeviceRemovedExtendedDataSettings1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DeviceRemovedExtendedDataSettings1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetAutoBreadcrumbsEnablement(ID3D12DeviceRemovedExtendedDataSettings1* pThis, D3D12_DRED_ENABLEMENT Enablement);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetPageFaultEnablement(ID3D12DeviceRemovedExtendedDataSettings1* pThis, D3D12_DRED_ENABLEMENT Enablement);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetWatsonDumpEnablement(ID3D12DeviceRemovedExtendedDataSettings1* pThis, D3D12_DRED_ENABLEMENT Enablement);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetBreadcrumbContextEnablement(ID3D12DeviceRemovedExtendedDataSettings1* pThis, D3D12_DRED_ENABLEMENT Enablement);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this));
        }

        public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            Marshal.GetDelegateForFunctionPointer<_SetAutoBreadcrumbsEnablement>(lpVtbl->SetAutoBreadcrumbsEnablement)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            Marshal.GetDelegateForFunctionPointer<_SetPageFaultEnablement>(lpVtbl->SetPageFaultEnablement)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            Marshal.GetDelegateForFunctionPointer<_SetWatsonDumpEnablement>(lpVtbl->SetWatsonDumpEnablement)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetBreadcrumbContextEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            Marshal.GetDelegateForFunctionPointer<_SetBreadcrumbContextEnablement>(lpVtbl->SetBreadcrumbContextEnablement)((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public IntPtr SetAutoBreadcrumbsEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public IntPtr SetPageFaultEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public IntPtr SetWatsonDumpEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public IntPtr SetBreadcrumbContextEnablement;
        }
    }
}