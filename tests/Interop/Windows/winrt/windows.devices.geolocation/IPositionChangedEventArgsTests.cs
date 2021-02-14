// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPositionChangedEventArgs" /> struct.</summary>
    public static unsafe class IPositionChangedEventArgsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPositionChangedEventArgs" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPositionChangedEventArgs).GUID, Is.EqualTo(IID_IPositionChangedEventArgs));
        }

        /// <summary>Validates that the <see cref="IPositionChangedEventArgs" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPositionChangedEventArgs>(), Is.EqualTo(sizeof(IPositionChangedEventArgs)));
        }

        /// <summary>Validates that the <see cref="IPositionChangedEventArgs" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPositionChangedEventArgs).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPositionChangedEventArgs" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPositionChangedEventArgs), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPositionChangedEventArgs), Is.EqualTo(4));
            }
        }
    }
}
