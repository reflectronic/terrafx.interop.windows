// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CrossSlidingState
    {
        CrossSlidingState_Started = 0,
        CrossSlidingState_Dragging = 1,
        CrossSlidingState_Selecting = 2,
        CrossSlidingState_SelectSpeedBumping = 3,
        CrossSlidingState_SpeedBumping = 4,
        CrossSlidingState_Rearranging = 5,
        CrossSlidingState_Completed = 6,
    }
}
