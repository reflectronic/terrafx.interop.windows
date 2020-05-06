// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_ASYNC_RETRIEVAL_COMPLETION
    {
        [NativeTypeName("PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC")]
        public IntPtr* pfnCompletion;

        [NativeTypeName("LPVOID")]
        public void* pvCompletion;
    }
}