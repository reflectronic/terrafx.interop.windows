// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRYPT_OBJID_TABLE" /> struct.</summary>
    public static unsafe class CRYPT_OBJID_TABLETests
    {
        /// <summary>Validates that the <see cref="CRYPT_OBJID_TABLE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRYPT_OBJID_TABLE>(), Is.EqualTo(sizeof(CRYPT_OBJID_TABLE)));
        }

        /// <summary>Validates that the <see cref="CRYPT_OBJID_TABLE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRYPT_OBJID_TABLE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRYPT_OBJID_TABLE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CRYPT_OBJID_TABLE), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(CRYPT_OBJID_TABLE), Is.EqualTo(8));
            }
        }
    }
}
