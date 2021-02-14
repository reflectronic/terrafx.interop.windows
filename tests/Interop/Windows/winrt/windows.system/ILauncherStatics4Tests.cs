// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ILauncherStatics4" /> struct.</summary>
    public static unsafe class ILauncherStatics4Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ILauncherStatics4" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ILauncherStatics4).GUID, Is.EqualTo(IID_ILauncherStatics4));
        }

        /// <summary>Validates that the <see cref="ILauncherStatics4" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ILauncherStatics4>(), Is.EqualTo(sizeof(ILauncherStatics4)));
        }

        /// <summary>Validates that the <see cref="ILauncherStatics4" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ILauncherStatics4).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ILauncherStatics4" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ILauncherStatics4), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ILauncherStatics4), Is.EqualTo(4));
            }
        }
    }
}
