// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.ConvertNamespace
{
    #pragma warning disable CS1591
    public class ConvertPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The fromUnit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FromUnit
        {
            get { return BackingStore?.Get<UntypedNode?>("fromUnit"); }
            set { BackingStore?.Set("fromUnit", value); }
        }
#nullable restore
#else
        public UntypedNode FromUnit
        {
            get { return BackingStore?.Get<UntypedNode>("fromUnit"); }
            set { BackingStore?.Set("fromUnit", value); }
        }
#endif
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Number
        {
            get { return BackingStore?.Get<UntypedNode?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public UntypedNode Number
        {
            get { return BackingStore?.Get<UntypedNode>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The toUnit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ToUnit
        {
            get { return BackingStore?.Get<UntypedNode?>("toUnit"); }
            set { BackingStore?.Set("toUnit", value); }
        }
#nullable restore
#else
        public UntypedNode ToUnit
        {
            get { return BackingStore?.Get<UntypedNode>("toUnit"); }
            set { BackingStore?.Set("toUnit", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.ConvertNamespace.ConvertPostRequestBody"/> and sets the default values.
        /// </summary>
        public ConvertPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.ConvertNamespace.ConvertPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.ConvertNamespace.ConvertPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.ConvertNamespace.ConvertPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "fromUnit", n => { FromUnit = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "number", n => { Number = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "toUnit", n => { ToUnit = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("fromUnit", FromUnit);
            writer.WriteObjectValue<UntypedNode>("number", Number);
            writer.WriteObjectValue<UntypedNode>("toUnit", ToUnit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
