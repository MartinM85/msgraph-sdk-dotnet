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
    /// The type WorkbookFunctionsF_Inv_RTRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsF_Inv_RTRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsF_Inv_RTRequest>, IWorkbookFunctionsF_Inv_RTRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsF_Inv_RTRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="probability">A probability parameter for the OData method call.</param>
        /// <param name="degFreedom1">A degFreedom1 parameter for the OData method call.</param>
        /// <param name="degFreedom2">A degFreedom2 parameter for the OData method call.</param>
        public WorkbookFunctionsF_Inv_RTRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken probability,
            Newtonsoft.Json.Linq.JToken degFreedom1,
            Newtonsoft.Json.Linq.JToken degFreedom2)
            : base(requestUrl, client)
        {
            this.SetParameter("probability", probability, true);
            this.SetParameter("degFreedom1", degFreedom1, true);
            this.SetParameter("degFreedom2", degFreedom2, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsF_Inv_RTRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsF_Inv_RTRequest(functionUrl, this.Client, options);

            if (this.HasParameter("probability"))
            {
                request.RequestBody.Probability = this.GetParameter<Newtonsoft.Json.Linq.JToken>("probability");
            }

            if (this.HasParameter("degFreedom1"))
            {
                request.RequestBody.DegFreedom1 = this.GetParameter<Newtonsoft.Json.Linq.JToken>("degFreedom1");
            }

            if (this.HasParameter("degFreedom2"))
            {
                request.RequestBody.DegFreedom2 = this.GetParameter<Newtonsoft.Json.Linq.JToken>("degFreedom2");
            }

            return request;
        }
    }
}
