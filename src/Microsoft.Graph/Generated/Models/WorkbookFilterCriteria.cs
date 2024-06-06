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
    public class WorkbookFilterCriteria : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The color applied to the cell.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color
        {
            get { return BackingStore?.Get<string?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#nullable restore
#else
        public string Color
        {
            get { return BackingStore?.Get<string>("color"); }
            set { BackingStore?.Set("color", value); }
        }
#endif
        /// <summary>A custom criterion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criterion1
        {
            get { return BackingStore?.Get<string?>("criterion1"); }
            set { BackingStore?.Set("criterion1", value); }
        }
#nullable restore
#else
        public string Criterion1
        {
            get { return BackingStore?.Get<string>("criterion1"); }
            set { BackingStore?.Set("criterion1", value); }
        }
#endif
        /// <summary>A custom criterion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criterion2
        {
            get { return BackingStore?.Get<string?>("criterion2"); }
            set { BackingStore?.Set("criterion2", value); }
        }
#nullable restore
#else
        public string Criterion2
        {
            get { return BackingStore?.Get<string>("criterion2"); }
            set { BackingStore?.Set("criterion2", value); }
        }
#endif
        /// <summary>A dynamic formula specified in a custom filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DynamicCriteria
        {
            get { return BackingStore?.Get<string?>("dynamicCriteria"); }
            set { BackingStore?.Set("dynamicCriteria", value); }
        }
#nullable restore
#else
        public string DynamicCriteria
        {
            get { return BackingStore?.Get<string>("dynamicCriteria"); }
            set { BackingStore?.Set("dynamicCriteria", value); }
        }
#endif
        /// <summary>Indicates whether a filter is applied to a column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilterOn
        {
            get { return BackingStore?.Get<string?>("filterOn"); }
            set { BackingStore?.Set("filterOn", value); }
        }
#nullable restore
#else
        public string FilterOn
        {
            get { return BackingStore?.Get<string>("filterOn"); }
            set { BackingStore?.Set("filterOn", value); }
        }
#endif
        /// <summary>An icon applied to a cell via conditional formatting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookIcon? Icon
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookIcon?>("icon"); }
            set { BackingStore?.Set("icon", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookIcon Icon
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookIcon>("icon"); }
            set { BackingStore?.Set("icon", value); }
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
        /// <summary>An operator in a cell; for example, =, &gt;, &lt;, &lt;=, or &lt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operator
        {
            get { return BackingStore?.Get<string?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#nullable restore
#else
        public string Operator
        {
            get { return BackingStore?.Get<string>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
#endif
        /// <summary>The values that appear in the cell.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Values
        {
            get { return BackingStore?.Get<UntypedNode?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public UntypedNode Values
        {
            get { return BackingStore?.Get<UntypedNode>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.WorkbookFilterCriteria"/> and sets the default values.
        /// </summary>
        public WorkbookFilterCriteria()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.WorkbookFilterCriteria"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.WorkbookFilterCriteria CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.WorkbookFilterCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "color", n => { Color = n.GetStringValue(); } },
                { "criterion1", n => { Criterion1 = n.GetStringValue(); } },
                { "criterion2", n => { Criterion2 = n.GetStringValue(); } },
                { "dynamicCriteria", n => { DynamicCriteria = n.GetStringValue(); } },
                { "filterOn", n => { FilterOn = n.GetStringValue(); } },
                { "icon", n => { Icon = n.GetObjectValue<Microsoft.Graph.Models.WorkbookIcon>(Microsoft.Graph.Models.WorkbookIcon.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "operator", n => { Operator = n.GetStringValue(); } },
                { "values", n => { Values = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("criterion1", Criterion1);
            writer.WriteStringValue("criterion2", Criterion2);
            writer.WriteStringValue("dynamicCriteria", DynamicCriteria);
            writer.WriteStringValue("filterOn", FilterOn);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookIcon>("icon", Icon);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operator", Operator);
            writer.WriteObjectValue<UntypedNode>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
