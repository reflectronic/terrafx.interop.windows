// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("34A05B2F-EE0D-41E5-8314-CF10C91BF0AF")]
    [NativeTypeName("struct ICoreImmersiveApplication3 : IInspectable")]
    public unsafe partial struct ICoreImmersiveApplication3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, Guid*, void**, int>)(lpVtbl[0]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, uint>)(lpVtbl[1]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, uint>)(lpVtbl[2]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, IntPtr*, int>)(lpVtbl[4]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, TrustLevel*, int>)(lpVtbl[5]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewViewWithViewSource([NativeTypeName("ABI::Windows::ApplicationModel::Core::IFrameworkViewSource *")] IFrameworkViewSource* viewSource, [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** view)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication3*, IFrameworkViewSource*, ICoreApplicationView**, int>)(lpVtbl[6]))((ICoreImmersiveApplication3*)Unsafe.AsPointer(ref this), viewSource, view);
        }
    }
}
