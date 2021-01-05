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
    /// The type WorkbookRangeSortApplyRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeSortApplyRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookRangeSortApplyRequest>, IWorkbookRangeSortApplyRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookRangeSortApplyRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="matchCase">A matchCase parameter for the OData method call.</param>
        /// <param name="hasHeaders">A hasHeaders parameter for the OData method call.</param>
        /// <param name="orientation">A orientation parameter for the OData method call.</param>
        /// <param name="method">A method parameter for the OData method call.</param>
        /// <param name="fields">A fields parameter for the OData method call.</param>
        public WorkbookRangeSortApplyRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool matchCase,
            bool hasHeaders,
            string orientation,
            string method,
            IEnumerable<WorkbookSortField> fields)
            : base(requestUrl, client)
        {
            this.SetParameter("matchCase", matchCase, false);
            this.SetParameter("hasHeaders", hasHeaders, false);
            this.SetParameter("orientation", orientation, false);
            this.SetParameter("method", method, false);
            this.SetParameter("fields", fields, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookRangeSortApplyRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookRangeSortApplyRequest(functionUrl, this.Client, options);

            if (this.HasParameter("matchCase"))
            {
                request.RequestBody.MatchCase = this.GetParameter<bool>("matchCase");
            }

            if (this.HasParameter("hasHeaders"))
            {
                request.RequestBody.HasHeaders = this.GetParameter<bool>("hasHeaders");
            }

            if (this.HasParameter("orientation"))
            {
                request.RequestBody.Orientation = this.GetParameter<string>("orientation");
            }

            if (this.HasParameter("method"))
            {
                request.RequestBody.Method = this.GetParameter<string>("method");
            }

            if (this.HasParameter("fields"))
            {
                request.RequestBody.Fields = this.GetParameter<IEnumerable<WorkbookSortField>>("fields");
            }

            return request;
        }
    }
}
