// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct WCM_PROFILE_INFO_LIST
    {
        [NativeTypeName("DWORD")]
        public uint dwNumberOfItems;

        [NativeTypeName("WCM_PROFILE_INFO [1]")]
        public _ProfileInfo_e__FixedBuffer ProfileInfo;

        public partial struct _ProfileInfo_e__FixedBuffer
        {
            public WCM_PROFILE_INFO e0;

            public ref WCM_PROFILE_INFO this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<WCM_PROFILE_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
