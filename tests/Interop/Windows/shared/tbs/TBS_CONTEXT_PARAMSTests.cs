// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TBS_CONTEXT_PARAMS" /> struct.</summary>
    public static unsafe class TBS_CONTEXT_PARAMSTests
    {
        /// <summary>Validates that the <see cref="TBS_CONTEXT_PARAMS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TBS_CONTEXT_PARAMS>(), Is.EqualTo(sizeof(TBS_CONTEXT_PARAMS)));
        }

        /// <summary>Validates that the <see cref="TBS_CONTEXT_PARAMS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TBS_CONTEXT_PARAMS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TBS_CONTEXT_PARAMS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TBS_CONTEXT_PARAMS), Is.EqualTo(4));
        }
    }
}
