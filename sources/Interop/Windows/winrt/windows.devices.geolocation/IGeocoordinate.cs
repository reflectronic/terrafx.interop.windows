// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EE21A3AA-976A-4C70-803D-083EA55BCBC4")]
    [NativeTypeName("struct IGeocoordinate : IInspectable")]
    public unsafe partial struct IGeocoordinate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeocoordinate*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeocoordinate*, uint>)(lpVtbl[1]))((IGeocoordinate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeocoordinate*, uint>)(lpVtbl[2]))((IGeocoordinate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeocoordinate*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinate*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeocoordinate*, IntPtr*, int>)(lpVtbl[4]))((IGeocoordinate*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeocoordinate*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinate*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Latitude([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, double*, int>)(lpVtbl[6]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Longitude([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, double*, int>)(lpVtbl[7]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Altitude([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[8]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Accuracy([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, double*, int>)(lpVtbl[9]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AltitudeAccuracy([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[10]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Heading([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[11]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Speed([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, IReference<double>**, int>)(lpVtbl[12]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IGeocoordinate*, DateTime*, int>)(lpVtbl[13]))((IGeocoordinate*)Unsafe.AsPointer(ref this), value);
        }
    }
}
