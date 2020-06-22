// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFNETSOURCE_STATISTICS_IDS
    {
        MFNETSOURCE_RECVPACKETS_ID = 0,
        MFNETSOURCE_LOSTPACKETS_ID = (MFNETSOURCE_RECVPACKETS_ID + 1),
        MFNETSOURCE_RESENDSREQUESTED_ID = (MFNETSOURCE_LOSTPACKETS_ID + 1),
        MFNETSOURCE_RESENDSRECEIVED_ID = (MFNETSOURCE_RESENDSREQUESTED_ID + 1),
        MFNETSOURCE_RECOVEREDBYECCPACKETS_ID = (MFNETSOURCE_RESENDSRECEIVED_ID + 1),
        MFNETSOURCE_RECOVEREDBYRTXPACKETS_ID = (MFNETSOURCE_RECOVEREDBYECCPACKETS_ID + 1),
        MFNETSOURCE_OUTPACKETS_ID = (MFNETSOURCE_RECOVEREDBYRTXPACKETS_ID + 1),
        MFNETSOURCE_RECVRATE_ID = (MFNETSOURCE_OUTPACKETS_ID + 1),
        MFNETSOURCE_AVGBANDWIDTHBPS_ID = (MFNETSOURCE_RECVRATE_ID + 1),
        MFNETSOURCE_BYTESRECEIVED_ID = (MFNETSOURCE_AVGBANDWIDTHBPS_ID + 1),
        MFNETSOURCE_PROTOCOL_ID = (MFNETSOURCE_BYTESRECEIVED_ID + 1),
        MFNETSOURCE_TRANSPORT_ID = (MFNETSOURCE_PROTOCOL_ID + 1),
        MFNETSOURCE_CACHE_STATE_ID = (MFNETSOURCE_TRANSPORT_ID + 1),
        MFNETSOURCE_LINKBANDWIDTH_ID = (MFNETSOURCE_CACHE_STATE_ID + 1),
        MFNETSOURCE_CONTENTBITRATE_ID = (MFNETSOURCE_LINKBANDWIDTH_ID + 1),
        MFNETSOURCE_SPEEDFACTOR_ID = (MFNETSOURCE_CONTENTBITRATE_ID + 1),
        MFNETSOURCE_BUFFERSIZE_ID = (MFNETSOURCE_SPEEDFACTOR_ID + 1),
        MFNETSOURCE_BUFFERPROGRESS_ID = (MFNETSOURCE_BUFFERSIZE_ID + 1),
        MFNETSOURCE_LASTBWSWITCHTS_ID = (MFNETSOURCE_BUFFERPROGRESS_ID + 1),
        MFNETSOURCE_SEEKRANGESTART_ID = (MFNETSOURCE_LASTBWSWITCHTS_ID + 1),
        MFNETSOURCE_SEEKRANGEEND_ID = (MFNETSOURCE_SEEKRANGESTART_ID + 1),
        MFNETSOURCE_BUFFERINGCOUNT_ID = (MFNETSOURCE_SEEKRANGEEND_ID + 1),
        MFNETSOURCE_INCORRECTLYSIGNEDPACKETS_ID = (MFNETSOURCE_BUFFERINGCOUNT_ID + 1),
        MFNETSOURCE_SIGNEDSESSION_ID = (MFNETSOURCE_INCORRECTLYSIGNEDPACKETS_ID + 1),
        MFNETSOURCE_MAXBITRATE_ID = (MFNETSOURCE_SIGNEDSESSION_ID + 1),
        MFNETSOURCE_RECEPTION_QUALITY_ID = (MFNETSOURCE_MAXBITRATE_ID + 1),
        MFNETSOURCE_RECOVEREDPACKETS_ID = (MFNETSOURCE_RECEPTION_QUALITY_ID + 1),
        MFNETSOURCE_VBR_ID = (MFNETSOURCE_RECOVEREDPACKETS_ID + 1),
        MFNETSOURCE_DOWNLOADPROGRESS_ID = (MFNETSOURCE_VBR_ID + 1),
        MFNETSOURCE_UNPREDEFINEDPROTOCOLNAME_ID = (MFNETSOURCE_DOWNLOADPROGRESS_ID + 1),
    }
}
