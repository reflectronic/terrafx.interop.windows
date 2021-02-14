// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("523C9424-FCFF-4275-AFEE-ECDB9AB47973")]
    [NativeTypeName("struct IImageProperties : IInspectable")]
    public unsafe partial struct IImageProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IImageProperties*, Guid*, void**, int>)(lpVtbl[0]))((IImageProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageProperties*, uint>)(lpVtbl[1]))((IImageProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageProperties*, uint>)(lpVtbl[2]))((IImageProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IImageProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IImageProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr*, int>)(lpVtbl[4]))((IImageProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IImageProperties*, TrustLevel*, int>)(lpVtbl[5]))((IImageProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rating([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IImageProperties*, uint*, int>)(lpVtbl[6]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Rating([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IImageProperties*, uint, int>)(lpVtbl[7]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Keywords([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IImageProperties*, IVector<IntPtr>**, int>)(lpVtbl[8]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DateTaken([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IImageProperties*, DateTime*, int>)(lpVtbl[9]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DateTaken([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime value)
        {
            return ((delegate* unmanaged<IImageProperties*, DateTime, int>)(lpVtbl[10]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IImageProperties*, uint*, int>)(lpVtbl[11]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IImageProperties*, uint*, int>)(lpVtbl[12]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Title([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr*, int>)(lpVtbl[13]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Title([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr, int>)(lpVtbl[14]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Latitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IImageProperties*, IReference<double>**, int>)(lpVtbl[15]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Longitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IImageProperties*, IReference<double>**, int>)(lpVtbl[16]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CameraManufacturer([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr*, int>)(lpVtbl[17]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CameraManufacturer([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr, int>)(lpVtbl[18]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CameraModel([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr*, int>)(lpVtbl[19]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CameraModel([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IImageProperties*, IntPtr, int>)(lpVtbl[20]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Orientation([NativeTypeName("ABI::Windows::Storage::FileProperties::PhotoOrientation *")] PhotoOrientation* value)
        {
            return ((delegate* unmanaged<IImageProperties*, PhotoOrientation*, int>)(lpVtbl[21]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PeopleNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<IntPtr>** value)
        {
            return ((delegate* unmanaged<IImageProperties*, IVectorView<IntPtr>**, int>)(lpVtbl[22]))((IImageProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
