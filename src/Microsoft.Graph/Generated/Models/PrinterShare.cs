// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class PrinterShare : Microsoft.Graph.Models.PrinterBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If true, all users and groups will be granted access to this printer share. This supersedes the allow lists defined by the allowedUsers and allowedGroups navigation properties.</summary>
        public bool? AllowAllUsers
        {
            get { return BackingStore?.Get<bool?>("allowAllUsers"); }
            set { BackingStore?.Set("allowAllUsers", value); }
        }
        /// <summary>The groups whose users have access to print using the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Group>? AllowedGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Group>?>("allowedGroups"); }
            set { BackingStore?.Set("allowedGroups", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Group> AllowedGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Group>>("allowedGroups"); }
            set { BackingStore?.Set("allowedGroups", value); }
        }
#endif
        /// <summary>The users who have access to print using the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.User>? AllowedUsers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.User>?>("allowedUsers"); }
            set { BackingStore?.Set("allowedUsers", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.User> AllowedUsers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.User>>("allowedUsers"); }
            set { BackingStore?.Set("allowedUsers", value); }
        }
#endif
        /// <summary>The DateTimeOffset when the printer share was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The printer that this printer share is related to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Printer? Printer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Printer?>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Printer Printer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Printer>("printer"); }
            set { BackingStore?.Set("printer", value); }
        }
#endif
        /// <summary>Additional data for a printer share as viewed by the signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PrinterShareViewpoint? ViewPoint
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrinterShareViewpoint?>("viewPoint"); }
            set { BackingStore?.Set("viewPoint", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PrinterShareViewpoint ViewPoint
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrinterShareViewpoint>("viewPoint"); }
            set { BackingStore?.Set("viewPoint", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.PrinterShare"/> and sets the default values.
        /// </summary>
        public PrinterShare() : base()
        {
            OdataType = "#microsoft.graph.printerShare";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.PrinterShare"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.PrinterShare CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.PrinterShare();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowAllUsers", n => { AllowAllUsers = n.GetBoolValue(); } },
                { "allowedGroups", n => { AllowedGroups = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Group>(Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue)?.ToList(); } },
                { "allowedUsers", n => { AllowedUsers = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.User>(Microsoft.Graph.Models.User.CreateFromDiscriminatorValue)?.ToList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "printer", n => { Printer = n.GetObjectValue<Microsoft.Graph.Models.Printer>(Microsoft.Graph.Models.Printer.CreateFromDiscriminatorValue); } },
                { "viewPoint", n => { ViewPoint = n.GetObjectValue<Microsoft.Graph.Models.PrinterShareViewpoint>(Microsoft.Graph.Models.PrinterShareViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("allowAllUsers", AllowAllUsers);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Group>("allowedGroups", AllowedGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.User>("allowedUsers", AllowedUsers);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Models.Printer>("printer", Printer);
            writer.WriteObjectValue<Microsoft.Graph.Models.PrinterShareViewpoint>("viewPoint", ViewPoint);
        }
    }
}
