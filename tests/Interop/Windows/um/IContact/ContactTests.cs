// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Contact" /> struct.</summary>
    public static unsafe class ContactTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="Contact" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(Contact).GUID, Is.EqualTo(CLSID_Contact));
        }

        /// <summary>Validates that the <see cref="Contact" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<Contact>(), Is.EqualTo(sizeof(Contact)));
        }

        /// <summary>Validates that the <see cref="Contact" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(Contact).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="Contact" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(Contact), Is.EqualTo(1));
        }
    }
}
