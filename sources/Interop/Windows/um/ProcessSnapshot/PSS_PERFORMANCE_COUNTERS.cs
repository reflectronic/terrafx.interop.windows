// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PSS_PERFORMANCE_COUNTERS
    {
        [NativeTypeName("UINT64")]
        public ulong TotalCycleCount;

        [NativeTypeName("UINT64")]
        public ulong TotalWallClockPeriod;

        [NativeTypeName("UINT64")]
        public ulong VaCloneCycleCount;

        [NativeTypeName("UINT64")]
        public ulong VaCloneWallClockPeriod;

        [NativeTypeName("UINT64")]
        public ulong VaSpaceCycleCount;

        [NativeTypeName("UINT64")]
        public ulong VaSpaceWallClockPeriod;

        [NativeTypeName("UINT64")]
        public ulong AuxPagesCycleCount;

        [NativeTypeName("UINT64")]
        public ulong AuxPagesWallClockPeriod;

        [NativeTypeName("UINT64")]
        public ulong HandlesCycleCount;

        [NativeTypeName("UINT64")]
        public ulong HandlesWallClockPeriod;

        [NativeTypeName("UINT64")]
        public ulong ThreadsCycleCount;

        [NativeTypeName("UINT64")]
        public ulong ThreadsWallClockPeriod;
    }
}
