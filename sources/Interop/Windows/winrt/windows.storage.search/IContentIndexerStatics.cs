// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C488375-B37E-4C60-9BA8-B760FDA3E59D")]
    [NativeTypeName("struct IContentIndexerStatics : IInspectable")]
    public unsafe partial struct IContentIndexerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, uint>)(lpVtbl[1]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, uint>)(lpVtbl[2]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, IntPtr*, int>)(lpVtbl[4]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndexerWithName([NativeTypeName("HSTRING")] IntPtr indexName, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer** index)
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, IntPtr, IContentIndexer**, int>)(lpVtbl[6]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), indexName, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndexer([NativeTypeName("ABI::Windows::Storage::Search::IContentIndexer **")] IContentIndexer** index)
        {
            return ((delegate* unmanaged<IContentIndexerStatics*, IContentIndexer**, int>)(lpVtbl[7]))((IContentIndexerStatics*)Unsafe.AsPointer(ref this), index);
        }
    }
}
