/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;
using MundiAPI.PCL.Http.Request;
using MundiAPI.PCL.Http.Response;
using MundiAPI.PCL.Http.Client;
using MundiAPI.PCL.Exceptions;
using MundiAPI.PCL.Models;

namespace MundiAPI.PCL.Controllers
{
    public partial class PlansController: BaseController, IPlansController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PlansController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PlansController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PlansController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Gets all items from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.ListPlanItemsResponse response from the API call</return>
        public Models.ListPlanItemsResponse GetPlanItems(string planId)
        {
            Task<Models.ListPlanItemsResponse> t = GetPlanItemsAsync(planId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all items from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.ListPlanItemsResponse response from the API call</return>
        public async Task<Models.ListPlanItemsResponse> GetPlanItemsAsync(string planId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}/items");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListPlanItemsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <param name="body">Required parameter: Request for updating the plan item</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public Models.GetPlanItemResponse UpdatePlanItem(string planId, string planItemId, Models.UpdatePlanItemRequest body)
        {
            Task<Models.GetPlanItemResponse> t = UpdatePlanItemAsync(planId, planItemId, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <param name="body">Required parameter: Request for updating the plan item</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public async Task<Models.GetPlanItemResponse> UpdatePlanItemAsync(string planId, string planItemId, Models.UpdatePlanItemRequest body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}/items/{plan_item_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
                { "plan_item_id", planItemId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get all subscriptions from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetPlanSubscriptions(string planId)
        {
            Task<dynamic> t = GetPlanSubscriptionsAsync(planId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get all subscriptions from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetPlanSubscriptionsAsync(string planId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}/subscriptions");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public Models.GetPlanResponse GetPlan(string planId)
        {
            Task<Models.GetPlanResponse> t = GetPlanAsync(planId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public async Task<Models.GetPlanResponse> GetPlanAsync(string planId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Adds a new item to a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan item</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public Models.GetPlanItemResponse CreatePlanItem(Models.CreatePlanItemRequest body, string planId)
        {
            Task<Models.GetPlanItemResponse> t = CreatePlanItemAsync(body, planId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Adds a new item to a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan item</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public async Task<Models.GetPlanItemResponse> CreatePlanItemAsync(Models.CreatePlanItemRequest body, string planId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}/items");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for updating a plan</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public Models.GetPlanResponse UpdatePlan(Models.UpdatePlanRequest body, string planId)
        {
            Task<Models.GetPlanResponse> t = UpdatePlanAsync(body, planId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates a plan
        /// </summary>
        /// <param name="body">Required parameter: Request for updating a plan</param>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public async Task<Models.GetPlanResponse> UpdatePlanAsync(Models.UpdatePlanRequest body, string planId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Creates a new plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public Models.GetPlanResponse CreatePlan(Models.CreatePlanRequest body)
        {
            Task<Models.GetPlanResponse> t = CreatePlanAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new plan
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a plan</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public async Task<Models.GetPlanResponse> CreatePlanAsync(Models.CreatePlanRequest body)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets all plans
        /// </summary>
        /// <return>Returns the Models.ListPlansResponse response from the API call</return>
        public Models.ListPlansResponse GetPlans()
        {
            Task<Models.ListPlansResponse> t = GetPlansAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all plans
        /// </summary>
        /// <return>Returns the Models.ListPlansResponse response from the API call</return>
        public async Task<Models.ListPlansResponse> GetPlansAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListPlansResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Deletes a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public Models.GetPlanResponse DeletePlan(string planId)
        {
            Task<Models.GetPlanResponse> t = DeletePlanAsync(planId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns the Models.GetPlanResponse response from the API call</return>
        public async Task<Models.GetPlanResponse> DeletePlanAsync(string planId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public Models.GetPlanItemResponse GetPlanItem(string planId, string planItemId)
        {
            Task<Models.GetPlanItemResponse> t = GetPlanItemAsync(planId, planItemId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a plan item
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public async Task<Models.GetPlanItemResponse> GetPlanItemAsync(string planId, string planItemId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}/items/{plan_item_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
                { "plan_item_id", planItemId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Removes an item from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public Models.GetPlanItemResponse DeletePlanItem(string planId, string planItemId)
        {
            Task<Models.GetPlanItemResponse> t = DeletePlanItemAsync(planId, planItemId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Removes an item from a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <param name="planItemId">Required parameter: Plan item id</param>
        /// <return>Returns the Models.GetPlanItemResponse response from the API call</return>
        public async Task<Models.GetPlanItemResponse> DeletePlanItemAsync(string planId, string planItemId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/plans/{plan_id}/items/{plan_item_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "plan_id", planId },
                { "plan_item_id", planItemId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "MundiSDK" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetPlanItemResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 