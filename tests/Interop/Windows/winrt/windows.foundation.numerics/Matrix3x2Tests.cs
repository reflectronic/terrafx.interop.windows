// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Matrix3x2" /> struct.</summary>
    public static unsafe class Matrix3x2Tests
    {
        /// <summary>Validates that the <see cref="Matrix3x2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<Matrix3x2>(), Is.EqualTo(sizeof(Matrix3x2)));
        }

        /// <summary>Validates that the <see cref="Matrix3x2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(Matrix3x2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="Matrix3x2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(Matrix3x2), Is.EqualTo(24));
        }
    }
}
