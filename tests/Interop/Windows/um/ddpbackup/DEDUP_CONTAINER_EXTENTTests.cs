// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DEDUP_CONTAINER_EXTENT" /> struct.</summary>
    public static unsafe class DEDUP_CONTAINER_EXTENTTests
    {
        /// <summary>Validates that the <see cref="DEDUP_CONTAINER_EXTENT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DEDUP_CONTAINER_EXTENT>(), Is.EqualTo(sizeof(DEDUP_CONTAINER_EXTENT)));
        }

        /// <summary>Validates that the <see cref="DEDUP_CONTAINER_EXTENT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DEDUP_CONTAINER_EXTENT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DEDUP_CONTAINER_EXTENT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DEDUP_CONTAINER_EXTENT), Is.EqualTo(24));
        }
    }
}
