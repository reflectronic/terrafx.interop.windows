// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="RM_PROCESS_INFO" /> struct.</summary>
    public static unsafe class RM_PROCESS_INFOTests
    {
        /// <summary>Validates that the <see cref="RM_PROCESS_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<RM_PROCESS_INFO>(), Is.EqualTo(sizeof(RM_PROCESS_INFO)));
        }

        /// <summary>Validates that the <see cref="RM_PROCESS_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(RM_PROCESS_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="RM_PROCESS_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(RM_PROCESS_INFO), Is.EqualTo(668));
        }
    }
}
