// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDispatcherQueueShutdownStartingEventArgs" /> struct.</summary>
    public static unsafe class IDispatcherQueueShutdownStartingEventArgsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDispatcherQueueShutdownStartingEventArgs" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDispatcherQueueShutdownStartingEventArgs).GUID, Is.EqualTo(IID_IDispatcherQueueShutdownStartingEventArgs));
        }

        /// <summary>Validates that the <see cref="IDispatcherQueueShutdownStartingEventArgs" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDispatcherQueueShutdownStartingEventArgs>(), Is.EqualTo(sizeof(IDispatcherQueueShutdownStartingEventArgs)));
        }

        /// <summary>Validates that the <see cref="IDispatcherQueueShutdownStartingEventArgs" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDispatcherQueueShutdownStartingEventArgs).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDispatcherQueueShutdownStartingEventArgs" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDispatcherQueueShutdownStartingEventArgs), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDispatcherQueueShutdownStartingEventArgs), Is.EqualTo(4));
            }
        }
    }
}
