// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AppCatalogsRequestBuilder.
    /// </summary>
    public partial class AppCatalogsRequestBuilder : EntityRequestBuilder, IAppCatalogsRequestBuilder
    {

        /// <summary>
        /// Constructs a new AppCatalogsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AppCatalogsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAppCatalogsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAppCatalogsRequest Request(IEnumerable<Option> options)
        {
            return new AppCatalogsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for TeamsApps.
        /// </summary>
        /// <returns>The <see cref="IAppCatalogsTeamsAppsCollectionRequestBuilder"/>.</returns>
        public IAppCatalogsTeamsAppsCollectionRequestBuilder TeamsApps
        {
            get
            {
                return new AppCatalogsTeamsAppsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("teamsApps"), this.Client);
            }
        }
    
    }
}
