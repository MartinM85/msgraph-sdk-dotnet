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
    /// The type ConvertIdResult.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConvertIdResult>))]
    public partial class ConvertIdResult
    {

        /// <summary>
        /// Gets or sets errorDetails.
        /// An error object indicating the reason for the conversion failure. This value is not present if the conversion succeeded.
        /// </summary>
        [JsonPropertyName("errorDetails")]
        public GenericError ErrorDetails { get; set; }
    
        /// <summary>
        /// Gets or sets sourceId.
        /// The identifier that was converted. This value is the original, un-converted identifier.
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Gets or sets targetId.
        /// The converted identifier. This value is not present if the conversion failed.
        /// </summary>
        [JsonPropertyName("targetId")]
        public string TargetId { get; set; }
    
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
