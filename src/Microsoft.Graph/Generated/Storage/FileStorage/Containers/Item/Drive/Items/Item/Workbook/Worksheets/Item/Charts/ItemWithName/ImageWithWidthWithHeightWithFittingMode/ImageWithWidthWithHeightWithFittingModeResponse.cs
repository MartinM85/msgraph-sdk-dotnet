// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeightWithFittingMode
{
    [Obsolete("This class is obsolete. Use ImageWithWidthWithHeightWithFittingModeGetResponse instead.")]
    #pragma warning disable CS1591
    public class ImageWithWidthWithHeightWithFittingModeResponse : Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeightWithFittingMode.ImageWithWidthWithHeightWithFittingModeResponse();
        }
    }
}
