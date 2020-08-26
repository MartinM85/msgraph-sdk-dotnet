// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface ISessionSegmentsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.InterfaceConverter<SessionSegmentsCollectionPage>))]
    public interface ISessionSegmentsCollectionPage : Microsoft.Graph.ICollectionPage<Segment>
    {
        /// <summary>
        /// Gets the next page <see cref="ISessionSegmentsCollectionRequest"/> instance.
        /// </summary>
        ISessionSegmentsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
