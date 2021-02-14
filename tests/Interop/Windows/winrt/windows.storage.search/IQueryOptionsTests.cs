// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IQueryOptions" /> struct.</summary>
    public static unsafe class IQueryOptionsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IQueryOptions" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IQueryOptions).GUID, Is.EqualTo(IID_IQueryOptions));
        }

        /// <summary>Validates that the <see cref="IQueryOptions" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IQueryOptions>(), Is.EqualTo(sizeof(IQueryOptions)));
        }

        /// <summary>Validates that the <see cref="IQueryOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IQueryOptions).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IQueryOptions" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IQueryOptions), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IQueryOptions), Is.EqualTo(4));
            }
        }
    }
}
