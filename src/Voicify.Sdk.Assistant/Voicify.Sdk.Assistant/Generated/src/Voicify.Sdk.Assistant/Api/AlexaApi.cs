/* 
 * Voicify Assistant API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Voicify.Sdk.Assistant.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Assistant.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlexaApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>SkillResponse</returns>
        SkillResponse HandleLocalRequest (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);

        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of SkillResponse</returns>
        ApiResponse<SkillResponse> HandleLocalRequestWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);
        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>SkillResponse</returns>
        SkillResponse HandleSignedRequest (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);

        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of SkillResponse</returns>
        ApiResponse<SkillResponse> HandleSignedRequestWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of SkillResponse</returns>
        System.Threading.Tasks.Task<SkillResponse> HandleLocalRequestAsync (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);

        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (SkillResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillResponse>> HandleLocalRequestAsyncWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);
        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of SkillResponse</returns>
        System.Threading.Tasks.Task<SkillResponse> HandleSignedRequestAsync (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);

        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (SkillResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SkillResponse>> HandleSignedRequestAsyncWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlexaApi : IAlexaApi
    {
        private Voicify.Sdk.Assistant.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlexaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlexaApi(String basePath)
        {
            this.Configuration = new Voicify.Sdk.Assistant.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Voicify.Sdk.Assistant.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlexaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlexaApi(Voicify.Sdk.Assistant.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Voicify.Sdk.Assistant.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Voicify.Sdk.Assistant.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Voicify.Sdk.Assistant.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Voicify.Sdk.Assistant.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>SkillResponse</returns>
        public SkillResponse HandleLocalRequest (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {
             ApiResponse<SkillResponse> localVarResponse = HandleLocalRequestWithHttpInfo(applicationId, applicationSecret, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of SkillResponse</returns>
        public ApiResponse< SkillResponse > HandleLocalRequestWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {

            var localVarPath = "/api/Alexa/HandleRequest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter
            if (applicationSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationSecret", applicationSecret)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleLocalRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SkillResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillResponse)));
        }

        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of SkillResponse</returns>
        public async System.Threading.Tasks.Task<SkillResponse> HandleLocalRequestAsync (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {
             ApiResponse<SkillResponse> localVarResponse = await HandleLocalRequestAsyncWithHttpInfo(applicationId, applicationSecret, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (SkillResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SkillResponse>> HandleLocalRequestAsyncWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {

            var localVarPath = "/api/Alexa/HandleRequest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter
            if (applicationSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationSecret", applicationSecret)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleLocalRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SkillResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillResponse)));
        }

        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>SkillResponse</returns>
        public SkillResponse HandleSignedRequest (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {
             ApiResponse<SkillResponse> localVarResponse = HandleSignedRequestWithHttpInfo(applicationId, applicationSecret, request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of SkillResponse</returns>
        public ApiResponse< SkillResponse > HandleSignedRequestWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {

            var localVarPath = "/api/Alexa/HandleSignedRequest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter
            if (applicationSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationSecret", applicationSecret)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleSignedRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SkillResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillResponse)));
        }

        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of SkillResponse</returns>
        public async System.Threading.Tasks.Task<SkillResponse> HandleSignedRequestAsync (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {
             ApiResponse<SkillResponse> localVarResponse = await HandleSignedRequestAsyncWithHttpInfo(applicationId, applicationSecret, request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent. 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (SkillResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SkillResponse>> HandleSignedRequestAsyncWithHttpInfo (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)
        {

            var localVarPath = "/api/Alexa/HandleSignedRequest";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter
            if (applicationSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationSecret", applicationSecret)); // query parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("HandleSignedRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SkillResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SkillResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SkillResponse)));
        }

    }
}