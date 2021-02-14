// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PSS_QUERY_INFORMATION_CLASS
    {
        PSS_QUERY_PROCESS_INFORMATION = 0,
        PSS_QUERY_VA_CLONE_INFORMATION = 1,
        PSS_QUERY_AUXILIARY_PAGES_INFORMATION = 2,
        PSS_QUERY_VA_SPACE_INFORMATION = 3,
        PSS_QUERY_HANDLE_INFORMATION = 4,
        PSS_QUERY_THREAD_INFORMATION = 5,
        PSS_QUERY_HANDLE_TRACE_INFORMATION = 6,
        PSS_QUERY_PERFORMANCE_COUNTERS = 7,
    }
}
