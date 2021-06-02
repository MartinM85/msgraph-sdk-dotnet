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
    /// The type Device And App Management Role Assignment.
    /// </summary>
    public partial class DeviceAndAppManagementRoleAssignment : RoleAssignment
    {
    
        ///<summary>
        /// The DeviceAndAppManagementRoleAssignment constructor
        ///</summary>
        public DeviceAndAppManagementRoleAssignment()
        {
            this.ODataType = "microsoft.graph.deviceAndAppManagementRoleAssignment";
        }

        /// <summary>
        /// Gets or sets members.
        /// The list of ids of role member security groups. These are IDs from Azure Active Directory.
        /// </summary>
        [JsonPropertyName("members")]
        public IEnumerable<string> Members { get; set; }
    
    }
}

