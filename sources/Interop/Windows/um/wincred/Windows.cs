// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredWriteW([NativeTypeName("PCREDENTIALW")] CREDENTIALW* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredWriteA([NativeTypeName("PCREDENTIALA")] CREDENTIALA* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredReadW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALW *")] CREDENTIALW** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredReadA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALA *")] CREDENTIALA** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredEnumerateW([NativeTypeName("LPCWSTR")] ushort* Filter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALW **")] CREDENTIALW*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredEnumerateA([NativeTypeName("LPCSTR")] sbyte* Filter, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALA **")] CREDENTIALA*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredWriteDomainCredentialsW([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW")] CREDENTIAL_TARGET_INFORMATIONW* TargetInfo, [NativeTypeName("PCREDENTIALW")] CREDENTIALW* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredWriteDomainCredentialsA([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA")] CREDENTIAL_TARGET_INFORMATIONA* TargetInfo, [NativeTypeName("PCREDENTIALA")] CREDENTIALA* Credential, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredReadDomainCredentialsW([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW")] CREDENTIAL_TARGET_INFORMATIONW* TargetInfo, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALW **")] CREDENTIALW*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredReadDomainCredentialsA([NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA")] CREDENTIAL_TARGET_INFORMATIONA* TargetInfo, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD *")] uint* Count, [NativeTypeName("PCREDENTIALA **")] CREDENTIALA*** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredDeleteW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredDeleteA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredRenameW([NativeTypeName("LPCWSTR")] ushort* OldTargetName, [NativeTypeName("LPCWSTR")] ushort* NewTargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredRenameA([NativeTypeName("LPCSTR")] sbyte* OldTargetName, [NativeTypeName("LPCSTR")] sbyte* NewTargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredGetTargetInfoW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONW *")] CREDENTIAL_TARGET_INFORMATIONW** TargetInfo);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredGetTargetInfoA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIAL_TARGET_INFORMATIONA *")] CREDENTIAL_TARGET_INFORMATIONA** TargetInfo);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredMarshalCredentialW(CRED_MARSHAL_TYPE CredType, [NativeTypeName("PVOID")] void* Credential, [NativeTypeName("LPWSTR *")] ushort** MarshaledCredential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredMarshalCredentialA(CRED_MARSHAL_TYPE CredType, [NativeTypeName("PVOID")] void* Credential, [NativeTypeName("LPSTR *")] sbyte** MarshaledCredential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnmarshalCredentialW([NativeTypeName("LPCWSTR")] ushort* MarshaledCredential, [NativeTypeName("PCRED_MARSHAL_TYPE")] CRED_MARSHAL_TYPE* CredType, [NativeTypeName("PVOID *")] void** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnmarshalCredentialA([NativeTypeName("LPCSTR")] sbyte* MarshaledCredential, [NativeTypeName("PCRED_MARSHAL_TYPE")] CRED_MARSHAL_TYPE* CredType, [NativeTypeName("PVOID *")] void** Credential);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredIsMarshaledCredentialW([NativeTypeName("LPCWSTR")] ushort* MarshaledCredential);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredIsMarshaledCredentialA([NativeTypeName("LPCSTR")] sbyte* MarshaledCredential);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnPackAuthenticationBufferW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("LPWSTR")] ushort* pszUserName, [NativeTypeName("DWORD *")] uint* pcchMaxUserName, [NativeTypeName("LPWSTR")] ushort* pszDomainName, [NativeTypeName("DWORD *")] uint* pcchMaxDomainName, [NativeTypeName("LPWSTR")] ushort* pszPassword, [NativeTypeName("DWORD *")] uint* pcchMaxPassword);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnPackAuthenticationBufferA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("LPSTR")] sbyte* pszUserName, [NativeTypeName("DWORD *")] uint* pcchlMaxUserName, [NativeTypeName("LPSTR")] sbyte* pszDomainName, [NativeTypeName("DWORD *")] uint* pcchMaxDomainName, [NativeTypeName("LPSTR")] sbyte* pszPassword, [NativeTypeName("DWORD *")] uint* pcchMaxPassword);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredPackAuthenticationBufferW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszUserName, [NativeTypeName("LPWSTR")] ushort* pszPassword, [NativeTypeName("PBYTE")] byte* pPackedCredentials, [NativeTypeName("DWORD *")] uint* pcbPackedCredentials);

        [DllImport("credui", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredPackAuthenticationBufferA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszUserName, [NativeTypeName("LPSTR")] sbyte* pszPassword, [NativeTypeName("PBYTE")] byte* pPackedCredentials, [NativeTypeName("DWORD *")] uint* pcbPackedCredentials);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredProtectW([NativeTypeName("BOOL")] int fAsSelf, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredProtectEx([NativeTypeName("ULONG")] uint Flags, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredProtectA([NativeTypeName("BOOL")] int fAsSelf, [NativeTypeName("LPSTR")] sbyte* pszCredentials, [NativeTypeName("DWORD")] uint cchCredentials, [NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars, CRED_PROTECTION_TYPE* ProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnprotectW([NativeTypeName("BOOL")] int fAsSelf, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnprotectEx([NativeTypeName("ULONG")] uint Flags, [NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPWSTR")] ushort* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredUnprotectA([NativeTypeName("BOOL")] int fAsSelf, [NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, [NativeTypeName("DWORD")] uint cchProtectedCredentials, [NativeTypeName("LPSTR")] sbyte* pszCredentials, [NativeTypeName("DWORD *")] uint* pcchMaxChars);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredIsProtectedW([NativeTypeName("LPWSTR")] ushort* pszProtectedCredentials, CRED_PROTECTION_TYPE* pProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredIsProtectedA([NativeTypeName("LPSTR")] sbyte* pszProtectedCredentials, CRED_PROTECTION_TYPE* pProtectionType);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredFindBestCredentialW([NativeTypeName("LPCWSTR")] ushort* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALW *")] CREDENTIALW** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredFindBestCredentialA([NativeTypeName("LPCSTR")] sbyte* TargetName, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCREDENTIALA *")] CREDENTIALA** Credential);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CredGetSessionTypes([NativeTypeName("DWORD")] uint MaximumPersistCount, [NativeTypeName("LPDWORD")] uint* MaximumPersist);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern void CredFree([NativeTypeName("PVOID")] void* Buffer);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForCredentialsW([NativeTypeName("PCREDUI_INFOW")] CREDUI_INFOW* pUiInfo, [NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PWSTR")] ushort* pszUserName, [NativeTypeName("ULONG")] uint ulUserNameBufferSize, [NativeTypeName("PWSTR")] ushort* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("BOOL *")] int* save, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForCredentialsA([NativeTypeName("PCREDUI_INFOA")] CREDUI_INFOA* pUiInfo, [NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PSTR")] sbyte* pszUserName, [NativeTypeName("ULONG")] uint ulUserNameBufferSize, [NativeTypeName("PSTR")] sbyte* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("BOOL *")] int* save, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForWindowsCredentialsW([NativeTypeName("PCREDUI_INFOW")] CREDUI_INFOW* pUiInfo, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("ULONG *")] uint* pulAuthPackage, [NativeTypeName("LPCVOID")] void* pvInAuthBuffer, [NativeTypeName("ULONG")] uint ulInAuthBufferSize, [NativeTypeName("LPVOID *")] void** ppvOutAuthBuffer, [NativeTypeName("ULONG *")] uint* pulOutAuthBufferSize, [NativeTypeName("BOOL *")] int* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIPromptForWindowsCredentialsA([NativeTypeName("PCREDUI_INFOA")] CREDUI_INFOA* pUiInfo, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("ULONG *")] uint* pulAuthPackage, [NativeTypeName("LPCVOID")] void* pvInAuthBuffer, [NativeTypeName("ULONG")] uint ulInAuthBufferSize, [NativeTypeName("LPVOID *")] void** ppvOutAuthBuffer, [NativeTypeName("ULONG *")] uint* pulOutAuthBufferSize, [NativeTypeName("BOOL *")] int* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIParseUserNameW([NativeTypeName("PCWSTR")] ushort* UserName, [NativeTypeName("WCHAR *")] ushort* user, [NativeTypeName("ULONG")] uint userBufferSize, [NativeTypeName("WCHAR *")] ushort* domain, [NativeTypeName("ULONG")] uint domainBufferSize);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIParseUserNameA([NativeTypeName("PCSTR")] sbyte* userName, [NativeTypeName("CHAR *")] sbyte* user, [NativeTypeName("ULONG")] uint userBufferSize, [NativeTypeName("CHAR *")] sbyte* domain, [NativeTypeName("ULONG")] uint domainBufferSize);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUICmdLinePromptForCredentialsW([NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PWSTR")] ushort* UserName, [NativeTypeName("ULONG")] uint ulUserBufferSize, [NativeTypeName("PWSTR")] ushort* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("PBOOL")] int* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUICmdLinePromptForCredentialsA([NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("PCtxtHandle")] SecHandle* pContext, [NativeTypeName("DWORD")] uint dwAuthError, [NativeTypeName("PSTR")] sbyte* UserName, [NativeTypeName("ULONG")] uint ulUserBufferSize, [NativeTypeName("PSTR")] sbyte* pszPassword, [NativeTypeName("ULONG")] uint ulPasswordBufferSize, [NativeTypeName("PBOOL")] int* pfSave, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIConfirmCredentialsW([NativeTypeName("PCWSTR")] ushort* pszTargetName, [NativeTypeName("BOOL")] int bConfirm);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIConfirmCredentialsA([NativeTypeName("PCSTR")] sbyte* pszTargetName, [NativeTypeName("BOOL")] int bConfirm);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIStoreSSOCredW([NativeTypeName("PCWSTR")] ushort* pszRealm, [NativeTypeName("PCWSTR")] ushort* pszUsername, [NativeTypeName("PCWSTR")] ushort* pszPassword, [NativeTypeName("BOOL")] int bPersist);

        [DllImport("credui", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CredUIReadSSOCredW([NativeTypeName("PCWSTR")] ushort* pszRealm, [NativeTypeName("PWSTR *")] ushort** ppszUsername);

        [NativeTypeName("#define CRED_MAX_STRING_LENGTH 256")]
        public const int CRED_MAX_STRING_LENGTH = 256;

        [NativeTypeName("#define CRED_MAX_USERNAME_LENGTH (256+1+256)")]
        public const int CRED_MAX_USERNAME_LENGTH = (256 + 1 + 256);

        [NativeTypeName("#define CRED_MAX_GENERIC_TARGET_NAME_LENGTH 32767")]
        public const int CRED_MAX_GENERIC_TARGET_NAME_LENGTH = 32767;

        [NativeTypeName("#define CRED_MAX_DOMAIN_TARGET_NAME_LENGTH (256+1+80)")]
        public const int CRED_MAX_DOMAIN_TARGET_NAME_LENGTH = (256 + 1 + 80);

        [NativeTypeName("#define CRED_MAX_TARGETNAME_NAMESPACE_LENGTH (256)")]
        public const int CRED_MAX_TARGETNAME_NAMESPACE_LENGTH = (256);

        [NativeTypeName("#define CRED_MAX_TARGETNAME_ATTRIBUTE_LENGTH (256)")]
        public const int CRED_MAX_TARGETNAME_ATTRIBUTE_LENGTH = (256);

        [NativeTypeName("#define CRED_MAX_VALUE_SIZE (256)")]
        public const int CRED_MAX_VALUE_SIZE = (256);

        [NativeTypeName("#define CRED_MAX_ATTRIBUTES 64")]
        public const int CRED_MAX_ATTRIBUTES = 64;

        [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME_W L\"*Session\"")]
        public const string CRED_SESSION_WILDCARD_NAME_W = "*Session";

        [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME_A \"*Session\"")]
        public static ReadOnlySpan<byte> CRED_SESSION_WILDCARD_NAME_A => new byte[] { 0x2A, 0x53, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define CRED_UNIVERSAL_WILDCARD_W L'*'")]
        public const ushort CRED_UNIVERSAL_WILDCARD_W = '*';

        [NativeTypeName("#define CRED_UNIVERSAL_WILDCARD_A '*'")]
        public const sbyte CRED_UNIVERSAL_WILDCARD_A = (sbyte)('*');

        [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME_LENGTH (sizeof(CRED_SESSION_WILDCARD_NAME_A)-1)")]
        public const uint CRED_SESSION_WILDCARD_NAME_LENGTH = unchecked(9 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE_W L\"Domain\"")]
        public const string CRED_TARGETNAME_DOMAIN_NAMESPACE_W = "Domain";

        [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE_A \"Domain\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_DOMAIN_NAMESPACE_A => new byte[] { 0x44, 0x6F, 0x6D, 0x61, 0x69, 0x6E, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE_LENGTH (sizeof(CRED_TARGETNAME_DOMAIN_NAMESPACE_A)-1)")]
        public const uint CRED_TARGETNAME_DOMAIN_NAMESPACE_LENGTH = unchecked(7 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_W L\"LegacyGeneric\"")]
        public const string CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_W = "LegacyGeneric";

        [NativeTypeName("#define CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_A \"LegacyGeneric\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_A => new byte[] { 0x4C, 0x65, 0x67, 0x61, 0x63, 0x79, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_LENGTH (sizeof(CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_A)-1)")]
        public const uint CRED_TARGETNAME_LEGACYGENERIC_NAMESPACE_LENGTH = unchecked(14 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_NAMESPACE_SEPERATOR_W L':'")]
        public const ushort CRED_TARGETNAME_NAMESPACE_SEPERATOR_W = ':';

        [NativeTypeName("#define CRED_TARGETNAME_NAMESPACE_SEPERATOR_A ':'")]
        public const sbyte CRED_TARGETNAME_NAMESPACE_SEPERATOR_A = (sbyte)(':');

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_W L'='")]
        public const ushort CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_W = '=';

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_A '='")]
        public const sbyte CRED_TARGETNAME_ATTRIBUTE_SEPERATOR_A = (sbyte)('=');

        [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_W L'|'")]
        public const ushort CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_W = '|';

        [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_A '|'")]
        public const sbyte CRED_TARGETNAME_DOMAIN_EXTENDED_USERNAME_SEPARATOR_A = (sbyte)('|');

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET_W L\"target\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_TARGET_W = "target";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET_A \"target\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_TARGET_A => new byte[] { 0x74, 0x61, 0x72, 0x67, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_TARGET_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_TARGET_LENGTH = unchecked(7 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME_W L\"name\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_NAME_W = "name";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME_A \"name\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_NAME_A => new byte[] { 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_NAME_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_NAME_LENGTH = unchecked(5 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH_W L\"batch\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_BATCH_W = "batch";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH_A \"batch\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_BATCH_A => new byte[] { 0x62, 0x61, 0x74, 0x63, 0x68, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_BATCH_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_BATCH_LENGTH = unchecked(6 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_W L\"interactive\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_W = "interactive";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_A \"interactive\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_A => new byte[] { 0x69, 0x6E, 0x74, 0x65, 0x72, 0x61, 0x63, 0x74, 0x69, 0x76, 0x65, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_LENGTH = unchecked(12 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SERVICE_W L\"service\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_SERVICE_W = "service";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SERVICE_A \"service\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_SERVICE_A => new byte[] { 0x73, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SERVICE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_SERVICE_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_SERVICE_LENGTH = unchecked(8 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORK_W L\"network\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_NETWORK_W = "network";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORK_A \"network\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_NETWORK_A => new byte[] { 0x6E, 0x65, 0x74, 0x77, 0x6F, 0x72, 0x6B, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORK_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_NETWORK_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_NETWORK_LENGTH = unchecked(8 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_W L\"networkcleartext\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_W = "networkcleartext";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_A \"networkcleartext\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_A => new byte[] { 0x6E, 0x65, 0x74, 0x77, 0x6F, 0x72, 0x6B, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x74, 0x65, 0x78, 0x74, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_LENGTH = unchecked(17 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_W L\"remoteinteractive\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_W = "remoteinteractive";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_A \"remoteinteractive\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_A => new byte[] { 0x72, 0x65, 0x6D, 0x6F, 0x74, 0x65, 0x69, 0x6E, 0x74, 0x65, 0x72, 0x61, 0x63, 0x74, 0x69, 0x76, 0x65, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_LENGTH = unchecked(18 - 1);

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_W L\"cachedinteractive\"")]
        public const string CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_W = "cachedinteractive";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_A \"cachedinteractive\"")]
        public static ReadOnlySpan<byte> CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_A => new byte[] { 0x63, 0x61, 0x63, 0x68, 0x65, 0x64, 0x69, 0x6E, 0x74, 0x65, 0x72, 0x61, 0x63, 0x74, 0x69, 0x76, 0x65, 0x00 };

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_LENGTH (sizeof(CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_A)-1)")]
        public const uint CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_LENGTH = unchecked(18 - 1);

        [NativeTypeName("#define CRED_SESSION_WILDCARD_NAME CRED_SESSION_WILDCARD_NAME_W")]
        public const string CRED_SESSION_WILDCARD_NAME = "*Session";

        [NativeTypeName("#define CRED_TARGETNAME_DOMAIN_NAMESPACE CRED_TARGETNAME_DOMAIN_NAMESPACE_W")]
        public const string CRED_TARGETNAME_DOMAIN_NAMESPACE = "Domain";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NAME CRED_TARGETNAME_ATTRIBUTE_NAME_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_NAME = "name";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_TARGET CRED_TARGETNAME_ATTRIBUTE_TARGET_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_TARGET = "target";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_BATCH CRED_TARGETNAME_ATTRIBUTE_BATCH_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_BATCH = "batch";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_INTERACTIVE = "interactive";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_SERVICE CRED_TARGETNAME_ATTRIBUTE_SERVICE_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_SERVICE = "service";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORK CRED_TARGETNAME_ATTRIBUTE_NETWORK_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_NETWORK = "network";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_NETWORKCLEARTEXT = "networkcleartext";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_REMOTEINTERACTIVE = "remoteinteractive";

        [NativeTypeName("#define CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE_W")]
        public const string CRED_TARGETNAME_ATTRIBUTE_CACHEDINTERACTIVE = "cachedinteractive";

        [NativeTypeName("#define CRED_LOGON_TYPES_MASK 0xF000")]
        public const int CRED_LOGON_TYPES_MASK = 0xF000;

        [NativeTypeName("#define CRED_FLAGS_PASSWORD_FOR_CERT 0x0001")]
        public const int CRED_FLAGS_PASSWORD_FOR_CERT = 0x0001;

        [NativeTypeName("#define CRED_FLAGS_PROMPT_NOW 0x0002")]
        public const int CRED_FLAGS_PROMPT_NOW = 0x0002;

        [NativeTypeName("#define CRED_FLAGS_USERNAME_TARGET 0x0004")]
        public const int CRED_FLAGS_USERNAME_TARGET = 0x0004;

        [NativeTypeName("#define CRED_FLAGS_OWF_CRED_BLOB 0x0008")]
        public const int CRED_FLAGS_OWF_CRED_BLOB = 0x0008;

        [NativeTypeName("#define CRED_FLAGS_REQUIRE_CONFIRMATION 0x0010")]
        public const int CRED_FLAGS_REQUIRE_CONFIRMATION = 0x0010;

        [NativeTypeName("#define CRED_FLAGS_WILDCARD_MATCH 0x0020")]
        public const int CRED_FLAGS_WILDCARD_MATCH = 0x0020;

        [NativeTypeName("#define CRED_FLAGS_VSM_PROTECTED 0x0040")]
        public const int CRED_FLAGS_VSM_PROTECTED = 0x0040;

        [NativeTypeName("#define CRED_FLAGS_NGC_CERT 0x0080")]
        public const int CRED_FLAGS_NGC_CERT = 0x0080;

        [NativeTypeName("#define CRED_FLAGS_VALID_FLAGS 0xF0FF")]
        public const int CRED_FLAGS_VALID_FLAGS = 0xF0FF;

        [NativeTypeName("#define CRED_FLAGS_VALID_INPUT_FLAGS 0xF09F")]
        public const int CRED_FLAGS_VALID_INPUT_FLAGS = 0xF09F;

        [NativeTypeName("#define CRED_TYPE_GENERIC 1")]
        public const int CRED_TYPE_GENERIC = 1;

        [NativeTypeName("#define CRED_TYPE_DOMAIN_PASSWORD 2")]
        public const int CRED_TYPE_DOMAIN_PASSWORD = 2;

        [NativeTypeName("#define CRED_TYPE_DOMAIN_CERTIFICATE 3")]
        public const int CRED_TYPE_DOMAIN_CERTIFICATE = 3;

        [NativeTypeName("#define CRED_TYPE_DOMAIN_VISIBLE_PASSWORD 4")]
        public const int CRED_TYPE_DOMAIN_VISIBLE_PASSWORD = 4;

        [NativeTypeName("#define CRED_TYPE_GENERIC_CERTIFICATE 5")]
        public const int CRED_TYPE_GENERIC_CERTIFICATE = 5;

        [NativeTypeName("#define CRED_TYPE_DOMAIN_EXTENDED 6")]
        public const int CRED_TYPE_DOMAIN_EXTENDED = 6;

        [NativeTypeName("#define CRED_TYPE_MAXIMUM 7")]
        public const int CRED_TYPE_MAXIMUM = 7;

        [NativeTypeName("#define CRED_TYPE_MAXIMUM_EX (CRED_TYPE_MAXIMUM+1000)")]
        public const int CRED_TYPE_MAXIMUM_EX = (7 + 1000);

        [NativeTypeName("#define CRED_MAX_CREDENTIAL_BLOB_SIZE (5*512)")]
        public const int CRED_MAX_CREDENTIAL_BLOB_SIZE = (5 * 512);

        [NativeTypeName("#define CRED_PERSIST_NONE 0")]
        public const int CRED_PERSIST_NONE = 0;

        [NativeTypeName("#define CRED_PERSIST_SESSION 1")]
        public const int CRED_PERSIST_SESSION = 1;

        [NativeTypeName("#define CRED_PERSIST_LOCAL_MACHINE 2")]
        public const int CRED_PERSIST_LOCAL_MACHINE = 2;

        [NativeTypeName("#define CRED_PERSIST_ENTERPRISE 3")]
        public const int CRED_PERSIST_ENTERPRISE = 3;

        [NativeTypeName("#define CRED_TI_SERVER_FORMAT_UNKNOWN 0x0001")]
        public const int CRED_TI_SERVER_FORMAT_UNKNOWN = 0x0001;

        [NativeTypeName("#define CRED_TI_DOMAIN_FORMAT_UNKNOWN 0x0002")]
        public const int CRED_TI_DOMAIN_FORMAT_UNKNOWN = 0x0002;

        [NativeTypeName("#define CRED_TI_ONLY_PASSWORD_REQUIRED 0x0004")]
        public const int CRED_TI_ONLY_PASSWORD_REQUIRED = 0x0004;

        [NativeTypeName("#define CRED_TI_USERNAME_TARGET 0x0008")]
        public const int CRED_TI_USERNAME_TARGET = 0x0008;

        [NativeTypeName("#define CRED_TI_CREATE_EXPLICIT_CRED 0x0010")]
        public const int CRED_TI_CREATE_EXPLICIT_CRED = 0x0010;

        [NativeTypeName("#define CRED_TI_WORKGROUP_MEMBER 0x0020")]
        public const int CRED_TI_WORKGROUP_MEMBER = 0x0020;

        [NativeTypeName("#define CRED_TI_DNSTREE_IS_DFS_SERVER 0x0040")]
        public const int CRED_TI_DNSTREE_IS_DFS_SERVER = 0x0040;

        [NativeTypeName("#define CRED_TI_VALID_FLAGS 0xF07F")]
        public const int CRED_TI_VALID_FLAGS = 0xF07F;

        [NativeTypeName("#define CERT_HASH_LENGTH 20")]
        public const int CERT_HASH_LENGTH = 20;

        [NativeTypeName("#define CRED_PACK_PROTECTED_CREDENTIALS 0x1")]
        public const int CRED_PACK_PROTECTED_CREDENTIALS = 0x1;

        [NativeTypeName("#define CRED_PACK_WOW_BUFFER 0x2")]
        public const int CRED_PACK_WOW_BUFFER = 0x2;

        [NativeTypeName("#define CRED_PACK_GENERIC_CREDENTIALS 0x4")]
        public const int CRED_PACK_GENERIC_CREDENTIALS = 0x4;

        [NativeTypeName("#define CRED_PACK_ID_PROVIDER_CREDENTIALS 0x8")]
        public const int CRED_PACK_ID_PROVIDER_CREDENTIALS = 0x8;

        [NativeTypeName("#define CREDUI_MAX_MESSAGE_LENGTH 1024")]
        public const int CREDUI_MAX_MESSAGE_LENGTH = 1024;

        [NativeTypeName("#define CREDUI_MAX_CAPTION_LENGTH 128")]
        public const int CREDUI_MAX_CAPTION_LENGTH = 128;

        [NativeTypeName("#define CREDUI_MAX_GENERIC_TARGET_LENGTH CRED_MAX_GENERIC_TARGET_NAME_LENGTH")]
        public const int CREDUI_MAX_GENERIC_TARGET_LENGTH = 32767;

        [NativeTypeName("#define CREDUI_MAX_DOMAIN_TARGET_LENGTH CRED_MAX_DOMAIN_TARGET_NAME_LENGTH")]
        public const int CREDUI_MAX_DOMAIN_TARGET_LENGTH = (256 + 1 + 80);

        [NativeTypeName("#define CREDUI_MAX_USERNAME_LENGTH CRED_MAX_USERNAME_LENGTH")]
        public const int CREDUI_MAX_USERNAME_LENGTH = (256 + 1 + 256);

        [NativeTypeName("#define CREDUI_MAX_PASSWORD_LENGTH (512 / 2)")]
        public const int CREDUI_MAX_PASSWORD_LENGTH = (512 / 2);

        [NativeTypeName("#define CREDUI_FLAGS_INCORRECT_PASSWORD 0x00001")]
        public const int CREDUI_FLAGS_INCORRECT_PASSWORD = 0x00001;

        [NativeTypeName("#define CREDUI_FLAGS_DO_NOT_PERSIST 0x00002")]
        public const int CREDUI_FLAGS_DO_NOT_PERSIST = 0x00002;

        [NativeTypeName("#define CREDUI_FLAGS_REQUEST_ADMINISTRATOR 0x00004")]
        public const int CREDUI_FLAGS_REQUEST_ADMINISTRATOR = 0x00004;

        [NativeTypeName("#define CREDUI_FLAGS_EXCLUDE_CERTIFICATES 0x00008")]
        public const int CREDUI_FLAGS_EXCLUDE_CERTIFICATES = 0x00008;

        [NativeTypeName("#define CREDUI_FLAGS_REQUIRE_CERTIFICATE 0x00010")]
        public const int CREDUI_FLAGS_REQUIRE_CERTIFICATE = 0x00010;

        [NativeTypeName("#define CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX 0x00040")]
        public const int CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX = 0x00040;

        [NativeTypeName("#define CREDUI_FLAGS_ALWAYS_SHOW_UI 0x00080")]
        public const int CREDUI_FLAGS_ALWAYS_SHOW_UI = 0x00080;

        [NativeTypeName("#define CREDUI_FLAGS_REQUIRE_SMARTCARD 0x00100")]
        public const int CREDUI_FLAGS_REQUIRE_SMARTCARD = 0x00100;

        [NativeTypeName("#define CREDUI_FLAGS_PASSWORD_ONLY_OK 0x00200")]
        public const int CREDUI_FLAGS_PASSWORD_ONLY_OK = 0x00200;

        [NativeTypeName("#define CREDUI_FLAGS_VALIDATE_USERNAME 0x00400")]
        public const int CREDUI_FLAGS_VALIDATE_USERNAME = 0x00400;

        [NativeTypeName("#define CREDUI_FLAGS_COMPLETE_USERNAME 0x00800")]
        public const int CREDUI_FLAGS_COMPLETE_USERNAME = 0x00800;

        [NativeTypeName("#define CREDUI_FLAGS_PERSIST 0x01000")]
        public const int CREDUI_FLAGS_PERSIST = 0x01000;

        [NativeTypeName("#define CREDUI_FLAGS_SERVER_CREDENTIAL 0x04000")]
        public const int CREDUI_FLAGS_SERVER_CREDENTIAL = 0x04000;

        [NativeTypeName("#define CREDUI_FLAGS_EXPECT_CONFIRMATION 0x20000")]
        public const int CREDUI_FLAGS_EXPECT_CONFIRMATION = 0x20000;

        [NativeTypeName("#define CREDUI_FLAGS_GENERIC_CREDENTIALS 0x40000")]
        public const int CREDUI_FLAGS_GENERIC_CREDENTIALS = 0x40000;

        [NativeTypeName("#define CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS 0x80000")]
        public const int CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS = 0x80000;

        [NativeTypeName("#define CREDUI_FLAGS_KEEP_USERNAME 0x100000")]
        public const int CREDUI_FLAGS_KEEP_USERNAME = 0x100000;

        [NativeTypeName("#define CREDUI_FLAGS_PROMPT_VALID ( \\\r\n        CREDUI_FLAGS_INCORRECT_PASSWORD | \\\r\n        CREDUI_FLAGS_DO_NOT_PERSIST | \\\r\n        CREDUI_FLAGS_REQUEST_ADMINISTRATOR | \\\r\n        CREDUI_FLAGS_EXCLUDE_CERTIFICATES | \\\r\n        CREDUI_FLAGS_REQUIRE_CERTIFICATE | \\\r\n        CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX | \\\r\n        CREDUI_FLAGS_ALWAYS_SHOW_UI | \\\r\n        CREDUI_FLAGS_REQUIRE_SMARTCARD | \\\r\n        CREDUI_FLAGS_PASSWORD_ONLY_OK | \\\r\n        CREDUI_FLAGS_VALIDATE_USERNAME | \\\r\n        CREDUI_FLAGS_COMPLETE_USERNAME | \\\r\n        CREDUI_FLAGS_PERSIST | \\\r\n        CREDUI_FLAGS_SERVER_CREDENTIAL | \\\r\n        CREDUI_FLAGS_EXPECT_CONFIRMATION | \\\r\n        CREDUI_FLAGS_GENERIC_CREDENTIALS | \\\r\n        CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS | \\\r\n        CREDUI_FLAGS_KEEP_USERNAME )")]
        public const int CREDUI_FLAGS_PROMPT_VALID = (0x00001 | 0x00002 | 0x00004 | 0x00008 | 0x00010 | 0x00040 | 0x00080 | 0x00100 | 0x00200 | 0x00400 | 0x00800 | 0x01000 | 0x04000 | 0x20000 | 0x40000 | 0x80000 | 0x100000);

        [NativeTypeName("#define CREDUIWIN_GENERIC 0x00000001")]
        public const int CREDUIWIN_GENERIC = 0x00000001;

        [NativeTypeName("#define CREDUIWIN_CHECKBOX 0x00000002")]
        public const int CREDUIWIN_CHECKBOX = 0x00000002;

        [NativeTypeName("#define CREDUIWIN_AUTHPACKAGE_ONLY 0x00000010")]
        public const int CREDUIWIN_AUTHPACKAGE_ONLY = 0x00000010;

        [NativeTypeName("#define CREDUIWIN_IN_CRED_ONLY 0x00000020")]
        public const int CREDUIWIN_IN_CRED_ONLY = 0x00000020;

        [NativeTypeName("#define CREDUIWIN_ENUMERATE_ADMINS 0x00000100")]
        public const int CREDUIWIN_ENUMERATE_ADMINS = 0x00000100;

        [NativeTypeName("#define CREDUIWIN_ENUMERATE_CURRENT_USER 0x00000200")]
        public const int CREDUIWIN_ENUMERATE_CURRENT_USER = 0x00000200;

        [NativeTypeName("#define CREDUIWIN_SECURE_PROMPT 0x00001000")]
        public const int CREDUIWIN_SECURE_PROMPT = 0x00001000;

        [NativeTypeName("#define CREDUIWIN_PREPROMPTING 0X00002000")]
        public const int CREDUIWIN_PREPROMPTING = 0X00002000;

        [NativeTypeName("#define CREDUIWIN_PACK_32_WOW 0x10000000")]
        public const int CREDUIWIN_PACK_32_WOW = 0x10000000;

        [NativeTypeName("#define CREDUIWIN_VALID_FLAGS ( \\\r\n        CREDUIWIN_GENERIC                | \\\r\n        CREDUIWIN_CHECKBOX               | \\\r\n        CREDUIWIN_AUTHPACKAGE_ONLY       | \\\r\n        CREDUIWIN_IN_CRED_ONLY           | \\\r\n        CREDUIWIN_ENUMERATE_ADMINS       | \\\r\n        CREDUIWIN_ENUMERATE_CURRENT_USER | \\\r\n        CREDUIWIN_SECURE_PROMPT          | \\\r\n        CREDUIWIN_PREPROMPTING           | \\\r\n        CREDUIWIN_PACK_32_WOW            )")]
        public const int CREDUIWIN_VALID_FLAGS = (0x00000001 | 0x00000002 | 0x00000010 | 0x00000020 | 0x00000100 | 0x00000200 | 0x00001000 | 0X00002000 | 0x10000000);

        [NativeTypeName("#define CRED_PRESERVE_CREDENTIAL_BLOB 0x1")]
        public const int CRED_PRESERVE_CREDENTIAL_BLOB = 0x1;

        [NativeTypeName("#define CredWrite CredWriteW")]
        public static readonly delegate*<CREDENTIALW*, uint, int> CredWrite = &CredWriteW;

        [NativeTypeName("#define CredRead CredReadW")]
        public static readonly delegate*<ushort*, uint, uint, CREDENTIALW**, int> CredRead = &CredReadW;

        [NativeTypeName("#define CRED_ENUMERATE_ALL_CREDENTIALS 0x1")]
        public const int CRED_ENUMERATE_ALL_CREDENTIALS = 0x1;

        [NativeTypeName("#define CredEnumerate CredEnumerateW")]
        public static readonly delegate*<ushort*, uint, uint*, CREDENTIALW***, int> CredEnumerate = &CredEnumerateW;

        [NativeTypeName("#define CredWriteDomainCredentials CredWriteDomainCredentialsW")]
        public static readonly delegate*<CREDENTIAL_TARGET_INFORMATIONW*, CREDENTIALW*, uint, int> CredWriteDomainCredentials = &CredWriteDomainCredentialsW;

        [NativeTypeName("#define CRED_CACHE_TARGET_INFORMATION 0x1")]
        public const int CRED_CACHE_TARGET_INFORMATION = 0x1;

        [NativeTypeName("#define CredReadDomainCredentials CredReadDomainCredentialsW")]
        public static readonly delegate*<CREDENTIAL_TARGET_INFORMATIONW*, uint, uint*, CREDENTIALW***, int> CredReadDomainCredentials = &CredReadDomainCredentialsW;

        [NativeTypeName("#define CredDelete CredDeleteW")]
        public static readonly delegate*<ushort*, uint, uint, int> CredDelete = &CredDeleteW;

        [NativeTypeName("#define CredRename CredRenameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint, int> CredRename = &CredRenameW;

        [NativeTypeName("#define CRED_ALLOW_NAME_RESOLUTION 0x1")]
        public const int CRED_ALLOW_NAME_RESOLUTION = 0x1;

        [NativeTypeName("#define CredGetTargetInfo CredGetTargetInfoW")]
        public static readonly delegate*<ushort*, uint, CREDENTIAL_TARGET_INFORMATIONW**, int> CredGetTargetInfo = &CredGetTargetInfoW;

        [NativeTypeName("#define CredMarshalCredential CredMarshalCredentialW")]
        public static readonly delegate*<CRED_MARSHAL_TYPE, void*, ushort**, int> CredMarshalCredential = &CredMarshalCredentialW;

        [NativeTypeName("#define CredUnmarshalCredential CredUnmarshalCredentialW")]
        public static readonly delegate*<ushort*, CRED_MARSHAL_TYPE*, void**, int> CredUnmarshalCredential = &CredUnmarshalCredentialW;

        [NativeTypeName("#define CredIsMarshaledCredential CredIsMarshaledCredentialW")]
        public static readonly delegate*<ushort*, int> CredIsMarshaledCredential = &CredIsMarshaledCredentialW;

        [NativeTypeName("#define CredUnPackAuthenticationBuffer CredUnPackAuthenticationBufferW")]
        public static readonly delegate*<uint, void*, uint, ushort*, uint*, ushort*, uint*, ushort*, uint*, int> CredUnPackAuthenticationBuffer = &CredUnPackAuthenticationBufferW;

        [NativeTypeName("#define CredPackAuthenticationBuffer CredPackAuthenticationBufferW")]
        public static readonly delegate*<uint, ushort*, ushort*, byte*, uint*, int> CredPackAuthenticationBuffer = &CredPackAuthenticationBufferW;

        [NativeTypeName("#define CRED_PROTECT_AS_SELF 0x1")]
        public const int CRED_PROTECT_AS_SELF = 0x1;

        [NativeTypeName("#define CRED_PROTECT_TO_SYSTEM 0x2")]
        public const int CRED_PROTECT_TO_SYSTEM = 0x2;

        [NativeTypeName("#define CRED_PROTECT_VALID_FLAGS (CRED_PROTECT_AS_SELF | CRED_PROTECT_TO_SYSTEM)")]
        public const int CRED_PROTECT_VALID_FLAGS = (0x1 | 0x2);

        [NativeTypeName("#define CredProtect CredProtectW")]
        public static readonly delegate*<int, ushort*, uint, ushort*, uint*, CRED_PROTECTION_TYPE*, int> CredProtect = &CredProtectW;

        [NativeTypeName("#define CRED_UNPROTECT_AS_SELF 0x1")]
        public const int CRED_UNPROTECT_AS_SELF = 0x1;

        [NativeTypeName("#define CRED_UNPROTECT_ALLOW_TO_SYSTEM 0x2")]
        public const int CRED_UNPROTECT_ALLOW_TO_SYSTEM = 0x2;

        [NativeTypeName("#define CRED_UNPROTECT_VALID_FLAGS (CRED_UNPROTECT_AS_SELF | CRED_UNPROTECT_ALLOW_TO_SYSTEM)")]
        public const int CRED_UNPROTECT_VALID_FLAGS = (0x1 | 0x2);

        [NativeTypeName("#define CredUnprotect CredUnprotectW")]
        public static readonly delegate*<int, ushort*, uint, ushort*, uint*, int> CredUnprotect = &CredUnprotectW;

        [NativeTypeName("#define CredIsProtected CredIsProtectedW")]
        public static readonly delegate*<ushort*, CRED_PROTECTION_TYPE*, int> CredIsProtected = &CredIsProtectedW;

        [NativeTypeName("#define CredFindBestCredential CredFindBestCredentialW")]
        public static readonly delegate*<ushort*, uint, uint, CREDENTIALW**, int> CredFindBestCredential = &CredFindBestCredentialW;

        [NativeTypeName("#define CredUIPromptForCredentials CredUIPromptForCredentialsW")]
        public static readonly delegate*<CREDUI_INFOW*, ushort*, SecHandle*, uint, ushort*, uint, ushort*, uint, int*, uint, uint> CredUIPromptForCredentials = &CredUIPromptForCredentialsW;

        [NativeTypeName("#define CredUIPromptForWindowsCredentials CredUIPromptForWindowsCredentialsW")]
        public static readonly delegate*<CREDUI_INFOW*, uint, uint*, void*, uint, void**, uint*, int*, uint, uint> CredUIPromptForWindowsCredentials = &CredUIPromptForWindowsCredentialsW;

        [NativeTypeName("#define CredUIParseUserName CredUIParseUserNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, ushort*, uint, uint> CredUIParseUserName = &CredUIParseUserNameW;

        [NativeTypeName("#define CredUICmdLinePromptForCredentials CredUICmdLinePromptForCredentialsW")]
        public static readonly delegate*<ushort*, SecHandle*, uint, ushort*, uint, ushort*, uint, int*, uint, uint> CredUICmdLinePromptForCredentials = &CredUICmdLinePromptForCredentialsW;

        [NativeTypeName("#define CredUIConfirmCredentials CredUIConfirmCredentialsW")]
        public static readonly delegate*<ushort*, int, uint> CredUIConfirmCredentials = &CredUIConfirmCredentialsW;
    }
}
