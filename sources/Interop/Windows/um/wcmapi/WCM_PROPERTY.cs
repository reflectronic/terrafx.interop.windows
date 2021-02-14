// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WCM_PROPERTY
    {
        wcm_global_property_domain_policy,
        wcm_global_property_minimize_policy,
        wcm_global_property_roaming_policy,
        wcm_global_property_powermanagement_policy,
        wcm_intf_property_connection_cost,
        wcm_intf_property_dataplan_status,
        wcm_intf_property_hotspot_profile,
    }
}
