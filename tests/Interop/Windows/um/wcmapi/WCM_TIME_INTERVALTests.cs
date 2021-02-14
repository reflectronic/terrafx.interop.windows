// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WCM_TIME_INTERVAL" /> struct.</summary>
    public static unsafe class WCM_TIME_INTERVALTests
    {
        /// <summary>Validates that the <see cref="WCM_TIME_INTERVAL" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WCM_TIME_INTERVAL>(), Is.EqualTo(sizeof(WCM_TIME_INTERVAL)));
        }

        /// <summary>Validates that the <see cref="WCM_TIME_INTERVAL" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WCM_TIME_INTERVAL).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WCM_TIME_INTERVAL" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WCM_TIME_INTERVAL), Is.EqualTo(14));
        }
    }
}
