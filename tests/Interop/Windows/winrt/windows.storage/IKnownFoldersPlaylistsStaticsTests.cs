// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IKnownFoldersPlaylistsStatics" /> struct.</summary>
    public static unsafe class IKnownFoldersPlaylistsStaticsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IKnownFoldersPlaylistsStatics" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IKnownFoldersPlaylistsStatics).GUID, Is.EqualTo(IID_IKnownFoldersPlaylistsStatics));
        }

        /// <summary>Validates that the <see cref="IKnownFoldersPlaylistsStatics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IKnownFoldersPlaylistsStatics>(), Is.EqualTo(sizeof(IKnownFoldersPlaylistsStatics)));
        }

        /// <summary>Validates that the <see cref="IKnownFoldersPlaylistsStatics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IKnownFoldersPlaylistsStatics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IKnownFoldersPlaylistsStatics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IKnownFoldersPlaylistsStatics), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IKnownFoldersPlaylistsStatics), Is.EqualTo(4));
            }
        }
    }
}
