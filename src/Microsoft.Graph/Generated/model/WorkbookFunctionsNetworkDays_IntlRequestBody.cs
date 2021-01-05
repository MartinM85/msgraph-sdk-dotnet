// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsNetworkDays_IntlRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsNetworkDays_IntlRequestBody
    {
    
        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDate", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endDate", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken EndDate { get; set; }
    
        /// <summary>
        /// Gets or sets Weekend.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "weekend", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Weekend { get; set; }
    
        /// <summary>
        /// Gets or sets Holidays.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "holidays", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Holidays { get; set; }
    
    }
}
