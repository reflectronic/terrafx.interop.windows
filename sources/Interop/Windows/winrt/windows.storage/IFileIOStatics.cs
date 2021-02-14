// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("887411EB-7F54-4732-A5F0-5E43E3B8C2F5")]
    [NativeTypeName("struct IFileIOStatics : IInspectable")]
    public unsafe partial struct IFileIOStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFileIOStatics*, Guid*, void**, int>)(lpVtbl[0]))((IFileIOStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileIOStatics*, uint>)(lpVtbl[1]))((IFileIOStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileIOStatics*, uint>)(lpVtbl[2]))((IFileIOStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IFileIOStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IFileIOStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IntPtr*, int>)(lpVtbl[4]))((IFileIOStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IFileIOStatics*, TrustLevel*, int>)(lpVtbl[5]))((IFileIOStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<IntPtr>** textOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<IntPtr>** textOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, UnicodeEncoding, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, encoding, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IntPtr, IAsyncAction**, int>)(lpVtbl[8]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IntPtr, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[9]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, encoding, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendTextAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IntPtr, IAsyncAction**, int>)(lpVtbl[10]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendTextWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("HSTRING")] IntPtr contents, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** textOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IntPtr, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[11]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, contents, encoding, textOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, linesOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")] IAsyncOperation<IntPtr>** linesOperation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, UnicodeEncoding, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, encoding, linesOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[14]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IIterable<IntPtr>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[15]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, encoding, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendLinesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[16]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendLinesWithEncodingAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* lines, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IIterable<IntPtr>*, UnicodeEncoding, IAsyncAction**, int>)(lpVtbl[17]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, lines, encoding, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBufferAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[18]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBufferAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, IBuffer*, IAsyncAction**, int>)(lpVtbl[19]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, buffer, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBytesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("UINT32")] uint bufferLength, [NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IFileIOStatics*, IStorageFile*, uint, byte*, IAsyncAction**, int>)(lpVtbl[20]))((IFileIOStatics*)Unsafe.AsPointer(ref this), file, bufferLength, buffer, operation);
        }
    }
}
