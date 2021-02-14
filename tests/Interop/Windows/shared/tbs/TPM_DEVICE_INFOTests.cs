// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TPM_DEVICE_INFO" /> struct.</summary>
    public static unsafe class TPM_DEVICE_INFOTests
    {
        /// <summary>Validates that the <see cref="TPM_DEVICE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TPM_DEVICE_INFO>(), Is.EqualTo(sizeof(TPM_DEVICE_INFO)));
        }

        /// <summary>Validates that the <see cref="TPM_DEVICE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TPM_DEVICE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TPM_DEVICE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TPM_DEVICE_INFO), Is.EqualTo(16));
        }
    }
}
