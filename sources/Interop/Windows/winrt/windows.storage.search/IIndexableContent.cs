// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CCF1A05F-D4B5-483A-B06E-E0DB1EC420E4")]
    [NativeTypeName("struct IIndexableContent : IInspectable")]
    public unsafe partial struct IIndexableContent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IIndexableContent*, Guid*, void**, int>)(lpVtbl[0]))((IIndexableContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIndexableContent*, uint>)(lpVtbl[1]))((IIndexableContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIndexableContent*, uint>)(lpVtbl[2]))((IIndexableContent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IIndexableContent*, uint*, Guid**, int>)(lpVtbl[3]))((IIndexableContent*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IIndexableContent*, IntPtr*, int>)(lpVtbl[4]))((IIndexableContent*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IIndexableContent*, TrustLevel*, int>)(lpVtbl[5]))((IIndexableContent*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IntPtr*, int>)(lpVtbl[6]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Id([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IntPtr, int>)(lpVtbl[7]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **")] IMap<IntPtr, IntPtr>** value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IMap<IntPtr, IntPtr>**, int>)(lpVtbl[8]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IRandomAccessStream**, int>)(lpVtbl[9]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Stream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IRandomAccessStream*, int>)(lpVtbl[10]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StreamContentType([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IntPtr*, int>)(lpVtbl[11]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StreamContentType([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IIndexableContent*, IntPtr, int>)(lpVtbl[12]))((IIndexableContent*)Unsafe.AsPointer(ref this), value);
        }
    }
}
