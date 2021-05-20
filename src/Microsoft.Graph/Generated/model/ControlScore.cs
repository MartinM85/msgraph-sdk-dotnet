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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ControlScore.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ControlScore>))]
    public partial class ControlScore
    {

        /// <summary>
        /// Gets or sets controlCategory.
        /// Control action category (Identity, Data, Device, Apps, Infrastructure).
        /// </summary>
        [JsonPropertyName("controlCategory")]
        public string ControlCategory { get; set; }
    
        /// <summary>
        /// Gets or sets controlName.
        /// Control unique name.
        /// </summary>
        [JsonPropertyName("controlName")]
        public string ControlName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the control.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets score.
        /// Tenant achieved score for the control (it varies day by day depending on tenant operations on the control).
        /// </summary>
        [JsonPropertyName("score")]
        public double? Score { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
