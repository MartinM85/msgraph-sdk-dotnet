// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.ExternalConnectors
{
    #pragma warning disable CS1591
    public class PropertyRule : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The operation property</summary>
        public Microsoft.Graph.Models.ExternalConnectors.RuleOperation? Operation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ExternalConnectors.RuleOperation?>("operation"); }
            set { BackingStore?.Set("operation", value); }
        }
        /// <summary>The property from the externalItem schema. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Property
        {
            get { return BackingStore?.Get<string?>("property"); }
            set { BackingStore?.Set("property", value); }
        }
#nullable restore
#else
        public string Property
        {
            get { return BackingStore?.Get<string>("property"); }
            set { BackingStore?.Set("property", value); }
        }
#endif
        /// <summary>A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values
        {
            get { return BackingStore?.Get<List<string>?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public List<string> Values
        {
            get { return BackingStore?.Get<List<string>>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>The valuesJoinedBy property</summary>
        public Microsoft.Graph.Models.BinaryOperator? ValuesJoinedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.BinaryOperator?>("valuesJoinedBy"); }
            set { BackingStore?.Set("valuesJoinedBy", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.ExternalConnectors.PropertyRule"/> and sets the default values.
        /// </summary>
        public PropertyRule()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ExternalConnectors.PropertyRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.ExternalConnectors.PropertyRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ExternalConnectors.PropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "operation", n => { Operation = n.GetEnumValue<Microsoft.Graph.Models.ExternalConnectors.RuleOperation>(); } },
                { "property", n => { Property = n.GetStringValue(); } },
                { "values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "valuesJoinedBy", n => { ValuesJoinedBy = n.GetEnumValue<Microsoft.Graph.Models.BinaryOperator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Models.ExternalConnectors.RuleOperation>("operation", Operation);
            writer.WriteStringValue("property", Property);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
            writer.WriteEnumValue<Microsoft.Graph.Models.BinaryOperator>("valuesJoinedBy", ValuesJoinedBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
