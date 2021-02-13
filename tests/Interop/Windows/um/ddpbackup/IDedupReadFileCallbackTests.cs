// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDedupReadFileCallback" /> struct.</summary>
    public static unsafe class IDedupReadFileCallbackTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDedupReadFileCallback" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDedupReadFileCallback).GUID, Is.EqualTo(IID_IDedupReadFileCallback));
        }

        /// <summary>Validates that the <see cref="IDedupReadFileCallback" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDedupReadFileCallback>(), Is.EqualTo(sizeof(IDedupReadFileCallback)));
        }

        /// <summary>Validates that the <see cref="IDedupReadFileCallback" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDedupReadFileCallback).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDedupReadFileCallback" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDedupReadFileCallback), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDedupReadFileCallback), Is.EqualTo(4));
            }
        }
    }
}
