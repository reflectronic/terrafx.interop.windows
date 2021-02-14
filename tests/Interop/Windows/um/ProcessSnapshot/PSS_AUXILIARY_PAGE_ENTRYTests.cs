// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PSS_AUXILIARY_PAGE_ENTRY" /> struct.</summary>
    public static unsafe class PSS_AUXILIARY_PAGE_ENTRYTests
    {
        /// <summary>Validates that the <see cref="PSS_AUXILIARY_PAGE_ENTRY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PSS_AUXILIARY_PAGE_ENTRY>(), Is.EqualTo(sizeof(PSS_AUXILIARY_PAGE_ENTRY)));
        }

        /// <summary>Validates that the <see cref="PSS_AUXILIARY_PAGE_ENTRY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PSS_AUXILIARY_PAGE_ENTRY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PSS_AUXILIARY_PAGE_ENTRY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PSS_AUXILIARY_PAGE_ENTRY), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(PSS_AUXILIARY_PAGE_ENTRY), Is.EqualTo(48));
            }
        }
    }
}
