// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DedupBackupSupport" /> struct.</summary>
    public static unsafe class DedupBackupSupportTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DedupBackupSupport" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DedupBackupSupport).GUID, Is.EqualTo(CLSID_DedupBackupSupport));
        }

        /// <summary>Validates that the <see cref="DedupBackupSupport" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DedupBackupSupport>(), Is.EqualTo(sizeof(DedupBackupSupport)));
        }

        /// <summary>Validates that the <see cref="DedupBackupSupport" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DedupBackupSupport).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DedupBackupSupport" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DedupBackupSupport), Is.EqualTo(1));
        }
    }
}
