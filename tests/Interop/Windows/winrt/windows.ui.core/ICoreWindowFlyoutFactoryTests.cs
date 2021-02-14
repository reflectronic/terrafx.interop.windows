// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICoreWindowFlyoutFactory" /> struct.</summary>
    public static unsafe class ICoreWindowFlyoutFactoryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICoreWindowFlyoutFactory" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICoreWindowFlyoutFactory).GUID, Is.EqualTo(IID_ICoreWindowFlyoutFactory));
        }

        /// <summary>Validates that the <see cref="ICoreWindowFlyoutFactory" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICoreWindowFlyoutFactory>(), Is.EqualTo(sizeof(ICoreWindowFlyoutFactory)));
        }

        /// <summary>Validates that the <see cref="ICoreWindowFlyoutFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICoreWindowFlyoutFactory).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICoreWindowFlyoutFactory" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICoreWindowFlyoutFactory), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICoreWindowFlyoutFactory), Is.EqualTo(4));
            }
        }
    }
}
