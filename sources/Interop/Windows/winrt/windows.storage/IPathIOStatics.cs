// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0F2F3758-8EC7-4381-922B-8F6C07D288F3")]
    [NativeTypeName("struct IPathIOStatics : IInspectable")]
    public unsafe partial struct IPathIOStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPathIOStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPathIOStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPathIOStatics*, uint>)(lpVtbl[1]))((IPathIOStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPathIOStatics*, uint>)(lpVtbl[2]))((IPathIOStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPathIOStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPathIOStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr*, int>)(lpVtbl[4]))((IPathIOStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPathIOStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPathIOStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadTextAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<IntPtr>** textOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadTextWithEncodingAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<IntPtr>** textOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, UnicodeEncoding, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, encoding, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteTextAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IntPtr, IAsyncAction**, int>)(lpVtbl[8]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteTextWithEncodingAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IntPtr, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[9]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, encoding, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendTextAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IntPtr, IAsyncAction**, int>)(lpVtbl[10]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendTextWithEncodingAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IntPtr, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[11]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, contents, encoding, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadLinesAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, linesOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadLinesWithEncodingAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, UnicodeEncoding, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, encoding, linesOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteLinesAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[14]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteLinesWithEncodingAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IIterable<IntPtr>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[15]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, encoding, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendLinesAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[16]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendLinesWithEncodingAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IIterable<IntPtr>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[17]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, lines, encoding, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBufferAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[18]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBufferAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, IBuffer*, IAsyncAction**, int>)(lpVtbl[19]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, buffer, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBytesAsync([NativeTypeName("HSTRING")] IntPtr absolutePath, [NativeTypeName("UINT32")] uint bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IPathIOStatics*, IntPtr, uint, byte*, IAsyncAction**, int>)(lpVtbl[20]))((IPathIOStatics*)Unsafe.AsPointer(ref this), absolutePath, bufferLength, buffer, operation);
        }
    }
}
