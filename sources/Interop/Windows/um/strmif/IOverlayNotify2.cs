// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("680EFA10-D535-11D1-87C8-00A0C9223196")]
    [NativeTypeName("struct IOverlayNotify2 : IOverlayNotify")]
    public unsafe partial struct IOverlayNotify2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOverlayNotify2*, Guid*, void**, int>)(lpVtbl[0]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOverlayNotify2*, uint>)(lpVtbl[1]))((IOverlayNotify2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOverlayNotify2*, uint>)(lpVtbl[2]))((IOverlayNotify2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPaletteChange([NativeTypeName("DWORD")] uint dwColors, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalette)
        {
            return ((delegate* unmanaged<IOverlayNotify2*, uint, PALETTEENTRY*, int>)(lpVtbl[3]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), dwColors, pPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnClipChange([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestinationRect, [NativeTypeName("const RGNDATA *")] RGNDATA* pRgnData)
        {
            return ((delegate* unmanaged<IOverlayNotify2*, RECT*, RECT*, RGNDATA*, int>)(lpVtbl[4]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect, pRgnData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnColorKeyChange([NativeTypeName("const COLORKEY *")] COLORKEY* pColorKey)
        {
            return ((delegate* unmanaged<IOverlayNotify2*, COLORKEY*, int>)(lpVtbl[5]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), pColorKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPositionChange([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestinationRect)
        {
            return ((delegate* unmanaged<IOverlayNotify2*, RECT*, RECT*, int>)(lpVtbl[6]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), pSourceRect, pDestinationRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDisplayChange([NativeTypeName("HMONITOR")] IntPtr hMonitor)
        {
            return ((delegate* unmanaged<IOverlayNotify2*, IntPtr, int>)(lpVtbl[7]))((IOverlayNotify2*)Unsafe.AsPointer(ref this), hMonitor);
        }
    }
}
