// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BasicGeoposition" /> struct.</summary>
    public static unsafe class BasicGeopositionTests
    {
        /// <summary>Validates that the <see cref="BasicGeoposition" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BasicGeoposition>(), Is.EqualTo(sizeof(BasicGeoposition)));
        }

        /// <summary>Validates that the <see cref="BasicGeoposition" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BasicGeoposition).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BasicGeoposition" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(BasicGeoposition), Is.EqualTo(24));
        }
    }
}
