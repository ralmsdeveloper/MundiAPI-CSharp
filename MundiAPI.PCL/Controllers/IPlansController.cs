/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;
using MundiAPI.PCL.Http.Request;
using MundiAPI.PCL.Http.Response;
using MundiAPI.PCL.Http.Client;
using MundiAPI.PCL.Models;

namespace MundiAPI.PCL.Controllers
{
    public partial interface IPlansController
    {
        /// <summary>
        /// Gets all items from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.ListPlanItemsResponse response from the API call</return>
        Models.ListPlanItemsResponse GetPlanItems(string planId);

        /// <summary>
        /// Gets all items from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.ListPlanItemsResponse response from the API call</return>
        Task<Models.ListPlanItemsResponse> GetPlanItemsAsync(string planId);

        /// <summary>
        /// Updates a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <param name="body">Required parameter: Request for updating the plan item</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Models.GetPlanItemResponse UpdatePlanItem(string planId, string planItemId, Models.UpdatePlanItemRequest body);

        /// <summary>
        /// Updates a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <param name="body">Required parameter: Request for updating the plan item</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Task<Models.GetPlanItemResponse> UpdatePlanItemAsync(string planId, string planItemId, Models.UpdatePlanItemRequest body);

        /// <summary>
        /// Get all subscriptions from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic GetPlanSubscriptions(string planId);

        /// <summary>
        /// Get all subscriptions from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> GetPlanSubscriptionsAsync(string planId);

        /// <summary>
        /// Gets a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Models.GetPlanResponse GetPlan(string planId);

        /// <summary>
        /// Gets a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Task<Models.GetPlanResponse> GetPlanAsync(string planId);

        /// <summary>
        /// Adds a new item to a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan item</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Models.GetPlanItemResponse CreatePlanItem(Models.CreatePlanItemRequest body, string planId);

        /// <summary>
        /// Adds a new item to a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan item</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Task<Models.GetPlanItemResponse> CreatePlanItemAsync(Models.CreatePlanItemRequest body, string planId);

        /// <summary>
        /// Updates a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for updating a plan</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Models.GetPlanResponse UpdatePlan(Models.UpdatePlanRequest body, string planId);

        /// <summary>
        /// Updates a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for updating a plan</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Task<Models.GetPlanResponse> UpdatePlanAsync(Models.UpdatePlanRequest body, string planId);

        /// <summary>
        /// Creates a new plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Models.GetPlanResponse CreatePlan(Models.CreatePlanRequest body);

        /// <summary>
        /// Creates a new plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Task<Models.GetPlanResponse> CreatePlanAsync(Models.CreatePlanRequest body);

        /// <summary>
        /// Gets all plans
        /// </summary>
        /// <return>Returns the Models.ListPlansResponse response from the API call</return>
        Models.ListPlansResponse GetPlans();

        /// <summary>
        /// Gets all plans
        /// </summary>
        /// <return>Returns the Models.ListPlansResponse response from the API call</return>
        Task<Models.ListPlansResponse> GetPlansAsync();

        /// <summary>
        /// Deletes a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Models.GetPlanResponse DeletePlan(string planId);

        /// <summary>
        /// Deletes a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        Task<Models.GetPlanResponse> DeletePlanAsync(string planId);

        /// <summary>
        /// Gets a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Models.GetPlanItemResponse GetPlanItem(string planId, string planItemId);

        /// <summary>
        /// Gets a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Task<Models.GetPlanItemResponse> GetPlanItemAsync(string planId, string planItemId);

        /// <summary>
        /// Removes an item from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Models.GetPlanItemResponse DeletePlanItem(string planId, string planItemId);

        /// <summary>
        /// Removes an item from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        Task<Models.GetPlanItemResponse> DeletePlanItemAsync(string planId, string planItemId);

    }
} 