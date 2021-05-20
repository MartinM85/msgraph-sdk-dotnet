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
    /// The type Ios Vpp EBook.
    /// </summary>
    public partial class IosVppEBook : ManagedEBook
    {
    
        ///<summary>
        /// The IosVppEBook constructor
        ///</summary>
        public IosVppEBook()
        {
            this.ODataType = "microsoft.graph.iosVppEBook";
        }
    
        /// <summary>
        /// Gets or sets apple id.
        /// The Apple ID associated with Vpp token.
        /// </summary>
        [JsonPropertyName("appleId")]
        public string AppleId { get; set; }
    
        /// <summary>
        /// Gets or sets genres.
        /// Genres.
        /// </summary>
        [JsonPropertyName("genres")]
        public IEnumerable<string> Genres { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// Language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or sets seller.
        /// Seller.
        /// </summary>
        [JsonPropertyName("seller")]
        public string Seller { get; set; }
    
        /// <summary>
        /// Gets or sets total license count.
        /// Total license count.
        /// </summary>
        [JsonPropertyName("totalLicenseCount")]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets used license count.
        /// Used license count.
        /// </summary>
        [JsonPropertyName("usedLicenseCount")]
        public Int32? UsedLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets vpp organization name.
        /// The Vpp token's organization name.
        /// </summary>
        [JsonPropertyName("vppOrganizationName")]
        public string VppOrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token id.
        /// The Vpp token ID.
        /// </summary>
        [JsonPropertyName("vppTokenId")]
        public Guid? VppTokenId { get; set; }
    
    }
}

