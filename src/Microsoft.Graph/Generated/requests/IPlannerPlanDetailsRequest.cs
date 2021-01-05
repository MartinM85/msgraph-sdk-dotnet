// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPlannerPlanDetailsRequest.
    /// </summary>
    public partial interface IPlannerPlanDetailsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerPlanDetails using POST.
        /// </summary>
        /// <param name="plannerPlanDetailsToCreate">The PlannerPlanDetails to create.</param>
        /// <returns>The created PlannerPlanDetails.</returns>
        System.Threading.Tasks.Task<PlannerPlanDetails> CreateAsync(PlannerPlanDetails plannerPlanDetailsToCreate);        /// <summary>
        /// Creates the specified PlannerPlanDetails using POST.
        /// </summary>
        /// <param name="plannerPlanDetailsToCreate">The PlannerPlanDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerPlanDetails.</returns>
        System.Threading.Tasks.Task<PlannerPlanDetails> CreateAsync(PlannerPlanDetails plannerPlanDetailsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerPlanDetails.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerPlanDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerPlanDetails.
        /// </summary>
        /// <returns>The PlannerPlanDetails.</returns>
        System.Threading.Tasks.Task<PlannerPlanDetails> GetAsync();

        /// <summary>
        /// Gets the specified PlannerPlanDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerPlanDetails.</returns>
        System.Threading.Tasks.Task<PlannerPlanDetails> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerPlanDetails using PATCH.
        /// </summary>
        /// <param name="plannerPlanDetailsToUpdate">The PlannerPlanDetails to update.</param>
        /// <returns>The updated PlannerPlanDetails.</returns>
        System.Threading.Tasks.Task<PlannerPlanDetails> UpdateAsync(PlannerPlanDetails plannerPlanDetailsToUpdate);

        /// <summary>
        /// Updates the specified PlannerPlanDetails using PATCH.
        /// </summary>
        /// <param name="plannerPlanDetailsToUpdate">The PlannerPlanDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerPlanDetails.</returns>
        System.Threading.Tasks.Task<PlannerPlanDetails> UpdateAsync(PlannerPlanDetails plannerPlanDetailsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanDetailsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanDetailsRequest Expand(Expression<Func<PlannerPlanDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanDetailsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerPlanDetailsRequest Select(Expression<Func<PlannerPlanDetails, object>> selectExpression);

    }
}
