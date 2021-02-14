// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IndexerOption
    {
        IndexerOption_UseIndexerWhenAvailable = 0,
        IndexerOption_OnlyUseIndexer = 1,
        IndexerOption_DoNotUseIndexer = 2,
        IndexerOption_OnlyUseIndexerAndOptimizeForIndexedProperties = 3,
    }
}
