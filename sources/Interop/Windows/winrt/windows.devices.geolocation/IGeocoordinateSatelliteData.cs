// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C32A74D9-2608-474C-912C-06DD490F4AF7")]
    [NativeTypeName("struct IGeocoordinateSatelliteData : IInspectable")]
    public unsafe partial struct IGeocoordinateSatelliteData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, uint>)(lpVtbl[1]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, uint>)(lpVtbl[2]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, IntPtr*, int>)(lpVtbl[4]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PositionDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, IReference<double>**, int>)(lpVtbl[6]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), ppValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_HorizontalDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, IReference<double>**, int>)(lpVtbl[7]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), ppValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VerticalDilutionOfPrecision([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** ppValue)
        {
            return ((delegate* unmanaged<IGeocoordinateSatelliteData*, IReference<double>**, int>)(lpVtbl[8]))((IGeocoordinateSatelliteData*)Unsafe.AsPointer(ref this), ppValue);
        }
    }
}
