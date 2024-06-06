// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class CallTranscript : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The content of the transcript. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content
        {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content
        {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>Date and time at which the transcript was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The unique identifier of the online meeting related to this transcript. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MeetingId
        {
            get { return BackingStore?.Get<string?>("meetingId"); }
            set { BackingStore?.Set("meetingId", value); }
        }
#nullable restore
#else
        public string MeetingId
        {
            get { return BackingStore?.Get<string>("meetingId"); }
            set { BackingStore?.Set("meetingId", value); }
        }
#endif
        /// <summary>The identity information of the organizer of the onlineMeeting related to this transcript. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IdentitySet? MeetingOrganizer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet?>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IdentitySet MeetingOrganizer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IdentitySet>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#endif
        /// <summary>The time-aligned metadata of the utterances in the transcript. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? MetadataContent
        {
            get { return BackingStore?.Get<byte[]?>("metadataContent"); }
            set { BackingStore?.Set("metadataContent", value); }
        }
#nullable restore
#else
        public byte[] MetadataContent
        {
            get { return BackingStore?.Get<byte[]>("metadataContent"); }
            set { BackingStore?.Set("metadataContent", value); }
        }
#endif
        /// <summary>The URL that can be used to access the content of the transcript. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TranscriptContentUrl
        {
            get { return BackingStore?.Get<string?>("transcriptContentUrl"); }
            set { BackingStore?.Set("transcriptContentUrl", value); }
        }
#nullable restore
#else
        public string TranscriptContentUrl
        {
            get { return BackingStore?.Get<string>("transcriptContentUrl"); }
            set { BackingStore?.Set("transcriptContentUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.CallTranscript"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.CallTranscript CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.CallTranscript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "content", n => { Content = n.GetByteArrayValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "meetingId", n => { MeetingId = n.GetStringValue(); } },
                { "meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<Microsoft.Graph.Models.IdentitySet>(Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "metadataContent", n => { MetadataContent = n.GetByteArrayValue(); } },
                { "transcriptContentUrl", n => { TranscriptContentUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("meetingId", MeetingId);
            writer.WriteObjectValue<Microsoft.Graph.Models.IdentitySet>("meetingOrganizer", MeetingOrganizer);
            writer.WriteByteArrayValue("metadataContent", MetadataContent);
            writer.WriteStringValue("transcriptContentUrl", TranscriptContentUrl);
        }
    }
}
