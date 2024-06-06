// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Search
{
    #pragma warning disable CS1591
    public class IdentitySet : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Search.Identity? Application
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Search.Identity?>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Search.Identity Application
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Search.Identity>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The device property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Search.Identity? Device
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Search.Identity?>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Search.Identity Device
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Search.Identity>("device"); }
            set { BackingStore?.Set("device", value); }
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
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Search.Identity? User
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Search.Identity?>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Search.Identity User
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Search.Identity>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Search.IdentitySet"/> and sets the default values.
        /// </summary>
        public IdentitySet()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Search.IdentitySet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.Search.IdentitySet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Search.IdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "application", n => { Application = n.GetObjectValue<Microsoft.Graph.Models.Search.Identity>(Microsoft.Graph.Models.Search.Identity.CreateFromDiscriminatorValue); } },
                { "device", n => { Device = n.GetObjectValue<Microsoft.Graph.Models.Search.Identity>(Microsoft.Graph.Models.Search.Identity.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "user", n => { User = n.GetObjectValue<Microsoft.Graph.Models.Search.Identity>(Microsoft.Graph.Models.Search.Identity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.Search.Identity>("application", Application);
            writer.WriteObjectValue<Microsoft.Graph.Models.Search.Identity>("device", Device);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Models.Search.Identity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
