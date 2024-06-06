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
    public class TeamsAppPermissionSet : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>A collection of resource-specific permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.TeamsAppResourceSpecificPermission>? ResourceSpecificPermissions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.TeamsAppResourceSpecificPermission>?>("resourceSpecificPermissions"); }
            set { BackingStore?.Set("resourceSpecificPermissions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.TeamsAppResourceSpecificPermission> ResourceSpecificPermissions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.TeamsAppResourceSpecificPermission>>("resourceSpecificPermissions"); }
            set { BackingStore?.Set("resourceSpecificPermissions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.TeamsAppPermissionSet"/> and sets the default values.
        /// </summary>
        public TeamsAppPermissionSet()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.TeamsAppPermissionSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.TeamsAppPermissionSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.TeamsAppPermissionSet();
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
                { "resourceSpecificPermissions", n => { ResourceSpecificPermissions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.TeamsAppResourceSpecificPermission>(Microsoft.Graph.Models.TeamsAppResourceSpecificPermission.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.TeamsAppResourceSpecificPermission>("resourceSpecificPermissions", ResourceSpecificPermissions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
