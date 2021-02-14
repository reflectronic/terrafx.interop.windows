// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IUserDataPaths" /> struct.</summary>
    public static unsafe class IUserDataPathsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUserDataPaths" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IUserDataPaths).GUID, Is.EqualTo(IID_IUserDataPaths));
        }

        /// <summary>Validates that the <see cref="IUserDataPaths" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IUserDataPaths>(), Is.EqualTo(sizeof(IUserDataPaths)));
        }

        /// <summary>Validates that the <see cref="IUserDataPaths" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IUserDataPaths).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IUserDataPaths" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IUserDataPaths), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IUserDataPaths), Is.EqualTo(4));
            }
        }
    }
}
