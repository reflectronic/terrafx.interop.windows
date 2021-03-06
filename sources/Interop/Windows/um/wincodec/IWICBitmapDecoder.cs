// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
    [NativeTypeName("struct IWICBitmapDecoder : IUnknown")]
    public unsafe partial struct IWICBitmapDecoder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, uint>)(lpVtbl[1]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, uint>)(lpVtbl[2]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IStream*, uint*, int>)(lpVtbl[3]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, pdwCapability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IStream* pIStream, WICDecodeOptions cacheOptions)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IStream*, WICDecodeOptions, int>)(lpVtbl[4]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, cacheOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, Guid*, int>)(lpVtbl[5]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)(lpVtbl[6]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIDecoderInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IWICPalette*, int>)(lpVtbl[7]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreview(IWICBitmapSource** ppIBitmapSource)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IWICBitmapSource**, int>)(lpVtbl[9]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIBitmapSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)(lpVtbl[10]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, IWICBitmapSource**, int>)(lpVtbl[11]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, uint*, int>)(lpVtbl[12]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrame([NativeTypeName("UINT")] uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return ((delegate* unmanaged<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)(lpVtbl[13]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), index, ppIBitmapFrame);
        }
    }
}
