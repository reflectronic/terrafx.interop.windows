// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppResourceGroupMemoryReport" /> struct.</summary>
    public static unsafe class IAppResourceGroupMemoryReportTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppResourceGroupMemoryReport" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppResourceGroupMemoryReport).GUID, Is.EqualTo(IID_IAppResourceGroupMemoryReport));
        }

        /// <summary>Validates that the <see cref="IAppResourceGroupMemoryReport" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppResourceGroupMemoryReport>(), Is.EqualTo(sizeof(IAppResourceGroupMemoryReport)));
        }

        /// <summary>Validates that the <see cref="IAppResourceGroupMemoryReport" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppResourceGroupMemoryReport).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppResourceGroupMemoryReport" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppResourceGroupMemoryReport), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppResourceGroupMemoryReport), Is.EqualTo(4));
            }
        }
    }
}
