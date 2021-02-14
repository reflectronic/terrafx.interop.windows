// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="InkD2DRenderer" /> struct.</summary>
    public static unsafe class InkD2DRendererTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="InkD2DRenderer" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(InkD2DRenderer).GUID, Is.EqualTo(CLSID_InkD2DRenderer));
        }

        /// <summary>Validates that the <see cref="InkD2DRenderer" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<InkD2DRenderer>(), Is.EqualTo(sizeof(InkD2DRenderer)));
        }

        /// <summary>Validates that the <see cref="InkD2DRenderer" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(InkD2DRenderer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="InkD2DRenderer" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(InkD2DRenderer), Is.EqualTo(1));
        }
    }
}
