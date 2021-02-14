// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum EC_SUBSCRIPTION_PROPERTY_ID
    {
        EcSubscriptionEnabled = 0,
        EcSubscriptionEventSources,
        EcSubscriptionEventSourceAddress,
        EcSubscriptionEventSourceEnabled,
        EcSubscriptionEventSourceUserName,
        EcSubscriptionEventSourcePassword,
        EcSubscriptionDescription,
        EcSubscriptionURI,
        EcSubscriptionConfigurationMode,
        EcSubscriptionExpires,
        EcSubscriptionQuery,
        EcSubscriptionTransportName,
        EcSubscriptionTransportPort,
        EcSubscriptionDeliveryMode,
        EcSubscriptionDeliveryMaxItems,
        EcSubscriptionDeliveryMaxLatencyTime,
        EcSubscriptionHeartbeatInterval,
        EcSubscriptionLocale,
        EcSubscriptionContentFormat,
        EcSubscriptionLogFile,
        EcSubscriptionPublisherName,
        EcSubscriptionCredentialsType,
        EcSubscriptionCommonUserName,
        EcSubscriptionCommonPassword,
        EcSubscriptionHostName,
        EcSubscriptionReadExistingEvents,
        EcSubscriptionDialect,
        EcSubscriptionType,
        EcSubscriptionAllowedIssuerCAs,
        EcSubscriptionAllowedSubjects,
        EcSubscriptionDeniedSubjects,
        EcSubscriptionAllowedSourceDomainComputers,
        EcSubscriptionPropertyIdEND,
    }
}
