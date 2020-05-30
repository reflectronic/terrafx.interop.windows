// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("894AD3B0-EF97-11CE-9BC9-00AA00608E01")]
    public unsafe partial struct IOleUndoUnit
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleUndoUnit* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleUndoUnit* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleUndoUnit* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Do(IOleUndoUnit* pThis, [NativeTypeName("IOleUndoManager *")] IOleUndoManager* pUndoManager);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDescription(IOleUndoUnit* pThis, [NativeTypeName("BSTR *")] ushort** pBstr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUnitType(IOleUndoUnit* pThis, [NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnNextAdd(IOleUndoUnit* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Do([NativeTypeName("IOleUndoManager *")] IOleUndoManager* pUndoManager)
        {
            return Marshal.GetDelegateForFunctionPointer<_Do>(lpVtbl->Do)((IOleUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)((IOleUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUnitType>(lpVtbl->GetUnitType)((IOleUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnNextAdd()
        {
            return Marshal.GetDelegateForFunctionPointer<_OnNextAdd>(lpVtbl->OnNextAdd)((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
            public IntPtr Do;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDescription;

            [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
            public IntPtr GetUnitType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr OnNextAdd;
        }
    }
}