// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IGeocoordinate" /> struct.</summary>
    public static unsafe class IGeocoordinateTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IGeocoordinate" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IGeocoordinate).GUID, Is.EqualTo(IID_IGeocoordinate));
        }

        /// <summary>Validates that the <see cref="IGeocoordinate" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IGeocoordinate>(), Is.EqualTo(sizeof(IGeocoordinate)));
        }

        /// <summary>Validates that the <see cref="IGeocoordinate" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IGeocoordinate).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IGeocoordinate" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IGeocoordinate), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IGeocoordinate), Is.EqualTo(4));
            }
        }
    }
}
