// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CONFIRMSAFETY
    {
        [NativeTypeName("CLSID")]
        public Guid clsid;

        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }
}
