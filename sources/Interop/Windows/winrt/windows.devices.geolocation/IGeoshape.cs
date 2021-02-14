// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C99CA2AF-C729-43C1-8FAB-D6DEC914DF7E")]
    [NativeTypeName("struct IGeoshape : IInspectable")]
    public unsafe partial struct IGeoshape
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeoshape*, Guid*, void**, int>)(lpVtbl[0]))((IGeoshape*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeoshape*, uint>)(lpVtbl[1]))((IGeoshape*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeoshape*, uint>)(lpVtbl[2]))((IGeoshape*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeoshape*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoshape*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeoshape*, IntPtr*, int>)(lpVtbl[4]))((IGeoshape*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeoshape*, TrustLevel*, int>)(lpVtbl[5]))((IGeoshape*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GeoshapeType([NativeTypeName("ABI::Windows::Devices::Geolocation::GeoshapeType *")] GeoshapeType* value)
        {
            return ((delegate* unmanaged<IGeoshape*, GeoshapeType*, int>)(lpVtbl[6]))((IGeoshape*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SpatialReferenceId([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGeoshape*, uint*, int>)(lpVtbl[7]))((IGeoshape*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem *")] AltitudeReferenceSystem* value)
        {
            return ((delegate* unmanaged<IGeoshape*, AltitudeReferenceSystem*, int>)(lpVtbl[8]))((IGeoshape*)Unsafe.AsPointer(ref this), value);
        }
    }
}
