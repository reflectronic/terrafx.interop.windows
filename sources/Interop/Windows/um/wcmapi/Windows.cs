// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wcmapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WcmQueryProperty([NativeTypeName("const GUID *")] Guid* pInterface, [NativeTypeName("LPCWSTR")] ushort* strProfileName, WCM_PROPERTY Property, [NativeTypeName("PVOID")] void* pReserved, [NativeTypeName("PDWORD")] uint* pdwDataSize, [NativeTypeName("PBYTE *")] byte** ppData);

        [DllImport("wcmapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WcmSetProperty([NativeTypeName("const GUID *")] Guid* pInterface, [NativeTypeName("LPCWSTR")] ushort* strProfileName, WCM_PROPERTY Property, [NativeTypeName("PVOID")] void* pReserved, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("const BYTE *")] byte* pbData);

        [DllImport("wcmapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WcmGetProfileList([NativeTypeName("PVOID")] void* pReserved, [NativeTypeName("WCM_PROFILE_INFO_LIST **")] WCM_PROFILE_INFO_LIST** ppProfileList);

        [DllImport("wcmapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WcmSetProfileList([NativeTypeName("WCM_PROFILE_INFO_LIST *")] WCM_PROFILE_INFO_LIST* pProfileList, [NativeTypeName("DWORD")] uint dwPosition, [NativeTypeName("BOOL")] int fIgnoreUnknownProfiles, [NativeTypeName("PVOID")] void* pReserved);

        [DllImport("wcmapi", ExactSpelling = true)]
        public static extern void WcmFreeMemory([NativeTypeName("PVOID")] void* pMemory);

        [NativeTypeName("#define WCM_API_VERSION_1_0 0x00000001")]
        public const int WCM_API_VERSION_1_0 = 0x00000001;

        [NativeTypeName("#define WCM_API_VERSION WCM_API_VERSION_1_0")]
        public const int WCM_API_VERSION = 0x00000001;

        [NativeTypeName("#define WCM_UNKNOWN_DATAPLAN_STATUS 0xFFFFFFFF")]
        public const uint WCM_UNKNOWN_DATAPLAN_STATUS = 0xFFFFFFFF;

        [NativeTypeName("#define WCM_MAX_PROFILE_NAME 256")]
        public const int WCM_MAX_PROFILE_NAME = 256;
    }
}
