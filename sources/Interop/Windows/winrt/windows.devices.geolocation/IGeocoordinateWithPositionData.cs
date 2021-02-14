// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("95E634BE-DBD6-40AC-B8F2-A65C0340D9A6")]
    [NativeTypeName("struct IGeocoordinateWithPositionData : IInspectable")]
    public unsafe partial struct IGeocoordinateWithPositionData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, uint>)(lpVtbl[1]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, uint>)(lpVtbl[2]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, IntPtr*, int>)(lpVtbl[4]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PositionSource([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionSource *")] PositionSource* pValue)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, PositionSource*, int>)(lpVtbl[6]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this), pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SatelliteData([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocoordinateSatelliteData **")] IGeocoordinateSatelliteData** ppValue)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionData*, IGeocoordinateSatelliteData**, int>)(lpVtbl[7]))((IGeocoordinateWithPositionData*)Unsafe.AsPointer(ref this), ppValue);
        }
    }
}
