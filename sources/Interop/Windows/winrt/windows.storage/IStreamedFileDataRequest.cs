// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1673FCCE-DABD-4D50-BEEE-180B8A8191B6")]
    [NativeTypeName("struct IStreamedFileDataRequest : IInspectable")]
    public unsafe partial struct IStreamedFileDataRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, Guid*, void**, int>)(lpVtbl[0]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, uint>)(lpVtbl[1]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, uint>)(lpVtbl[2]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, IntPtr*, int>)(lpVtbl[4]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, TrustLevel*, int>)(lpVtbl[5]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FailAndClose([NativeTypeName("ABI::Windows::Storage::StreamedFileFailureMode")] StreamedFileFailureMode failureMode)
        {
            return ((delegate* unmanaged<IStreamedFileDataRequest*, StreamedFileFailureMode, int>)(lpVtbl[6]))((IStreamedFileDataRequest*)Unsafe.AsPointer(ref this), failureMode);
        }
    }
}
