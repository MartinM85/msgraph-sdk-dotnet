// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// A complex type to store registry rule data for a Win32 LOB app.
    /// </summary>
    public class Win32LobAppRegistryRule : Microsoft.Graph.Models.Win32LobAppRule, IParsable
    {
        /// <summary>A value indicating whether to search the 32-bit registry on 64-bit systems.</summary>
        public bool? Check32BitOn64System
        {
            get { return BackingStore?.Get<bool?>("check32BitOn64System"); }
            set { BackingStore?.Set("check32BitOn64System", value); }
        }
        /// <summary>The registry comparison value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComparisonValue
        {
            get { return BackingStore?.Get<string?>("comparisonValue"); }
            set { BackingStore?.Set("comparisonValue", value); }
        }
#nullable restore
#else
        public string ComparisonValue
        {
            get { return BackingStore?.Get<string>("comparisonValue"); }
            set { BackingStore?.Set("comparisonValue", value); }
        }
#endif
        /// <summary>The full path of the registry entry containing the value to detect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyPath
        {
            get { return BackingStore?.Get<string?>("keyPath"); }
            set { BackingStore?.Set("keyPath", value); }
        }
#nullable restore
#else
        public string KeyPath
        {
            get { return BackingStore?.Get<string>("keyPath"); }
            set { BackingStore?.Set("keyPath", value); }
        }
#endif
        /// <summary>A list of possible operations for rules used to make determinations about an application based on registry keys or values. Unless noted, the values can be used with either detection or requirement rules.</summary>
        public Microsoft.Graph.Models.Win32LobAppRegistryRuleOperationType? OperationType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Win32LobAppRegistryRuleOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>Contains properties for detection operator.</summary>
        public Microsoft.Graph.Models.Win32LobAppRuleOperator? Operator
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Win32LobAppRuleOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>The name of the registry value to detect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueName
        {
            get { return BackingStore?.Get<string?>("valueName"); }
            set { BackingStore?.Set("valueName", value); }
        }
#nullable restore
#else
        public string ValueName
        {
            get { return BackingStore?.Get<string>("valueName"); }
            set { BackingStore?.Set("valueName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Win32LobAppRegistryRule"/> and sets the default values.
        /// </summary>
        public Win32LobAppRegistryRule() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppRegistryRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Win32LobAppRegistryRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Win32LobAppRegistryRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Win32LobAppRegistryRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                { "comparisonValue", n => { ComparisonValue = n.GetStringValue(); } },
                { "keyPath", n => { KeyPath = n.GetStringValue(); } },
                { "operationType", n => { OperationType = n.GetEnumValue<Microsoft.Graph.Models.Win32LobAppRegistryRuleOperationType>(); } },
                { "operator", n => { Operator = n.GetEnumValue<Microsoft.Graph.Models.Win32LobAppRuleOperator>(); } },
                { "valueName", n => { ValueName = n.GetStringValue(); } },
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
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteStringValue("comparisonValue", ComparisonValue);
            writer.WriteStringValue("keyPath", KeyPath);
            writer.WriteEnumValue<Microsoft.Graph.Models.Win32LobAppRegistryRuleOperationType>("operationType", OperationType);
            writer.WriteEnumValue<Microsoft.Graph.Models.Win32LobAppRuleOperator>("operator", Operator);
            writer.WriteStringValue("valueName", ValueName);
        }
    }
}
