// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmStartSession([NativeTypeName("DWORD *")] uint* pSessionHandle, [NativeTypeName("DWORD")] uint dwSessionFlags, [NativeTypeName("WCHAR []")] ushort* strSessionKey);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmJoinSession([NativeTypeName("DWORD *")] uint* pSessionHandle, [NativeTypeName("const WCHAR []")] ushort* strSessionKey);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmEndSession([NativeTypeName("DWORD")] uint dwSessionHandle);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmRegisterResources([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("UINT")] uint nFiles, [NativeTypeName("LPCWSTR []")] ushort** rgsFileNames, [NativeTypeName("UINT")] uint nApplications, [NativeTypeName("RM_UNIQUE_PROCESS []")] RM_UNIQUE_PROCESS* rgApplications, [NativeTypeName("UINT")] uint nServices, [NativeTypeName("LPCWSTR []")] ushort** rgsServiceNames);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmGetList([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("UINT *")] uint* pnProcInfoNeeded, [NativeTypeName("UINT *")] uint* pnProcInfo, [NativeTypeName("RM_PROCESS_INFO []")] RM_PROCESS_INFO* rgAffectedApps, [NativeTypeName("LPDWORD")] uint* lpdwRebootReasons);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmShutdown([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("ULONG")] uint lActionFlags, [NativeTypeName("RM_WRITE_STATUS_CALLBACK")] delegate* unmanaged<uint, void> fnStatus);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmRestart([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("DWORD")] uint dwRestartFlags, [NativeTypeName("RM_WRITE_STATUS_CALLBACK")] delegate* unmanaged<uint, void> fnStatus);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmCancelCurrentTask([NativeTypeName("DWORD")] uint dwSessionHandle);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmAddFilter([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("LPCWSTR")] ushort* strModuleName, [NativeTypeName("RM_UNIQUE_PROCESS *")] RM_UNIQUE_PROCESS* pProcess, [NativeTypeName("LPCWSTR")] ushort* strServiceShortName, RM_FILTER_ACTION FilterAction);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmRemoveFilter([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("LPCWSTR")] ushort* strModuleName, [NativeTypeName("RM_UNIQUE_PROCESS *")] RM_UNIQUE_PROCESS* pProcess, [NativeTypeName("LPCWSTR")] ushort* strServiceShortName);

        [DllImport("rstrtmgr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RmGetFilterList([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("PBYTE")] byte* pbFilterBuf, [NativeTypeName("DWORD")] uint cbFilterBuf, [NativeTypeName("LPDWORD")] uint* cbFilterBufNeeded);

        [NativeTypeName("#define RM_SESSION_KEY_LEN sizeof(GUID)")]
        public const uint RM_SESSION_KEY_LEN = unchecked(16);

        [NativeTypeName("#define CCH_RM_SESSION_KEY RM_SESSION_KEY_LEN*2")]
        public const uint CCH_RM_SESSION_KEY = unchecked(16 * 2);

        [NativeTypeName("#define CCH_RM_MAX_APP_NAME 255")]
        public const int CCH_RM_MAX_APP_NAME = 255;

        [NativeTypeName("#define CCH_RM_MAX_SVC_NAME 63")]
        public const int CCH_RM_MAX_SVC_NAME = 63;

        [NativeTypeName("#define RM_INVALID_TS_SESSION -1")]
        public const int RM_INVALID_TS_SESSION = -1;

        [NativeTypeName("#define RM_INVALID_PROCESS -1")]
        public const int RM_INVALID_PROCESS = -1;
    }
}
