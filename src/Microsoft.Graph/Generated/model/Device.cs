// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device.
    /// </summary>
    public partial class Device : DirectoryObject
    {
    
        ///<summary>
        /// The Device constructor
        ///</summary>
        public Device()
        {
            this.ODataType = "microsoft.graph.device";
        }
    
        /// <summary>
        /// Gets or sets account enabled.
        /// true if the account is enabled; otherwise, false. default is true.
        /// </summary>
        [JsonPropertyName("accountEnabled")]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets alternative security ids.
        /// For internal use only. Not nullable.
        /// </summary>
        [JsonPropertyName("alternativeSecurityIds")]
        public IEnumerable<AlternativeSecurityId> AlternativeSecurityIds { get; set; }
    
        /// <summary>
        /// Gets or sets approximate last sign in date time.
        /// The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("approximateLastSignInDateTime")]
        public DateTimeOffset? ApproximateLastSignInDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets compliance expiration date time.
        /// The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("complianceExpirationDateTime")]
        public DateTimeOffset? ComplianceExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Identifier set by Azure Device Registration Service at the time of registration.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device metadata.
        /// For internal use only. Set to null.
        /// </summary>
        [JsonPropertyName("deviceMetadata")]
        public string DeviceMetadata { get; set; }
    
        /// <summary>
        /// Gets or sets device version.
        /// For internal use only.
        /// </summary>
        [JsonPropertyName("deviceVersion")]
        public Int32? DeviceVersion { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the device. Required.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is compliant.
        /// true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
        /// </summary>
        [JsonPropertyName("isCompliant")]
        public bool? IsCompliant { get; set; }
    
        /// <summary>
        /// Gets or sets is managed.
        /// true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
        /// </summary>
        [JsonPropertyName("isManaged")]
        public bool? IsManaged { get; set; }
    
        /// <summary>
        /// Gets or sets mdm app id.
        /// Application identifier used to register device into MDM. Read-only. Supports $filter.
        /// </summary>
        [JsonPropertyName("mdmAppId")]
        public string MdmAppId { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesLastSyncDateTime")]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesSyncEnabled")]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// The type of operating system on the device. Required.
        /// </summary>
        [JsonPropertyName("operatingSystem")]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets operating system version.
        /// Operating system version of the device. Required.
        /// </summary>
        [JsonPropertyName("operatingSystemVersion")]
        public string OperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets physical ids.
        /// For internal use only. Not nullable.
        /// </summary>
        [JsonPropertyName("physicalIds")]
        public IEnumerable<string> PhysicalIds { get; set; }
    
        /// <summary>
        /// Gets or sets profile type.
        /// The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.
        /// </summary>
        [JsonPropertyName("profileType")]
        public string ProfileType { get; set; }
    
        /// <summary>
        /// Gets or sets system labels.
        /// List of labels applied to the device by the system.
        /// </summary>
        [JsonPropertyName("systemLabels")]
        public IEnumerable<string> SystemLabels { get; set; }
    
        /// <summary>
        /// Gets or sets trust type.
        /// Type of trust for the joined device. Read-only. Possible values: Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory
        /// </summary>
        [JsonPropertyName("trustType")]
        public string TrustType { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// Groups that this device is a member of. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("memberOf")]
        public IDeviceMemberOfCollectionWithReferencesPage MemberOf { get; set; }

        /// <summary>
        /// Gets or sets memberOfNextLink.
        /// </summary>
        [JsonPropertyName("memberOf@odata.nextLink")]
        public string MemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets registered owners.
        /// The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("registeredOwners")]
        public IDeviceRegisteredOwnersCollectionWithReferencesPage RegisteredOwners { get; set; }

        /// <summary>
        /// Gets or sets registeredOwnersNextLink.
        /// </summary>
        [JsonPropertyName("registeredOwners@odata.nextLink")]
        public string RegisteredOwnersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets registered users.
        /// Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("registeredUsers")]
        public IDeviceRegisteredUsersCollectionWithReferencesPage RegisteredUsers { get; set; }

        /// <summary>
        /// Gets or sets registeredUsersNextLink.
        /// </summary>
        [JsonPropertyName("registeredUsers@odata.nextLink")]
        public string RegisteredUsersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// Groups that this device is a member of. This operation is transitive.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf")]
        public IDeviceTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }

        /// <summary>
        /// Gets or sets transitiveMemberOfNextLink.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf@odata.nextLink")]
        public string TransitiveMemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the device. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IDeviceExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        public string ExtensionsNextLink { get; set; }
    
    }
}

