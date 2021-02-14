// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PSS_PROCESS_INFORMATION" /> struct.</summary>
    public static unsafe class PSS_PROCESS_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="PSS_PROCESS_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PSS_PROCESS_INFORMATION>(), Is.EqualTo(sizeof(PSS_PROCESS_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="PSS_PROCESS_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PSS_PROCESS_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PSS_PROCESS_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PSS_PROCESS_INFORMATION), Is.EqualTo(704));
            }
            else
            {
                Assert.That(sizeof(PSS_PROCESS_INFORMATION), Is.EqualTo(636));
            }
        }
    }
}
