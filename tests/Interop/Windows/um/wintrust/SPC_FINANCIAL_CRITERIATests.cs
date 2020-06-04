// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SPC_FINANCIAL_CRITERIA" /> struct.</summary>
    public static unsafe class SPC_FINANCIAL_CRITERIATests
    {
        /// <summary>Validates that the <see cref="SPC_FINANCIAL_CRITERIA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SPC_FINANCIAL_CRITERIA>(), Is.EqualTo(sizeof(SPC_FINANCIAL_CRITERIA)));
        }

        /// <summary>Validates that the <see cref="SPC_FINANCIAL_CRITERIA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SPC_FINANCIAL_CRITERIA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SPC_FINANCIAL_CRITERIA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SPC_FINANCIAL_CRITERIA), Is.EqualTo(8));
        }
    }
}
