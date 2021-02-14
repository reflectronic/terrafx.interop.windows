// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VirtualKey
    {
        VirtualKey_None = 0,
        VirtualKey_LeftButton = 1,
        VirtualKey_RightButton = 2,
        VirtualKey_Cancel = 3,
        VirtualKey_MiddleButton = 4,
        VirtualKey_XButton1 = 5,
        VirtualKey_XButton2 = 6,
        VirtualKey_Back = 8,
        VirtualKey_Tab = 9,
        VirtualKey_Clear = 12,
        VirtualKey_Enter = 13,
        VirtualKey_Shift = 16,
        VirtualKey_Control = 17,
        VirtualKey_Menu = 18,
        VirtualKey_Pause = 19,
        VirtualKey_CapitalLock = 20,
        VirtualKey_Kana = 21,
        VirtualKey_Hangul = 21,
        VirtualKey_ImeOn = 22,
        VirtualKey_Junja = 23,
        VirtualKey_Final = 24,
        VirtualKey_Hanja = 25,
        VirtualKey_Kanji = 25,
        VirtualKey_ImeOff = 26,
        VirtualKey_Escape = 27,
        VirtualKey_Convert = 28,
        VirtualKey_NonConvert = 29,
        VirtualKey_Accept = 30,
        VirtualKey_ModeChange = 31,
        VirtualKey_Space = 32,
        VirtualKey_PageUp = 33,
        VirtualKey_PageDown = 34,
        VirtualKey_End = 35,
        VirtualKey_Home = 36,
        VirtualKey_Left = 37,
        VirtualKey_Up = 38,
        VirtualKey_Right = 39,
        VirtualKey_Down = 40,
        VirtualKey_Select = 41,
        VirtualKey_Print = 42,
        VirtualKey_Execute = 43,
        VirtualKey_Snapshot = 44,
        VirtualKey_Insert = 45,
        VirtualKey_Delete = 46,
        VirtualKey_Help = 47,
        VirtualKey_Number0 = 48,
        VirtualKey_Number1 = 49,
        VirtualKey_Number2 = 50,
        VirtualKey_Number3 = 51,
        VirtualKey_Number4 = 52,
        VirtualKey_Number5 = 53,
        VirtualKey_Number6 = 54,
        VirtualKey_Number7 = 55,
        VirtualKey_Number8 = 56,
        VirtualKey_Number9 = 57,
        VirtualKey_A = 65,
        VirtualKey_B = 66,
        VirtualKey_C = 67,
        VirtualKey_D = 68,
        VirtualKey_E = 69,
        VirtualKey_F = 70,
        VirtualKey_G = 71,
        VirtualKey_H = 72,
        VirtualKey_I = 73,
        VirtualKey_J = 74,
        VirtualKey_K = 75,
        VirtualKey_L = 76,
        VirtualKey_M = 77,
        VirtualKey_N = 78,
        VirtualKey_O = 79,
        VirtualKey_P = 80,
        VirtualKey_Q = 81,
        VirtualKey_R = 82,
        VirtualKey_S = 83,
        VirtualKey_T = 84,
        VirtualKey_U = 85,
        VirtualKey_V = 86,
        VirtualKey_W = 87,
        VirtualKey_X = 88,
        VirtualKey_Y = 89,
        VirtualKey_Z = 90,
        VirtualKey_LeftWindows = 91,
        VirtualKey_RightWindows = 92,
        VirtualKey_Application = 93,
        VirtualKey_Sleep = 95,
        VirtualKey_NumberPad0 = 96,
        VirtualKey_NumberPad1 = 97,
        VirtualKey_NumberPad2 = 98,
        VirtualKey_NumberPad3 = 99,
        VirtualKey_NumberPad4 = 100,
        VirtualKey_NumberPad5 = 101,
        VirtualKey_NumberPad6 = 102,
        VirtualKey_NumberPad7 = 103,
        VirtualKey_NumberPad8 = 104,
        VirtualKey_NumberPad9 = 105,
        VirtualKey_Multiply = 106,
        VirtualKey_Add = 107,
        VirtualKey_Separator = 108,
        VirtualKey_Subtract = 109,
        VirtualKey_Decimal = 110,
        VirtualKey_Divide = 111,
        VirtualKey_F1 = 112,
        VirtualKey_F2 = 113,
        VirtualKey_F3 = 114,
        VirtualKey_F4 = 115,
        VirtualKey_F5 = 116,
        VirtualKey_F6 = 117,
        VirtualKey_F7 = 118,
        VirtualKey_F8 = 119,
        VirtualKey_F9 = 120,
        VirtualKey_F10 = 121,
        VirtualKey_F11 = 122,
        VirtualKey_F12 = 123,
        VirtualKey_F13 = 124,
        VirtualKey_F14 = 125,
        VirtualKey_F15 = 126,
        VirtualKey_F16 = 127,
        VirtualKey_F17 = 128,
        VirtualKey_F18 = 129,
        VirtualKey_F19 = 130,
        VirtualKey_F20 = 131,
        VirtualKey_F21 = 132,
        VirtualKey_F22 = 133,
        VirtualKey_F23 = 134,
        VirtualKey_F24 = 135,
        VirtualKey_NavigationView = 136,
        VirtualKey_NavigationMenu = 137,
        VirtualKey_NavigationUp = 138,
        VirtualKey_NavigationDown = 139,
        VirtualKey_NavigationLeft = 140,
        VirtualKey_NavigationRight = 141,
        VirtualKey_NavigationAccept = 142,
        VirtualKey_NavigationCancel = 143,
        VirtualKey_NumberKeyLock = 144,
        VirtualKey_Scroll = 145,
        VirtualKey_LeftShift = 160,
        VirtualKey_RightShift = 161,
        VirtualKey_LeftControl = 162,
        VirtualKey_RightControl = 163,
        VirtualKey_LeftMenu = 164,
        VirtualKey_RightMenu = 165,
        VirtualKey_GoBack = 166,
        VirtualKey_GoForward = 167,
        VirtualKey_Refresh = 168,
        VirtualKey_Stop = 169,
        VirtualKey_Search = 170,
        VirtualKey_Favorites = 171,
        VirtualKey_GoHome = 172,
        VirtualKey_GamepadA = 195,
        VirtualKey_GamepadB = 196,
        VirtualKey_GamepadX = 197,
        VirtualKey_GamepadY = 198,
        VirtualKey_GamepadRightShoulder = 199,
        VirtualKey_GamepadLeftShoulder = 200,
        VirtualKey_GamepadLeftTrigger = 201,
        VirtualKey_GamepadRightTrigger = 202,
        VirtualKey_GamepadDPadUp = 203,
        VirtualKey_GamepadDPadDown = 204,
        VirtualKey_GamepadDPadLeft = 205,
        VirtualKey_GamepadDPadRight = 206,
        VirtualKey_GamepadMenu = 207,
        VirtualKey_GamepadView = 208,
        VirtualKey_GamepadLeftThumbstickButton = 209,
        VirtualKey_GamepadRightThumbstickButton = 210,
        VirtualKey_GamepadLeftThumbstickUp = 211,
        VirtualKey_GamepadLeftThumbstickDown = 212,
        VirtualKey_GamepadLeftThumbstickRight = 213,
        VirtualKey_GamepadLeftThumbstickLeft = 214,
        VirtualKey_GamepadRightThumbstickUp = 215,
        VirtualKey_GamepadRightThumbstickDown = 216,
        VirtualKey_GamepadRightThumbstickRight = 217,
        VirtualKey_GamepadRightThumbstickLeft = 218,
    }
}
