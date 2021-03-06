// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ACF92459-6A61-42BD-B57C-B43E51203CB0")]
    [NativeTypeName("struct IMFContentProtectionManager : IUnknown")]
    public unsafe partial struct IMFContentProtectionManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentProtectionManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentProtectionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentProtectionManager*, uint>)(lpVtbl[1]))((IMFContentProtectionManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentProtectionManager*, uint>)(lpVtbl[2]))((IMFContentProtectionManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginEnableContent(IMFActivate* pEnablerActivate, IMFTopology* pTopo, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFContentProtectionManager*, IMFActivate*, IMFTopology*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFContentProtectionManager*)Unsafe.AsPointer(ref this), pEnablerActivate, pTopo, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndEnableContent(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFContentProtectionManager*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFContentProtectionManager*)Unsafe.AsPointer(ref this), pResult);
        }
    }
}
