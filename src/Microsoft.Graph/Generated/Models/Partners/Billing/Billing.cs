// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Partners.Billing
{
    #pragma warning disable CS1591
    public class Billing : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents metadata for the exported data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Partners.Billing.Manifest>? Manifests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Partners.Billing.Manifest>?>("manifests"); }
            set { BackingStore?.Set("manifests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Partners.Billing.Manifest> Manifests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Partners.Billing.Manifest>>("manifests"); }
            set { BackingStore?.Set("manifests", value); }
        }
#endif
        /// <summary>Represents an operation to export the billing data of a partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Partners.Billing.Operation>? Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Partners.Billing.Operation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Partners.Billing.Operation> Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Partners.Billing.Operation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The reconciliation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Partners.Billing.BillingReconciliation? Reconciliation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Partners.Billing.BillingReconciliation?>("reconciliation"); }
            set { BackingStore?.Set("reconciliation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Partners.Billing.BillingReconciliation Reconciliation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Partners.Billing.BillingReconciliation>("reconciliation"); }
            set { BackingStore?.Set("reconciliation", value); }
        }
#endif
        /// <summary>The usage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Partners.Billing.AzureUsage? Usage
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Partners.Billing.AzureUsage?>("usage"); }
            set { BackingStore?.Set("usage", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Partners.Billing.AzureUsage Usage
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Partners.Billing.AzureUsage>("usage"); }
            set { BackingStore?.Set("usage", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Partners.Billing.Billing"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Partners.Billing.Billing CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Partners.Billing.Billing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "manifests", n => { Manifests = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Partners.Billing.Manifest>(Microsoft.Graph.Models.Partners.Billing.Manifest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Partners.Billing.Operation>(Microsoft.Graph.Models.Partners.Billing.Operation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "reconciliation", n => { Reconciliation = n.GetObjectValue<Microsoft.Graph.Models.Partners.Billing.BillingReconciliation>(Microsoft.Graph.Models.Partners.Billing.BillingReconciliation.CreateFromDiscriminatorValue); } },
                { "usage", n => { Usage = n.GetObjectValue<Microsoft.Graph.Models.Partners.Billing.AzureUsage>(Microsoft.Graph.Models.Partners.Billing.AzureUsage.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Partners.Billing.Manifest>("manifests", Manifests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Partners.Billing.Operation>("operations", Operations);
            writer.WriteObjectValue<Microsoft.Graph.Models.Partners.Billing.BillingReconciliation>("reconciliation", Reconciliation);
            writer.WriteObjectValue<Microsoft.Graph.Models.Partners.Billing.AzureUsage>("usage", Usage);
        }
    }
}
