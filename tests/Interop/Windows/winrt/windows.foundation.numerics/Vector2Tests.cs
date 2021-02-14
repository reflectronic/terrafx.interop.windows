// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Vector2" /> struct.</summary>
    public static unsafe class Vector2Tests
    {
        /// <summary>Validates that the <see cref="Vector2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<Vector2>(), Is.EqualTo(sizeof(Vector2)));
        }

        /// <summary>Validates that the <see cref="Vector2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(Vector2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="Vector2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(Vector2), Is.EqualTo(8));
        }
    }
}
