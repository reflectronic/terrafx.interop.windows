// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IStorageLibraryStatics" /> struct.</summary>
    public static unsafe class IStorageLibraryStaticsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IStorageLibraryStatics" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IStorageLibraryStatics).GUID, Is.EqualTo(IID_IStorageLibraryStatics));
        }

        /// <summary>Validates that the <see cref="IStorageLibraryStatics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IStorageLibraryStatics>(), Is.EqualTo(sizeof(IStorageLibraryStatics)));
        }

        /// <summary>Validates that the <see cref="IStorageLibraryStatics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IStorageLibraryStatics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IStorageLibraryStatics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IStorageLibraryStatics), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IStorageLibraryStatics), Is.EqualTo(4));
            }
        }
    }
}
