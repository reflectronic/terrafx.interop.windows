// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56AFC-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IRpcStubBuffer : IUnknown")]
    public unsafe partial struct IRpcStubBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[1]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[2]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Connect(IUnknown* pUnkServer)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, IUnknown*, int>)(lpVtbl[3]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pUnkServer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Disconnect()
        {
            ((delegate* unmanaged<IRpcStubBuffer*, void>)(lpVtbl[4]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke(RPCOLEMESSAGE* _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, RPCOLEMESSAGE*, IRpcChannelBuffer*, int>)(lpVtbl[5]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), _prpcmsg, _pRpcChannelBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IRpcStubBuffer* IsIIDSupported([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)(lpVtbl[6]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint CountRefs()
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[7]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DebugServerQueryInterface(void** ppv)
        {
            return ((delegate* unmanaged<IRpcStubBuffer*, void**, int>)(lpVtbl[8]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void DebugServerRelease(void* pv)
        {
            ((delegate* unmanaged<IRpcStubBuffer*, void*, void>)(lpVtbl[9]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pv);
        }
    }
}
