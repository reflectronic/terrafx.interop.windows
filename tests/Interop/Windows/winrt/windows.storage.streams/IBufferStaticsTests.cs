// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IBufferStatics" /> struct.</summary>
    public static unsafe class IBufferStaticsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IBufferStatics" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IBufferStatics).GUID, Is.EqualTo(IID_IBufferStatics));
        }

        /// <summary>Validates that the <see cref="IBufferStatics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IBufferStatics>(), Is.EqualTo(sizeof(IBufferStatics)));
        }

        /// <summary>Validates that the <see cref="IBufferStatics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IBufferStatics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IBufferStatics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IBufferStatics), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IBufferStatics), Is.EqualTo(4));
            }
        }
    }
}
