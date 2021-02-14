// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PROCESS_MEMORY_COUNTERS_EX" /> struct.</summary>
    public static unsafe class PROCESS_MEMORY_COUNTERS_EXTests
    {
        /// <summary>Validates that the <see cref="PROCESS_MEMORY_COUNTERS_EX" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PROCESS_MEMORY_COUNTERS_EX>(), Is.EqualTo(sizeof(PROCESS_MEMORY_COUNTERS_EX)));
        }

        /// <summary>Validates that the <see cref="PROCESS_MEMORY_COUNTERS_EX" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PROCESS_MEMORY_COUNTERS_EX).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PROCESS_MEMORY_COUNTERS_EX" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PROCESS_MEMORY_COUNTERS_EX), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(PROCESS_MEMORY_COUNTERS_EX), Is.EqualTo(44));
            }
        }
    }
}
