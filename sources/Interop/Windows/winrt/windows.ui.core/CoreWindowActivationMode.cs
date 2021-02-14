// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CoreWindowActivationMode
    {
        CoreWindowActivationMode_None = 0,
        CoreWindowActivationMode_Deactivated = 1,
        CoreWindowActivationMode_ActivatedNotForeground = 2,
        CoreWindowActivationMode_ActivatedInForeground = 3,
    }
}
