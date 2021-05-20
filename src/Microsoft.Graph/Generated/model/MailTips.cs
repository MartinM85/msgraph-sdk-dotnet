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
    /// The type MailTips.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MailTips>))]
    public partial class MailTips
    {

        /// <summary>
        /// Gets or sets automaticReplies.
        /// Mail tips for automatic reply if it has been set up by the recipient.
        /// </summary>
        [JsonPropertyName("automaticReplies")]
        public AutomaticRepliesMailTips AutomaticReplies { get; set; }
    
        /// <summary>
        /// Gets or sets customMailTip.
        /// A custom mail tip that can be set on the recipient's mailbox.
        /// </summary>
        [JsonPropertyName("customMailTip")]
        public string CustomMailTip { get; set; }
    
        /// <summary>
        /// Gets or sets deliveryRestricted.
        /// Whether the recipient's mailbox is restricted, for example, accepting messages from only a predefined list of senders, rejecting messages from a predefined list of senders, or accepting messages from only authenticated senders.
        /// </summary>
        [JsonPropertyName("deliveryRestricted")]
        public bool? DeliveryRestricted { get; set; }
    
        /// <summary>
        /// Gets or sets emailAddress.
        /// The email address of the recipient to get mailtips for.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public EmailAddress EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// Errors that occur during the getMailTips action.
        /// </summary>
        [JsonPropertyName("error")]
        public MailTipsError Error { get; set; }
    
        /// <summary>
        /// Gets or sets externalMemberCount.
        /// The number of external members if the recipient is a distribution list.
        /// </summary>
        [JsonPropertyName("externalMemberCount")]
        public Int32? ExternalMemberCount { get; set; }
    
        /// <summary>
        /// Gets or sets isModerated.
        /// Whether sending messages to the recipient requires approval. For example, if the recipient is a large distribution list and a moderator has been set up to approve messages sent to that distribution list, or if sending messages to a recipient requires approval of the recipient's manager.
        /// </summary>
        [JsonPropertyName("isModerated")]
        public bool? IsModerated { get; set; }
    
        /// <summary>
        /// Gets or sets mailboxFull.
        /// The mailbox full status of the recipient.
        /// </summary>
        [JsonPropertyName("mailboxFull")]
        public bool? MailboxFull { get; set; }
    
        /// <summary>
        /// Gets or sets maxMessageSize.
        /// The maximum message size that has been configured for the recipient's organization or mailbox.
        /// </summary>
        [JsonPropertyName("maxMessageSize")]
        public Int32? MaxMessageSize { get; set; }
    
        /// <summary>
        /// Gets or sets recipientScope.
        /// The scope of the recipient. Possible values are: none, internal, external, externalPartner, externalNonParther. For example, an administrator can set another organization to be its 'partner'. The scope is useful if an administrator wants certain mailtips to be accessible to certain scopes. It's also useful to senders to inform them that their message may leave the organization, helping them make the correct decisions about wording, tone and content.
        /// </summary>
        [JsonPropertyName("recipientScope")]
        public RecipientScopeType? RecipientScope { get; set; }
    
        /// <summary>
        /// Gets or sets recipientSuggestions.
        /// Recipients suggested based on previous contexts where they appear in the same message.
        /// </summary>
        [JsonPropertyName("recipientSuggestions")]
        public IEnumerable<Recipient> RecipientSuggestions { get; set; }
    
        /// <summary>
        /// Gets or sets totalMemberCount.
        /// The number of members if the recipient is a distribution list.
        /// </summary>
        [JsonPropertyName("totalMemberCount")]
        public Int32? TotalMemberCount { get; set; }
    
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
