// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationSchoolUsersCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class EducationSchoolUsersCollectionReferencesRequestBuilder : BaseRequestBuilder, IEducationSchoolUsersCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationSchoolUsersCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationSchoolUsersCollectionReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationSchoolUsersCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationSchoolUsersCollectionReferencesRequest Request(IEnumerable<Option> options)
        {
            return new EducationSchoolUsersCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
