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
    /// The type User Activity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserActivity>))]
    public partial class UserActivity : Entity
    {
    
        /// <summary>
        /// Gets or sets activation url.
        /// Required. URL used to launch the activity in the best native experience represented by the appId. Might launch a web-based app if no native app exists.
        /// </summary>
        [JsonPropertyName("activationUrl")]
        public string ActivationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets activity source host.
        /// Required. URL for the domain representing the cross-platform identity mapping for the app. Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center. The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain. For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath. You must have a unique file and domain (or sub domain) per cross-platform app identity. For example, a separate file and domain is needed for Word vs. PowerPoint.
        /// </summary>
        [JsonPropertyName("activitySourceHost")]
        public string ActivitySourceHost { get; set; }
    
        /// <summary>
        /// Gets or sets app activity id.
        /// Required. The unique activity ID in the context of the app - supplied by caller and immutable thereafter.
        /// </summary>
        [JsonPropertyName("appActivityId")]
        public string AppActivityId { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// Optional. Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets content info.
        /// Optional. A custom piece of data - JSON-LD extensible description of content according to schema.org syntax.
        /// </summary>
        [JsonPropertyName("contentInfo")]
        public System.Text.Json.JsonDocument ContentInfo { get; set; }
    
        /// <summary>
        /// Gets or sets content url.
        /// Optional. Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).
        /// </summary>
        [JsonPropertyName("contentUrl")]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Set by the server. DateTime in UTC when the object was created on the server.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Set by the server. DateTime in UTC when the object expired on the server.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets fallback url.
        /// Optional. URL used to launch the activity in a web-based app, if available.
        /// </summary>
        [JsonPropertyName("fallbackUrl")]
        public string FallbackUrl { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Set by the server. DateTime in UTC when the object was modified on the server.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.
        /// </summary>
        [JsonPropertyName("status")]
        public Status? Status { get; set; }
    
        /// <summary>
        /// Gets or sets user timezone.
        /// Optional. The timezone in which the user's device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.
        /// </summary>
        [JsonPropertyName("userTimezone")]
        public string UserTimezone { get; set; }
    
        /// <summary>
        /// Gets or sets visual elements.
        /// Required. The object containing information to render the activity in the UX.
        /// </summary>
        [JsonPropertyName("visualElements")]
        public VisualInfo VisualElements { get; set; }
    
        /// <summary>
        /// Gets or sets history items.
        /// Optional. NavigationProperty/Containment; navigation property to the activity's historyItems.
        /// </summary>
        [JsonPropertyName("historyItems")]
        public IUserActivityHistoryItemsCollectionPage HistoryItems { get; set; }

        /// <summary>
        /// Gets or sets historyItemsNextLink.
        /// </summary>
        [JsonPropertyName("historyItems@odata.nextLink")]
        public string HistoryItemsNextLink { get; set; }
    
    }
}

