// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IHomeRealmDiscoveryPolicyWithReferenceRequestBuilder"/> for the specified HomeRealmDiscoveryPolicy.
        /// </summary>
        /// <param name="id">The ID for the HomeRealmDiscoveryPolicy.</param>
        /// <returns>The <see cref="IHomeRealmDiscoveryPolicyWithReferenceRequestBuilder"/>.</returns>
        IHomeRealmDiscoveryPolicyWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IApplicationHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IApplicationHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder"/>.</returns>
        IApplicationHomeRealmDiscoveryPoliciesCollectionReferencesRequestBuilder References { get; }

    }
}
