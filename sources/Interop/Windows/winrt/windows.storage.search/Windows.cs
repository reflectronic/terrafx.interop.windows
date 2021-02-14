// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [39]")]
        public const string InterfaceName_Windows_Storage_Search_IContentIndexer = "Windows.Storage.Search.IContentIndexer";

        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Storage_Search_IContentIndexerQuery = "Windows.Storage.Search.IContentIndexerQuery";

        [NativeTypeName("const WCHAR [54]")]
        public const string InterfaceName_Windows_Storage_Search_IContentIndexerQueryOperations = "Windows.Storage.Search.IContentIndexerQueryOperations";

        [NativeTypeName("const WCHAR [46]")]
        public const string InterfaceName_Windows_Storage_Search_IContentIndexerStatics = "Windows.Storage.Search.IContentIndexerStatics";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Storage_Search_IIndexableContent = "Windows.Storage.Search.IIndexableContent";

        [NativeTypeName("const WCHAR [37]")]
        public const string InterfaceName_Windows_Storage_Search_IQueryOptions = "Windows.Storage.Search.IQueryOptions";

        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Storage_Search_IQueryOptionsFactory = "Windows.Storage.Search.IQueryOptionsFactory";

        [NativeTypeName("const WCHAR [55]")]
        public const string InterfaceName_Windows_Storage_Search_IQueryOptionsWithProviderFilter = "Windows.Storage.Search.IQueryOptionsWithProviderFilter";

        [NativeTypeName("const WCHAR [47]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageFileQueryResult = "Windows.Storage.Search.IStorageFileQueryResult";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageFileQueryResult2 = "Windows.Storage.Search.IStorageFileQueryResult2";

        [NativeTypeName("const WCHAR [53]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageFolderQueryOperations = "Windows.Storage.Search.IStorageFolderQueryOperations";

        [NativeTypeName("const WCHAR [49]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageFolderQueryResult = "Windows.Storage.Search.IStorageFolderQueryResult";

        [NativeTypeName("const WCHAR [47]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageItemQueryResult = "Windows.Storage.Search.IStorageItemQueryResult";

        [NativeTypeName("const WCHAR [66]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageLibraryChangeTrackerTriggerDetails = "Windows.Storage.Search.IStorageLibraryChangeTrackerTriggerDetails";

        [NativeTypeName("const WCHAR [67]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageLibraryContentChangedTriggerDetails = "Windows.Storage.Search.IStorageLibraryContentChangedTriggerDetails";

        [NativeTypeName("const WCHAR [47]")]
        public const string InterfaceName_Windows_Storage_Search_IStorageQueryResultBase = "Windows.Storage.Search.IStorageQueryResultBase";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Storage_Search_IValueAndLanguage = "Windows.Storage.Search.IValueAndLanguage";

        [NativeTypeName("const WCHAR [38]")]
        public const string RuntimeClass_Windows_Storage_Search_ContentIndexer = "Windows.Storage.Search.ContentIndexer";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_Storage_Search_ContentIndexerQuery = "Windows.Storage.Search.ContentIndexerQuery";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Storage_Search_IndexableContent = "Windows.Storage.Search.IndexableContent";

        [NativeTypeName("const WCHAR [36]")]
        public const string RuntimeClass_Windows_Storage_Search_QueryOptions = "Windows.Storage.Search.QueryOptions";

        [NativeTypeName("const WCHAR [39]")]
        public const string RuntimeClass_Windows_Storage_Search_SortEntryVector = "Windows.Storage.Search.SortEntryVector";

        [NativeTypeName("const WCHAR [46]")]
        public const string RuntimeClass_Windows_Storage_Search_StorageFileQueryResult = "Windows.Storage.Search.StorageFileQueryResult";

        [NativeTypeName("const WCHAR [48]")]
        public const string RuntimeClass_Windows_Storage_Search_StorageFolderQueryResult = "Windows.Storage.Search.StorageFolderQueryResult";

        [NativeTypeName("const WCHAR [46]")]
        public const string RuntimeClass_Windows_Storage_Search_StorageItemQueryResult = "Windows.Storage.Search.StorageItemQueryResult";

        [NativeTypeName("const WCHAR [65]")]
        public const string RuntimeClass_Windows_Storage_Search_StorageLibraryChangeTrackerTriggerDetails = "Windows.Storage.Search.StorageLibraryChangeTrackerTriggerDetails";

        [NativeTypeName("const WCHAR [66]")]
        public const string RuntimeClass_Windows_Storage_Search_StorageLibraryContentChangedTriggerDetails = "Windows.Storage.Search.StorageLibraryContentChangedTriggerDetails";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Storage_Search_ValueAndLanguage = "Windows.Storage.Search.ValueAndLanguage";

        public static readonly Guid IID_IContentIndexer = new Guid(0xB1767F8D, 0xF698, 0x4982, 0xB0, 0x5F, 0x3A, 0x6E, 0x8C, 0xAB, 0x01, 0xA2);

        public static readonly Guid IID_IContentIndexerQuery = new Guid(0x70E3B0F8, 0x4BFC, 0x428A, 0x88, 0x89, 0xCC, 0x51, 0xDA, 0x9A, 0x7B, 0x9D);

        public static readonly Guid IID_IContentIndexerQueryOperations = new Guid(0x28823E10, 0x4786, 0x42F1, 0x97, 0x30, 0x79, 0x2B, 0x35, 0x66, 0xB1, 0x50);

        public static readonly Guid IID_IContentIndexerStatics = new Guid(0x8C488375, 0xB37E, 0x4C60, 0x9B, 0xA8, 0xB7, 0x60, 0xFD, 0xA3, 0xE5, 0x9D);

        public static readonly Guid IID_IIndexableContent = new Guid(0xCCF1A05F, 0xD4B5, 0x483A, 0xB0, 0x6E, 0xE0, 0xDB, 0x1E, 0xC4, 0x20, 0xE4);

        public static readonly Guid IID_IQueryOptions = new Guid(0x1E5E46EE, 0x0F45, 0x4838, 0xA8, 0xE9, 0xD0, 0x47, 0x9D, 0x44, 0x6C, 0x30);

        public static readonly Guid IID_IQueryOptionsFactory = new Guid(0x032E1F8C, 0xA9C1, 0x4E71, 0x80, 0x11, 0x0D, 0xEE, 0x9D, 0x48, 0x11, 0xA3);

        public static readonly Guid IID_IQueryOptionsWithProviderFilter = new Guid(0x5B9D1026, 0x15C4, 0x44DD, 0xB8, 0x9A, 0x47, 0xA5, 0x9B, 0x7D, 0x7C, 0x4F);

        public static readonly Guid IID_IStorageFileQueryResult = new Guid(0x52FDA447, 0x2BAA, 0x412C, 0xB2, 0x9F, 0xD4, 0xB1, 0x77, 0x8E, 0xFA, 0x1E);

        public static readonly Guid IID_IStorageFileQueryResult2 = new Guid(0x4E5DB9DD, 0x7141, 0x46C4, 0x8B, 0xE3, 0xE9, 0xDC, 0x9E, 0x27, 0x27, 0x5C);

        public static readonly Guid IID_IStorageFolderQueryOperations = new Guid(0xCB43CCC9, 0x446B, 0x4A4F, 0xBE, 0x97, 0x75, 0x77, 0x71, 0xBE, 0x52, 0x03);

        public static readonly Guid IID_IStorageFolderQueryResult = new Guid(0x6654C911, 0x7D66, 0x46FA, 0xAE, 0xCF, 0xE4, 0xA4, 0xBA, 0xA9, 0x3A, 0xB8);

        public static readonly Guid IID_IStorageItemQueryResult = new Guid(0xE8948079, 0x9D58, 0x47B8, 0xB2, 0xB2, 0x41, 0xB0, 0x7F, 0x47, 0x95, 0xF9);

        public static readonly Guid IID_IStorageLibraryChangeTrackerTriggerDetails = new Guid(0x1DC7A369, 0xB7A3, 0x4DF2, 0x9D, 0x61, 0xEB, 0xA8, 0x5A, 0x03, 0x43, 0xD2);

        public static readonly Guid IID_IStorageLibraryContentChangedTriggerDetails = new Guid(0x2A371977, 0xABBF, 0x4E1D, 0x8A, 0xA5, 0x63, 0x85, 0xD8, 0x88, 0x47, 0x99);

        public static readonly Guid IID_IStorageQueryResultBase = new Guid(0xC297D70D, 0x7353, 0x47AB, 0xBA, 0x58, 0x8C, 0x61, 0x42, 0x5D, 0xC5, 0x4B);

        public static readonly Guid IID_IValueAndLanguage = new Guid(0xB9914881, 0xA1EE, 0x4BC4, 0x92, 0xA5, 0x46, 0x69, 0x68, 0xE3, 0x04, 0x36);
    }
}
