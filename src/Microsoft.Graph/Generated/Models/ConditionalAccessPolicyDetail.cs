// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class ConditionalAccessPolicyDetail : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ConditionalAccessConditionSet? Conditions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConditionalAccessConditionSet?>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ConditionalAccessConditionSet Conditions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConditionalAccessConditionSet>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#endif
        /// <summary>Represents grant controls that must be fulfilled for the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ConditionalAccessGrantControls? GrantControls
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConditionalAccessGrantControls?>("grantControls"); }
            set { BackingStore?.Set("grantControls", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ConditionalAccessGrantControls GrantControls
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConditionalAccessGrantControls>("grantControls"); }
            set { BackingStore?.Set("grantControls", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Represents a complex type of session controls that is enforced after sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ConditionalAccessSessionControls? SessionControls
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConditionalAccessSessionControls?>("sessionControls"); }
            set { BackingStore?.Set("sessionControls", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ConditionalAccessSessionControls SessionControls
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ConditionalAccessSessionControls>("sessionControls"); }
            set { BackingStore?.Set("sessionControls", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.ConditionalAccessPolicyDetail"/> and sets the default values.
        /// </summary>
        public ConditionalAccessPolicyDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ConditionalAccessPolicyDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.ConditionalAccessPolicyDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ConditionalAccessPolicyDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conditions", n => { Conditions = n.GetObjectValue<Microsoft.Graph.Models.ConditionalAccessConditionSet>(Microsoft.Graph.Models.ConditionalAccessConditionSet.CreateFromDiscriminatorValue); } },
                { "grantControls", n => { GrantControls = n.GetObjectValue<Microsoft.Graph.Models.ConditionalAccessGrantControls>(Microsoft.Graph.Models.ConditionalAccessGrantControls.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sessionControls", n => { SessionControls = n.GetObjectValue<Microsoft.Graph.Models.ConditionalAccessSessionControls>(Microsoft.Graph.Models.ConditionalAccessSessionControls.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.ConditionalAccessConditionSet>("conditions", Conditions);
            writer.WriteObjectValue<Microsoft.Graph.Models.ConditionalAccessGrantControls>("grantControls", GrantControls);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Models.ConditionalAccessSessionControls>("sessionControls", SessionControls);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
