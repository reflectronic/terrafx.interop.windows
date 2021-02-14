// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="InertiaProcessor" /> struct.</summary>
    public static unsafe class InertiaProcessorTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="InertiaProcessor" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(InertiaProcessor).GUID, Is.EqualTo(CLSID_InertiaProcessor));
        }

        /// <summary>Validates that the <see cref="InertiaProcessor" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<InertiaProcessor>(), Is.EqualTo(sizeof(InertiaProcessor)));
        }

        /// <summary>Validates that the <see cref="InertiaProcessor" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(InertiaProcessor).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="InertiaProcessor" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(InertiaProcessor), Is.EqualTo(1));
        }
    }
}
