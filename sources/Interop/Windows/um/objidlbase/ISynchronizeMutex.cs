// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000025-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISynchronizeMutex : ISynchronize")]
    public unsafe partial struct ISynchronizeMutex
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, uint>)(lpVtbl[1]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, uint>)(lpVtbl[2]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, uint, uint, int>)(lpVtbl[3]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this), dwFlags, dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Signal()
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, int>)(lpVtbl[4]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, int>)(lpVtbl[5]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseMutex()
        {
            return ((delegate* unmanaged<ISynchronizeMutex*, int>)(lpVtbl[6]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
        }
    }
}