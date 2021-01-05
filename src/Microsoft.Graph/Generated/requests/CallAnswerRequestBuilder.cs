// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CallAnswerRequestBuilder.
    /// </summary>
    public partial class CallAnswerRequestBuilder : BaseActionMethodRequestBuilder<ICallAnswerRequest>, ICallAnswerRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="CallAnswerRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="callbackUri">A callbackUri parameter for the OData method call.</param>
        /// <param name="mediaConfig">A mediaConfig parameter for the OData method call.</param>
        /// <param name="acceptedModalities">A acceptedModalities parameter for the OData method call.</param>
        public CallAnswerRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string callbackUri,
            MediaConfig mediaConfig,
            IEnumerable<Modality> acceptedModalities)
            : base(requestUrl, client)
        {
            this.SetParameter("callbackUri", callbackUri, false);
            this.SetParameter("mediaConfig", mediaConfig, false);
            this.SetParameter("acceptedModalities", acceptedModalities, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ICallAnswerRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new CallAnswerRequest(functionUrl, this.Client, options);

            if (this.HasParameter("callbackUri"))
            {
                request.RequestBody.CallbackUri = this.GetParameter<string>("callbackUri");
            }

            if (this.HasParameter("mediaConfig"))
            {
                request.RequestBody.MediaConfig = this.GetParameter<MediaConfig>("mediaConfig");
            }

            if (this.HasParameter("acceptedModalities"))
            {
                request.RequestBody.AcceptedModalities = this.GetParameter<IEnumerable<Modality>>("acceptedModalities");
            }

            return request;
        }
    }
}
