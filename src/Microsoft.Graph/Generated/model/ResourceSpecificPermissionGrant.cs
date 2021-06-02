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
    /// The type Resource Specific Permission Grant.
    /// </summary>
    public partial class ResourceSpecificPermissionGrant : DirectoryObject
    {
    
        ///<summary>
        /// The ResourceSpecificPermissionGrant constructor
        ///</summary>
        public ResourceSpecificPermissionGrant()
        {
            this.ODataType = "microsoft.graph.resourceSpecificPermissionGrant";
        }

        /// <summary>
        /// Gets or sets client app id.
        /// ID of the service principal of the Azure AD app that has been granted access. Read-only.
        /// </summary>
        [JsonPropertyName("clientAppId")]
        public string ClientAppId { get; set; }
    
        /// <summary>
        /// Gets or sets client id.
        /// ID of the Azure AD app that has been granted access. Read-only.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets permission.
        /// The name of the permission. Read-only.
        /// </summary>
        [JsonPropertyName("permission")]
        public string Permission { get; set; }
    
        /// <summary>
        /// Gets or sets permission type.
        /// The type of permission. Possible values are: Application, Delegated. Read-only.
        /// </summary>
        [JsonPropertyName("permissionType")]
        public string PermissionType { get; set; }
    
        /// <summary>
        /// Gets or sets resource app id.
        /// ID of the Azure AD app that is hosting the resource. Read-only.
        /// </summary>
        [JsonPropertyName("resourceAppId")]
        public string ResourceAppId { get; set; }
    
    }
}

