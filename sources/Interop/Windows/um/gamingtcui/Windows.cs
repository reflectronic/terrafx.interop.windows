// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gamingtcui.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowGameInviteUI([NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowPlayerPickerUI([NativeTypeName("HSTRING")] IntPtr promptDisplayText, [NativeTypeName("const HSTRING *")] IntPtr* xuids, [NativeTypeName("size_t")] nuint xuidsCount, [NativeTypeName("const HSTRING *")] IntPtr* preSelectedXuids, [NativeTypeName("size_t")] nuint preSelectedXuidsCount, [NativeTypeName("size_t")] nuint minSelectionCount, [NativeTypeName("size_t")] nuint maxSelectionCount, [NativeTypeName("PlayerPickerUICompletionRoutine")] delegate* unmanaged<int, void*, IntPtr*, nuint, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowProfileCardUI([NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowChangeFriendRelationshipUI([NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowTitleAchievementsUI([NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ProcessPendingGameUI([NativeTypeName("BOOL")] int waitForCompletion);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TryCancelPendingGameUI();

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CheckGamingPrivilegeWithUI([NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, [NativeTypeName("HSTRING")] IntPtr friendlyMessage, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CheckGamingPrivilegeSilently([NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, [NativeTypeName("BOOL *")] int* hasPrivilege);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowGameInviteUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowPlayerPickerUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("HSTRING")] IntPtr promptDisplayText, [NativeTypeName("const HSTRING *")] IntPtr* xuids, [NativeTypeName("size_t")] nuint xuidsCount, [NativeTypeName("const HSTRING *")] IntPtr* preSelectedXuids, [NativeTypeName("size_t")] nuint preSelectedXuidsCount, [NativeTypeName("size_t")] nuint minSelectionCount, [NativeTypeName("size_t")] nuint maxSelectionCount, [NativeTypeName("PlayerPickerUICompletionRoutine")] delegate* unmanaged<int, void*, IntPtr*, nuint, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowProfileCardUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowChangeFriendRelationshipUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("HSTRING")] IntPtr targetUserXuid, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowTitleAchievementsUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CheckGamingPrivilegeWithUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, [NativeTypeName("HSTRING")] IntPtr friendlyMessage, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CheckGamingPrivilegeSilentlyForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("UINT32")] uint privilegeId, [NativeTypeName("HSTRING")] IntPtr scope, [NativeTypeName("HSTRING")] IntPtr policy, [NativeTypeName("BOOL *")] int* hasPrivilege);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowGameInviteUIWithContext([NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("HSTRING")] IntPtr customActivationContext, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowGameInviteUIWithContextForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("HSTRING")] IntPtr serviceConfigurationId, [NativeTypeName("HSTRING")] IntPtr sessionTemplateName, [NativeTypeName("HSTRING")] IntPtr sessionId, [NativeTypeName("HSTRING")] IntPtr invitationDisplayText, [NativeTypeName("HSTRING")] IntPtr customActivationContext, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowGameInfoUI([NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowGameInfoUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("UINT32")] uint titleId, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowFindFriendsUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowFindFriendsUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowCustomizeUserProfileUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowCustomizeUserProfileUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowUserSettingsUI([NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);

        [DllImport("gamingtcui", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ShowUserSettingsUIForUser([NativeTypeName("IInspectable *")] IInspectable* user, [NativeTypeName("GameUICompletionRoutine")] delegate* unmanaged<int, void*, void> completionRoutine, [NativeTypeName("void *")] void* context);
    }
}
