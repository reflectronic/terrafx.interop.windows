// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC8AAB62-66EC-419A-BC5D-CA65A4CB46DA")]
    [NativeTypeName("struct IMusicProperties : IInspectable")]
    public unsafe partial struct IMusicProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMusicProperties*, Guid*, void**, int>)(lpVtbl[0]))((IMusicProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMusicProperties*, uint>)(lpVtbl[1]))((IMusicProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMusicProperties*, uint>)(lpVtbl[2]))((IMusicProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IMusicProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[4]))((IMusicProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMusicProperties*, TrustLevel*, int>)(lpVtbl[5]))((IMusicProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Album([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[6]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Album([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr, int>)(lpVtbl[7]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Artist([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[8]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Artist([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr, int>)(lpVtbl[9]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Genre([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IVector<IntPtr>**, int>)(lpVtbl[10]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TrackNumber([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint*, int>)(lpVtbl[11]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TrackNumber([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint, int>)(lpVtbl[12]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[13]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Title([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr, int>)(lpVtbl[14]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rating([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint*, int>)(lpVtbl[15]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Rating([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint, int>)(lpVtbl[16]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, TimeSpan*, int>)(lpVtbl[17]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bitrate([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint*, int>)(lpVtbl[18]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AlbumArtist([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[19]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_AlbumArtist([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr, int>)(lpVtbl[20]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Composers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IVector<IntPtr>**, int>)(lpVtbl[21]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Conductors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IVector<IntPtr>**, int>)(lpVtbl[22]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Subtitle([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[23]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Subtitle([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr, int>)(lpVtbl[24]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Producers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IVector<IntPtr>**, int>)(lpVtbl[25]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Publisher([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr*, int>)(lpVtbl[26]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Publisher([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IntPtr, int>)(lpVtbl[27]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Writers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IMusicProperties*, IVector<IntPtr>**, int>)(lpVtbl[28]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Year([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint*, int>)(lpVtbl[29]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Year([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IMusicProperties*, uint, int>)(lpVtbl[30]))((IMusicProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
