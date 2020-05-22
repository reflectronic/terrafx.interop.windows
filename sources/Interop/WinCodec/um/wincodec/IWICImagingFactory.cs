// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC5EC8A9-C395-4314-9C77-54D7A935FF70")]
    public unsafe partial struct IWICImagingFactory
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICImagingFactory* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICImagingFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICImagingFactory* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromFilename(IWICImagingFactory* pThis, [NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromStream(IWICImagingFactory* pThis, [NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoderFromFileHandle(IWICImagingFactory* pThis, [NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComponentInfo(IWICImagingFactory* pThis, [NativeTypeName("const IID &")] Guid* clsidComponent, [NativeTypeName("IWICComponentInfo **")] IWICComponentInfo** ppIInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDecoder(IWICImagingFactory* pThis, [NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEncoder(IWICImagingFactory* pThis, [NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIEncoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePalette(IWICImagingFactory* pThis, [NativeTypeName("IWICPalette **")] IWICPalette** ppIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFormatConverter(IWICImagingFactory* pThis, [NativeTypeName("IWICFormatConverter **")] IWICFormatConverter** ppIFormatConverter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapScaler(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapScaler **")] IWICBitmapScaler** ppIBitmapScaler);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapClipper(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapClipper **")] IWICBitmapClipper** ppIBitmapClipper);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFlipRotator(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapFlipRotator **")] IWICBitmapFlipRotator** ppIBitmapFlipRotator);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStream(IWICImagingFactory* pThis, [NativeTypeName("IWICStream **")] IWICStream** ppIWICStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorContext(IWICImagingFactory* pThis, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIWICColorContext);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateColorTransformer(IWICImagingFactory* pThis, [NativeTypeName("IWICColorTransform **")] IWICColorTransform** ppIWICColorTransform);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmap(IWICImagingFactory* pThis, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromSource(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromSourceRect(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromMemory(IWICImagingFactory* pThis, [NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromHBITMAP(IWICImagingFactory* pThis, [NativeTypeName("HBITMAP")] IntPtr hBitmap, [NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapFromHICON(IWICImagingFactory* pThis, [NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateComponentEnumerator(IWICImagingFactory* pThis, [NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFastMetadataEncoderFromDecoder(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapDecoder *")] IWICBitmapDecoder* pIDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFastMetadataEncoderFromFrameDecode(IWICImagingFactory* pThis, [NativeTypeName("IWICBitmapFrameDecode *")] IWICBitmapFrameDecode* pIFrameDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriter(IWICImagingFactory* pThis, [NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateQueryWriterFromReader(IWICImagingFactory* pThis, [NativeTypeName("IWICMetadataQueryReader *")] IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICImagingFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFilename>(lpVtbl->CreateDecoderFromFilename)((IWICImagingFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromStream>(lpVtbl->CreateDecoderFromStream)((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] nuint hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDecoderFromFileHandle>(lpVtbl->CreateDecoderFromFileHandle)((IWICImagingFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, [NativeTypeName("IWICComponentInfo **")] IWICComponentInfo** ppIInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateComponentInfo>(lpVtbl->CreateComponentInfo)((IWICImagingFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIDecoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDecoder>(lpVtbl->CreateDecoder)((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIEncoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEncoder>(lpVtbl->CreateEncoder)((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePalette([NativeTypeName("IWICPalette **")] IWICPalette** ppIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreatePalette>(lpVtbl->CreatePalette)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter([NativeTypeName("IWICFormatConverter **")] IWICFormatConverter** ppIFormatConverter)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFormatConverter>(lpVtbl->CreateFormatConverter)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler([NativeTypeName("IWICBitmapScaler **")] IWICBitmapScaler** ppIBitmapScaler)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapScaler>(lpVtbl->CreateBitmapScaler)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper([NativeTypeName("IWICBitmapClipper **")] IWICBitmapClipper** ppIBitmapClipper)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapClipper>(lpVtbl->CreateBitmapClipper)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator([NativeTypeName("IWICBitmapFlipRotator **")] IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFlipRotator>(lpVtbl->CreateBitmapFlipRotator)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("IWICStream **")] IWICStream** ppIWICStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIWICColorContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorContext>(lpVtbl->CreateColorContext)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer([NativeTypeName("IWICColorTransform **")] IWICColorTransform** ppIWICColorTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateColorTransformer>(lpVtbl->CreateColorTransformer)((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmap>(lpVtbl->CreateBitmap)((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSource>(lpVtbl->CreateBitmapFromSource)((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pIBitmapSource, [NativeTypeName("UINT")] uint x, [NativeTypeName("UINT")] uint y, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromSourceRect>(lpVtbl->CreateBitmapFromSourceRect)((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory([NativeTypeName("UINT")] uint uiWidth, [NativeTypeName("UINT")] uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromMemory>(lpVtbl->CreateBitmapFromMemory)((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] IntPtr hBitmap, [NativeTypeName("HPALETTE")] IntPtr hPalette, WICBitmapAlphaChannelOption options, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHBITMAP>(lpVtbl->CreateBitmapFromHBITMAP)((IWICImagingFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] IntPtr hIcon, [NativeTypeName("IWICBitmap **")] IWICBitmap** ppIBitmap)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapFromHICON>(lpVtbl->CreateBitmapFromHICON)((IWICImagingFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, [NativeTypeName("IEnumUnknown **")] IEnumUnknown** ppIEnumUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateComponentEnumerator>(lpVtbl->CreateComponentEnumerator)((IWICImagingFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder([NativeTypeName("IWICBitmapDecoder *")] IWICBitmapDecoder* pIDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromDecoder>(lpVtbl->CreateFastMetadataEncoderFromDecoder)((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode([NativeTypeName("IWICBitmapFrameDecode *")] IWICBitmapFrameDecode* pIFrameDecoder, [NativeTypeName("IWICFastMetadataEncoder **")] IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFastMetadataEncoderFromFrameDecode>(lpVtbl->CreateFastMetadataEncoderFromFrameDecode)((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriter>(lpVtbl->CreateQueryWriter)((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader([NativeTypeName("IWICMetadataQueryReader *")] IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("IWICMetadataQueryWriter **")] IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateQueryWriterFromReader>(lpVtbl->CreateQueryWriterFromReader)((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public IntPtr CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public IntPtr CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public IntPtr CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public IntPtr CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public IntPtr CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public IntPtr CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public IntPtr CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public IntPtr CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public IntPtr CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public IntPtr CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public IntPtr CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public IntPtr CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public IntPtr CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public IntPtr CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public IntPtr CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public IntPtr CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public IntPtr CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public IntPtr CreateQueryWriterFromReader;
        }
    }
}
