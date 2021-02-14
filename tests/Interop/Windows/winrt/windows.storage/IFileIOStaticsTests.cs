// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IFileIOStatics" /> struct.</summary>
    public static unsafe class IFileIOStaticsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFileIOStatics" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IFileIOStatics).GUID, Is.EqualTo(IID_IFileIOStatics));
        }

        /// <summary>Validates that the <see cref="IFileIOStatics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IFileIOStatics>(), Is.EqualTo(sizeof(IFileIOStatics)));
        }

        /// <summary>Validates that the <see cref="IFileIOStatics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IFileIOStatics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IFileIOStatics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IFileIOStatics), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IFileIOStatics), Is.EqualTo(4));
            }
        }
    }
}
