using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class RegistrationEnforcement : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Run campaigns to remind users to set up targeted authentication methods.</summary>
        public Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign AuthenticationMethodsRegistrationCampaign { get; set; }
        /// <summary>
        /// Instantiates a new registrationEnforcement and sets the default values.
        /// </summary>
        public RegistrationEnforcement() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RegistrationEnforcement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegistrationEnforcement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"authenticationMethodsRegistrationCampaign", n => { AuthenticationMethodsRegistrationCampaign = n.GetObjectValue<Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign>(Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.AuthenticationMethodsRegistrationCampaign>("authenticationMethodsRegistrationCampaign", AuthenticationMethodsRegistrationCampaign);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
