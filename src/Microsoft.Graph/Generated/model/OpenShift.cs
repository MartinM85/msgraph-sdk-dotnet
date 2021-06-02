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
    /// The type Open Shift.
    /// </summary>
    public partial class OpenShift : ChangeTrackedEntity
    {
    
        ///<summary>
        /// The OpenShift constructor
        ///</summary>
        public OpenShift()
        {
            this.ODataType = "microsoft.graph.openShift";
        }

        /// <summary>
        /// Gets or sets draft open shift.
        /// An unpublished open shift.
        /// </summary>
        [JsonPropertyName("draftOpenShift")]
        public OpenShiftItem DraftOpenShift { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling group id.
        /// ID for the scheduling group that the open shift belongs to.
        /// </summary>
        [JsonPropertyName("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets shared open shift.
        /// A published open shift.
        /// </summary>
        [JsonPropertyName("sharedOpenShift")]
        public OpenShiftItem SharedOpenShift { get; set; }
    
    }
}

