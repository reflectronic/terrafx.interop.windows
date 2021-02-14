// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppDataPaths" /> struct.</summary>
    public static unsafe class IAppDataPathsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppDataPaths" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppDataPaths).GUID, Is.EqualTo(IID_IAppDataPaths));
        }

        /// <summary>Validates that the <see cref="IAppDataPaths" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppDataPaths>(), Is.EqualTo(sizeof(IAppDataPaths)));
        }

        /// <summary>Validates that the <see cref="IAppDataPaths" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppDataPaths).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppDataPaths" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppDataPaths), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppDataPaths), Is.EqualTo(4));
            }
        }
    }
}
