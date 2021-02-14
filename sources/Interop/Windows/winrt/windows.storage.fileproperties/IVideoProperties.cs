// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("719AE507-68DE-4DB8-97DE-49998C059F2F")]
    [NativeTypeName("struct IVideoProperties : IInspectable")]
    public unsafe partial struct IVideoProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVideoProperties*, Guid*, void**, int>)(lpVtbl[0]))((IVideoProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVideoProperties*, uint>)(lpVtbl[1]))((IVideoProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVideoProperties*, uint>)(lpVtbl[2]))((IVideoProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr*, int>)(lpVtbl[4]))((IVideoProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IVideoProperties*, TrustLevel*, int>)(lpVtbl[5]))((IVideoProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rating([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint*, int>)(lpVtbl[6]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Rating([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint, int>)(lpVtbl[7]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Keywords([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IVector<IntPtr>**, int>)(lpVtbl[8]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint*, int>)(lpVtbl[9]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint*, int>)(lpVtbl[10]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Duration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, TimeSpan*, int>)(lpVtbl[11]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Latitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IReference<double>**, int>)(lpVtbl[12]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Longitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IReference<double>**, int>)(lpVtbl[13]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr*, int>)(lpVtbl[14]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Title([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr, int>)(lpVtbl[15]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Subtitle([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr*, int>)(lpVtbl[16]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Subtitle([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr, int>)(lpVtbl[17]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Producers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IVector<IntPtr>**, int>)(lpVtbl[18]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Publisher([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr*, int>)(lpVtbl[19]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Publisher([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IntPtr, int>)(lpVtbl[20]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Writers([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IVector<IntPtr>**, int>)(lpVtbl[21]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Year([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint*, int>)(lpVtbl[22]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Year([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint, int>)(lpVtbl[23]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bitrate([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, uint*, int>)(lpVtbl[24]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Directors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IVideoProperties*, IVector<IntPtr>**, int>)(lpVtbl[25]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Orientation([NativeTypeName("ABI::Windows::Storage::FileProperties::VideoOrientation *")] VideoOrientation* value)
        {
            return ((delegate* unmanaged<IVideoProperties*, VideoOrientation*, int>)(lpVtbl[26]))((IVideoProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
