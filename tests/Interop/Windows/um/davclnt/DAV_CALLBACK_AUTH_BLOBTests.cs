// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/davclnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DAV_CALLBACK_AUTH_BLOB" /> struct.</summary>
    public static unsafe class DAV_CALLBACK_AUTH_BLOBTests
    {
        /// <summary>Validates that the <see cref="DAV_CALLBACK_AUTH_BLOB" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DAV_CALLBACK_AUTH_BLOB>(), Is.EqualTo(sizeof(DAV_CALLBACK_AUTH_BLOB)));
        }

        /// <summary>Validates that the <see cref="DAV_CALLBACK_AUTH_BLOB" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DAV_CALLBACK_AUTH_BLOB).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DAV_CALLBACK_AUTH_BLOB" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DAV_CALLBACK_AUTH_BLOB), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(DAV_CALLBACK_AUTH_BLOB), Is.EqualTo(12));
            }
        }
    }
}
