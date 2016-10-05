// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IContactFolderMultiValueExtendedPropertiesCollectionRequestBuilder.
    /// </summary>
    public partial interface IContactFolderMultiValueExtendedPropertiesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IContactFolderMultiValueExtendedPropertiesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IContactFolderMultiValueExtendedPropertiesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMultiValueLegacyExtendedPropertyRequestBuilder"/> for the specified MultiValueLegacyExtendedProperty.
        /// </summary>
        /// <param name="id">The ID for the MultiValueLegacyExtendedProperty.</param>
        /// <returns>The <see cref="IMultiValueLegacyExtendedPropertyRequestBuilder"/>.</returns>
        IMultiValueLegacyExtendedPropertyRequestBuilder this[string id] { get; }

        
    }
}
