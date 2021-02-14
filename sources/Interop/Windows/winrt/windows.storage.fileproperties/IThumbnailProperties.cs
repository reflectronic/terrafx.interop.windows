// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("693DD42F-DBE7-49B5-B3B3-2893AC5D3423")]
    [NativeTypeName("struct IThumbnailProperties : IInspectable")]
    public unsafe partial struct IThumbnailProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailProperties*, uint>)(lpVtbl[1]))((IThumbnailProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailProperties*, uint>)(lpVtbl[2]))((IThumbnailProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, IntPtr*, int>)(lpVtbl[4]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, TrustLevel*, int>)(lpVtbl[5]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OriginalWidth([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, uint*, int>)(lpVtbl[6]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OriginalHeight([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, uint*, int>)(lpVtbl[7]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ReturnedSmallerCachedSize([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, byte*, int>)(lpVtbl[8]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailType *")] ThumbnailType* value)
        {
            return ((delegate* unmanaged<IThumbnailProperties*, ThumbnailType*, int>)(lpVtbl[9]))((IThumbnailProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
