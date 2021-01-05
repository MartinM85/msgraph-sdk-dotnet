// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsFirewallNetworkProfile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WindowsFirewallNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsFirewallNetworkProfile"/> class.
        /// </summary>
        public WindowsFirewallNetworkProfile()
        {
            this.ODataType = "microsoft.graph.windowsFirewallNetworkProfile";
        }

        /// <summary>
        /// Gets or sets authorizedApplicationRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge authorized application rules from group policy with those from local store instead of ignoring the local store rules. When AuthorizedApplicationRulesFromGroupPolicyNotMerged and AuthorizedApplicationRulesFromGroupPolicyMerged are both true, AuthorizedApplicationRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authorizedApplicationRulesFromGroupPolicyMerged", Required = Newtonsoft.Json.Required.Default)]
        public bool? AuthorizedApplicationRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets connectionSecurityRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge connection security rules from group policy with those from local store instead of ignoring the local store rules. When ConnectionSecurityRulesFromGroupPolicyNotMerged and ConnectionSecurityRulesFromGroupPolicyMerged are both true, ConnectionSecurityRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionSecurityRulesFromGroupPolicyMerged", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectionSecurityRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets firewallEnabled.
        /// Configures the host device to allow or block the firewall and advanced security enforcement for the network profile. Possible values are: notConfigured, blocked, allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallEnabled", Required = Newtonsoft.Json.Required.Default)]
        public StateManagementSetting? FirewallEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets globalPortRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge global port rules from group policy with those from local store instead of ignoring the local store rules. When GlobalPortRulesFromGroupPolicyNotMerged and GlobalPortRulesFromGroupPolicyMerged are both true, GlobalPortRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "globalPortRulesFromGroupPolicyMerged", Required = Newtonsoft.Json.Required.Default)]
        public bool? GlobalPortRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets inboundConnectionsBlocked.
        /// Configures the firewall to block all incoming connections by default. When InboundConnectionsRequired and InboundConnectionsBlocked are both true, InboundConnectionsBlocked takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inboundConnectionsBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? InboundConnectionsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets inboundNotificationsBlocked.
        /// Prevents the firewall from displaying notifications when an application is blocked from listening on a port. When InboundNotificationsRequired and InboundNotificationsBlocked are both true, InboundNotificationsBlocked takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inboundNotificationsBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? InboundNotificationsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets incomingTrafficBlocked.
        /// Configures the firewall to block all incoming traffic regardless of other policy settings. When IncomingTrafficRequired and IncomingTrafficBlocked are both true, IncomingTrafficBlocked takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "incomingTrafficBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? IncomingTrafficBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets outboundConnectionsBlocked.
        /// Configures the firewall to block all outgoing connections by default. When OutboundConnectionsRequired and OutboundConnectionsBlocked are both true, OutboundConnectionsBlocked takes priority. This setting will get applied to Windows releases version 1809 and above.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outboundConnectionsBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? OutboundConnectionsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets policyRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge Firewall Rule policies from group policy with those from local store instead of ignoring the local store rules. When PolicyRulesFromGroupPolicyNotMerged and PolicyRulesFromGroupPolicyMerged are both true, PolicyRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyRulesFromGroupPolicyMerged", Required = Newtonsoft.Json.Required.Default)]
        public bool? PolicyRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets securedPacketExemptionAllowed.
        /// Configures the firewall to allow the host computer to respond to unsolicited network traffic of that traffic is secured by IPSec even when stealthModeBlocked is set to true. When SecuredPacketExemptionBlocked and SecuredPacketExemptionAllowed are both true, SecuredPacketExemptionAllowed takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securedPacketExemptionAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecuredPacketExemptionAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets stealthModeBlocked.
        /// Prevent the server from operating in stealth mode. When StealthModeRequired and StealthModeBlocked are both true, StealthModeBlocked takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "stealthModeBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? StealthModeBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets unicastResponsesToMulticastBroadcastsBlocked.
        /// Configures the firewall to block unicast responses to multicast broadcast traffic. When UnicastResponsesToMulticastBroadcastsRequired and UnicastResponsesToMulticastBroadcastsBlocked are both true, UnicastResponsesToMulticastBroadcastsBlocked takes priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unicastResponsesToMulticastBroadcastsBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? UnicastResponsesToMulticastBroadcastsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
