// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="COMDLG_FILTERSPEC" /> struct.</summary>
    public static unsafe class COMDLG_FILTERSPECTests
    {
        /// <summary>Validates that the <see cref="COMDLG_FILTERSPEC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<COMDLG_FILTERSPEC>(), Is.EqualTo(sizeof(COMDLG_FILTERSPEC)));
        }

        /// <summary>Validates that the <see cref="COMDLG_FILTERSPEC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(COMDLG_FILTERSPEC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="COMDLG_FILTERSPEC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(COMDLG_FILTERSPEC), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(COMDLG_FILTERSPEC), Is.EqualTo(8));
            }
        }
    }
}
