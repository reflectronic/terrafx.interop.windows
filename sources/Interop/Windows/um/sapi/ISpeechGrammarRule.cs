// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFE719CF-5DD1-44F2-999C-7A399F1CFCCC")]
    [NativeTypeName("struct ISpeechGrammarRule : IDispatch")]
    public unsafe partial struct ISpeechGrammarRule
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, uint>)(lpVtbl[1]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, uint>)(lpVtbl[2]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Attributes(SpeechRuleAttributes* Attributes)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, SpeechRuleAttributes*, int>)(lpVtbl[7]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), Attributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialState(ISpeechGrammarRuleState** State)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, ISpeechGrammarRuleState**, int>)(lpVtbl[8]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, ushort**, int>)(lpVtbl[9]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("long *")] int* Id)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, int*, int>)(lpVtbl[10]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clear()
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, int>)(lpVtbl[11]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddResource([NativeTypeName("const BSTR")] ushort* ResourceName, [NativeTypeName("const BSTR")] ushort* ResourceValue)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, ushort*, ushort*, int>)(lpVtbl[12]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), ResourceName, ResourceValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddState(ISpeechGrammarRuleState** State)
        {
            return ((delegate* unmanaged<ISpeechGrammarRule*, ISpeechGrammarRuleState**, int>)(lpVtbl[13]))((ISpeechGrammarRule*)Unsafe.AsPointer(ref this), State);
        }
    }
}
