// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFCBBE9B-582B-4133-9648-E44CA46EE491")]
    [NativeTypeName("struct IStorageFilePropertiesWithAvailability : IInspectable")]
    public unsafe partial struct IStorageFilePropertiesWithAvailability
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, uint>)(lpVtbl[1]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, uint>)(lpVtbl[2]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, IntPtr*, int>)(lpVtbl[4]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsAvailable([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IStorageFilePropertiesWithAvailability*, byte*, int>)(lpVtbl[6]))((IStorageFilePropertiesWithAvailability*)Unsafe.AsPointer(ref this), value);
        }
    }
}