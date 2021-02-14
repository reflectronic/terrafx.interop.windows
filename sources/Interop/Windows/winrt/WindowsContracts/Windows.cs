// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/WindowsContracts.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_CALLS_CALLSPHONECONTRACT_VERSION 0x50000")]
        public const int WINDOWS_APPLICATIONMODEL_CALLS_CALLSPHONECONTRACT_VERSION = 0x50000;

        [NativeTypeName("#define WINDOWS_FOUNDATION_FOUNDATIONCONTRACT_VERSION 0x40000")]
        public const int WINDOWS_FOUNDATION_FOUNDATIONCONTRACT_VERSION = 0x40000;

        [NativeTypeName("#define WINDOWS_FOUNDATION_UNIVERSALAPICONTRACT_VERSION 0xa0000")]
        public const int WINDOWS_FOUNDATION_UNIVERSALAPICONTRACT_VERSION = 0xa0000;

        [NativeTypeName("#define WINDOWS_NETWORKING_SOCKETS_CONTROLCHANNELTRIGGERCONTRACT_VERSION 0x30000")]
        public const int WINDOWS_NETWORKING_SOCKETS_CONTROLCHANNELTRIGGERCONTRACT_VERSION = 0x30000;

        [NativeTypeName("#define WINDOWS_PHONE_PHONECONTRACT_VERSION 0x10000")]
        public const int WINDOWS_PHONE_PHONECONTRACT_VERSION = 0x10000;

        [NativeTypeName("#define WINDOWS_PHONE_PHONEINTERNALCONTRACT_VERSION 0x10000")]
        public const int WINDOWS_PHONE_PHONEINTERNALCONTRACT_VERSION = 0x10000;

        [NativeTypeName("#define WINDOWS_UI_WEBUI_CORE_WEBUICOMMANDBARCONTRACT_VERSION 0x10000")]
        public const int WINDOWS_UI_WEBUI_CORE_WEBUICOMMANDBARCONTRACT_VERSION = 0x10000;
    }
}
