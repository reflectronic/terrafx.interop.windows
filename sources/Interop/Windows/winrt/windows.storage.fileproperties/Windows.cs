// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IBasicProperties = "Windows.Storage.FileProperties.IBasicProperties";

        [NativeTypeName("const WCHAR [51]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IDocumentProperties = "Windows.Storage.FileProperties.IDocumentProperties";

        [NativeTypeName("const WCHAR [52]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IGeotagHelperStatics = "Windows.Storage.FileProperties.IGeotagHelperStatics";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IImageProperties = "Windows.Storage.FileProperties.IImageProperties";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IMusicProperties = "Windows.Storage.FileProperties.IMusicProperties";

        [NativeTypeName("const WCHAR [61]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IStorageItemContentProperties = "Windows.Storage.FileProperties.IStorageItemContentProperties";

        [NativeTypeName("const WCHAR [59]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IStorageItemExtraProperties = "Windows.Storage.FileProperties.IStorageItemExtraProperties";

        [NativeTypeName("const WCHAR [52]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IThumbnailProperties = "Windows.Storage.FileProperties.IThumbnailProperties";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_Storage_FileProperties_IVideoProperties = "Windows.Storage.FileProperties.IVideoProperties";

        [NativeTypeName("const WCHAR [47]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_BasicProperties = "Windows.Storage.FileProperties.BasicProperties";

        [NativeTypeName("const WCHAR [50]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_DocumentProperties = "Windows.Storage.FileProperties.DocumentProperties";

        [NativeTypeName("const WCHAR [44]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_GeotagHelper = "Windows.Storage.FileProperties.GeotagHelper";

        [NativeTypeName("const WCHAR [47]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_ImageProperties = "Windows.Storage.FileProperties.ImageProperties";

        [NativeTypeName("const WCHAR [47]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_MusicProperties = "Windows.Storage.FileProperties.MusicProperties";

        [NativeTypeName("const WCHAR [60]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_StorageItemContentProperties = "Windows.Storage.FileProperties.StorageItemContentProperties";

        [NativeTypeName("const WCHAR [52]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_StorageItemThumbnail = "Windows.Storage.FileProperties.StorageItemThumbnail";

        [NativeTypeName("const WCHAR [47]")]
        public const string RuntimeClass_Windows_Storage_FileProperties_VideoProperties = "Windows.Storage.FileProperties.VideoProperties";

        public static readonly Guid IID_IBasicProperties = new Guid(0xD05D55DB, 0x785E, 0x4A66, 0xBE, 0x02, 0x9B, 0xEE, 0xC5, 0x8A, 0xEA, 0x81);

        public static readonly Guid IID_IDocumentProperties = new Guid(0x7EAB19BC, 0x1821, 0x4923, 0xB4, 0xA9, 0x0A, 0xEA, 0x40, 0x4D, 0x00, 0x70);

        public static readonly Guid IID_IGeotagHelperStatics = new Guid(0x41493244, 0x2524, 0x4655, 0x86, 0xA6, 0xED, 0x16, 0xF5, 0xFC, 0x71, 0x6B);

        public static readonly Guid IID_IImageProperties = new Guid(0x523C9424, 0xFCFF, 0x4275, 0xAF, 0xEE, 0xEC, 0xDB, 0x9A, 0xB4, 0x79, 0x73);

        public static readonly Guid IID_IMusicProperties = new Guid(0xBC8AAB62, 0x66EC, 0x419A, 0xBC, 0x5D, 0xCA, 0x65, 0xA4, 0xCB, 0x46, 0xDA);

        public static readonly Guid IID_IStorageItemContentProperties = new Guid(0x05294BAD, 0xBC38, 0x48BF, 0x85, 0xD7, 0x77, 0x0E, 0x0E, 0x2A, 0xE0, 0xBA);

        public static readonly Guid IID_IStorageItemExtraProperties = new Guid(0xC54361B2, 0x54CD, 0x432B, 0xBD, 0xBC, 0x4B, 0x19, 0xC4, 0xB4, 0x70, 0xD7);

        public static readonly Guid IID_IThumbnailProperties = new Guid(0x693DD42F, 0xDBE7, 0x49B5, 0xB3, 0xB3, 0x28, 0x93, 0xAC, 0x5D, 0x34, 0x23);

        public static readonly Guid IID_IVideoProperties = new Guid(0x719AE507, 0x68DE, 0x4DB8, 0x97, 0xDE, 0x49, 0x99, 0x8C, 0x05, 0x9F, 0x2F);
    }
}
