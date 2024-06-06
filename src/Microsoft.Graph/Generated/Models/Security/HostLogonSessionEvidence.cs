// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security
{
    #pragma warning disable CS1591
    public class HostLogonSessionEvidence : Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.UserEvidence? Account
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.UserEvidence?>("account"); }
            set { BackingStore?.Set("account", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.UserEvidence Account
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.UserEvidence>("account"); }
            set { BackingStore?.Set("account", value); }
        }
#endif
        /// <summary>The endUtcDateTime property</summary>
        public DateTimeOffset? EndUtcDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endUtcDateTime"); }
            set { BackingStore?.Set("endUtcDateTime", value); }
        }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.DeviceEvidence? Host
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.DeviceEvidence?>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.DeviceEvidence Host
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.DeviceEvidence>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#endif
        /// <summary>The sessionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionId
        {
            get { return BackingStore?.Get<string?>("sessionId"); }
            set { BackingStore?.Set("sessionId", value); }
        }
#nullable restore
#else
        public string SessionId
        {
            get { return BackingStore?.Get<string>("sessionId"); }
            set { BackingStore?.Set("sessionId", value); }
        }
#endif
        /// <summary>The startUtcDateTime property</summary>
        public DateTimeOffset? StartUtcDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startUtcDateTime"); }
            set { BackingStore?.Set("startUtcDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Security.HostLogonSessionEvidence"/> and sets the default values.
        /// </summary>
        public HostLogonSessionEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.hostLogonSessionEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Security.HostLogonSessionEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Security.HostLogonSessionEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Security.HostLogonSessionEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "account", n => { Account = n.GetObjectValue<Microsoft.Graph.Models.Security.UserEvidence>(Microsoft.Graph.Models.Security.UserEvidence.CreateFromDiscriminatorValue); } },
                { "endUtcDateTime", n => { EndUtcDateTime = n.GetDateTimeOffsetValue(); } },
                { "host", n => { Host = n.GetObjectValue<Microsoft.Graph.Models.Security.DeviceEvidence>(Microsoft.Graph.Models.Security.DeviceEvidence.CreateFromDiscriminatorValue); } },
                { "sessionId", n => { SessionId = n.GetStringValue(); } },
                { "startUtcDateTime", n => { StartUtcDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.UserEvidence>("account", Account);
            writer.WriteDateTimeOffsetValue("endUtcDateTime", EndUtcDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.DeviceEvidence>("host", Host);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteDateTimeOffsetValue("startUtcDateTime", StartUtcDateTime);
        }
    }
}
