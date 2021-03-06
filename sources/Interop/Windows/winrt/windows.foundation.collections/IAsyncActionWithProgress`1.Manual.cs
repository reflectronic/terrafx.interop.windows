// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F6DB258-E803-48A1-9546-EB7353398884")]
    public unsafe partial struct IAsyncActionWithProgress<TProgress>
        where TProgress : unmanaged
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, uint>)(lpVtbl[1]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, uint>)(lpVtbl[2]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, uint*, Guid**, int>)(lpVtbl[3]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, IntPtr*, int>)(lpVtbl[4]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, TrustLevel*, int>)(lpVtbl[5]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Progress([NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> *")] IAsyncActionWithProgressCompletedHandler<TProgress>* handler)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, IAsyncActionWithProgressCompletedHandler<TProgress>*, int>)(lpVtbl[6]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Progress([NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> **")] IAsyncActionWithProgressCompletedHandler<TProgress>** handler)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, IAsyncActionWithProgressCompletedHandler<TProgress>**, int>)(lpVtbl[7]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Completed([NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> *")] IAsyncActionWithProgressCompletedHandler<TProgress>* handler)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, IAsyncActionWithProgressCompletedHandler<TProgress>*, int>)(lpVtbl[8]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Completed([NativeTypeName("IAsyncActionWithProgressCompletedHandler<TProgress_logical> **")] IAsyncActionWithProgressCompletedHandler<TProgress>** handler)
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, IAsyncActionWithProgressCompletedHandler<TProgress>**, int>)(lpVtbl[9]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResults()
        {
            return ((delegate* unmanaged<IAsyncActionWithProgress<TProgress>*, int>)(lpVtbl[10]))((IAsyncActionWithProgress<TProgress>*)Unsafe.AsPointer(ref this));
        }
    }
}
