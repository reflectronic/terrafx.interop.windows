// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CoreProcessEventsOption
    {
        CoreProcessEventsOption_ProcessOneAndAllPending = 0,
        CoreProcessEventsOption_ProcessOneIfPresent = 1,
        CoreProcessEventsOption_ProcessUntilQuit = 2,
        CoreProcessEventsOption_ProcessAllIfPresent = 3,
    }
}
