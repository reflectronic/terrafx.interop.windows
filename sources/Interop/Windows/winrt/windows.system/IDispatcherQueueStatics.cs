// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A96D83D7-9371-4517-9245-D0824AC12C74")]
    [NativeTypeName("struct IDispatcherQueueStatics : IInspectable")]
    public unsafe partial struct IDispatcherQueueStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, uint>)(lpVtbl[1]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, uint>)(lpVtbl[2]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, IntPtr*, int>)(lpVtbl[4]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForCurrentThread([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** result)
        {
            return ((delegate* unmanaged<IDispatcherQueueStatics*, IDispatcherQueue**, int>)(lpVtbl[6]))((IDispatcherQueueStatics*)Unsafe.AsPointer(ref this), result);
        }
    }
}
