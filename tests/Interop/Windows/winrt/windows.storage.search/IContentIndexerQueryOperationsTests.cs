// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IContentIndexerQueryOperations" /> struct.</summary>
    public static unsafe class IContentIndexerQueryOperationsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IContentIndexerQueryOperations" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IContentIndexerQueryOperations).GUID, Is.EqualTo(IID_IContentIndexerQueryOperations));
        }

        /// <summary>Validates that the <see cref="IContentIndexerQueryOperations" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IContentIndexerQueryOperations>(), Is.EqualTo(sizeof(IContentIndexerQueryOperations)));
        }

        /// <summary>Validates that the <see cref="IContentIndexerQueryOperations" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IContentIndexerQueryOperations).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IContentIndexerQueryOperations" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IContentIndexerQueryOperations), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IContentIndexerQueryOperations), Is.EqualTo(4));
            }
        }
    }
}
