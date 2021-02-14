// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IGeovisitMonitorStatics" /> struct.</summary>
    public static unsafe class IGeovisitMonitorStaticsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IGeovisitMonitorStatics" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IGeovisitMonitorStatics).GUID, Is.EqualTo(IID_IGeovisitMonitorStatics));
        }

        /// <summary>Validates that the <see cref="IGeovisitMonitorStatics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IGeovisitMonitorStatics>(), Is.EqualTo(sizeof(IGeovisitMonitorStatics)));
        }

        /// <summary>Validates that the <see cref="IGeovisitMonitorStatics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IGeovisitMonitorStatics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IGeovisitMonitorStatics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IGeovisitMonitorStatics), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IGeovisitMonitorStatics), Is.EqualTo(4));
            }
        }
    }
}
