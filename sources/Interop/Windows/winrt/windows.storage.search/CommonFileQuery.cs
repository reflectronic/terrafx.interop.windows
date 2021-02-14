// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CommonFileQuery
    {
        CommonFileQuery_DefaultQuery = 0,
        CommonFileQuery_OrderByName = 1,
        CommonFileQuery_OrderByTitle = 2,
        CommonFileQuery_OrderByMusicProperties = 3,
        CommonFileQuery_OrderBySearchRank = 4,
        CommonFileQuery_OrderByDate = 5,
    }
}
