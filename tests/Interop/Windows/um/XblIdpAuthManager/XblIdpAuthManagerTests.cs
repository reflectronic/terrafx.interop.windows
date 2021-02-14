// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XblIdpAuthManager" /> struct.</summary>
    public static unsafe class XblIdpAuthManagerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="XblIdpAuthManager" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(XblIdpAuthManager).GUID, Is.EqualTo(CLSID_XblIdpAuthManager));
        }

        /// <summary>Validates that the <see cref="XblIdpAuthManager" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XblIdpAuthManager>(), Is.EqualTo(sizeof(XblIdpAuthManager)));
        }

        /// <summary>Validates that the <see cref="XblIdpAuthManager" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XblIdpAuthManager).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XblIdpAuthManager" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(XblIdpAuthManager), Is.EqualTo(1));
        }
    }
}
