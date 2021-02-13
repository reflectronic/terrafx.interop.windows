// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevicedef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SW_DEVICE_CREATE_INFO" /> struct.</summary>
    public static unsafe class SW_DEVICE_CREATE_INFOTests
    {
        /// <summary>Validates that the <see cref="SW_DEVICE_CREATE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SW_DEVICE_CREATE_INFO>(), Is.EqualTo(sizeof(SW_DEVICE_CREATE_INFO)));
        }

        /// <summary>Validates that the <see cref="SW_DEVICE_CREATE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SW_DEVICE_CREATE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SW_DEVICE_CREATE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SW_DEVICE_CREATE_INFO), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(SW_DEVICE_CREATE_INFO), Is.EqualTo(36));
            }
        }
    }
}
