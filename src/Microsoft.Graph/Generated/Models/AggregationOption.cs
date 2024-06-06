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
    public class AggregationOption : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The bucketDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.BucketAggregationDefinition? BucketDefinition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.BucketAggregationDefinition?>("bucketDefinition"); }
            set { BackingStore?.Set("bucketDefinition", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.BucketAggregationDefinition BucketDefinition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.BucketAggregationDefinition>("bucketDefinition"); }
            set { BackingStore?.Set("bucketDefinition", value); }
        }
#endif
        /// <summary>Computes aggregation on the field while the field exists in the current entity type. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Field
        {
            get { return BackingStore?.Get<string?>("field"); }
            set { BackingStore?.Set("field", value); }
        }
#nullable restore
#else
        public string Field
        {
            get { return BackingStore?.Get<string>("field"); }
            set { BackingStore?.Set("field", value); }
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
        /// <summary>The number of searchBucket resources to be returned. This isn&apos;t required when the range is provided manually in the search request. The minimum accepted size is 1, and the maximum is 65535. Optional.</summary>
        public int? Size
        {
            get { return BackingStore?.Get<int?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.AggregationOption"/> and sets the default values.
        /// </summary>
        public AggregationOption()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.AggregationOption"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.AggregationOption CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.AggregationOption();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bucketDefinition", n => { BucketDefinition = n.GetObjectValue<Microsoft.Graph.Models.BucketAggregationDefinition>(Microsoft.Graph.Models.BucketAggregationDefinition.CreateFromDiscriminatorValue); } },
                { "field", n => { Field = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "size", n => { Size = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.BucketAggregationDefinition>("bucketDefinition", BucketDefinition);
            writer.WriteStringValue("field", Field);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("size", Size);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
