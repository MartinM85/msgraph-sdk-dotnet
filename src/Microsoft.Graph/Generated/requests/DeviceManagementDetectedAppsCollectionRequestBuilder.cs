// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementDetectedAppsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDetectedAppsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDetectedAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDetectedAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDetectedAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDetectedAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDetectedAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDetectedAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDetectedAppRequestBuilder"/> for the specified DeviceManagementDetectedApp.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDetectedApp.</param>
        /// <returns>The <see cref="IDetectedAppRequestBuilder"/>.</returns>
        public IDetectedAppRequestBuilder this[string id]
        {
            get
            {
                return new DetectedAppRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
