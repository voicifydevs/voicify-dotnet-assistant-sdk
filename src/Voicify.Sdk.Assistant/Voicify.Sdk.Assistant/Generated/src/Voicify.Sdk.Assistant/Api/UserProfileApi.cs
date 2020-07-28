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
    public interface IUserProfileApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the current session state data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>ConversationSessionState</returns>
        ConversationSessionState GetSessionAttributes (string sessionId, string applicationId = null, string applicationSecret = null);

        /// <summary>
        /// Gets the current session state data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>ApiResponse of ConversationSessionState</returns>
        ApiResponse<ConversationSessionState> GetSessionAttributesWithHttpInfo (string sessionId, string applicationId = null, string applicationSecret = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets the current session state data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>Task of ConversationSessionState</returns>
        System.Threading.Tasks.Task<ConversationSessionState> GetSessionAttributesAsync (string sessionId, string applicationId = null, string applicationSecret = null);

        /// <summary>
        /// Gets the current session state data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationSessionState)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConversationSessionState>> GetSessionAttributesAsyncWithHttpInfo (string sessionId, string applicationId = null, string applicationSecret = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserProfileApi : IUserProfileApi
    {
        private Voicify.Sdk.Assistant.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserProfileApi(String basePath)
        {
            this.Configuration = new Voicify.Sdk.Assistant.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Voicify.Sdk.Assistant.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserProfileApi(Voicify.Sdk.Assistant.Client.Configuration configuration = null)
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
        /// Gets the current session state data 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>ConversationSessionState</returns>
        public ConversationSessionState GetSessionAttributes (string sessionId, string applicationId = null, string applicationSecret = null)
        {
             ApiResponse<ConversationSessionState> localVarResponse = GetSessionAttributesWithHttpInfo(sessionId, applicationId, applicationSecret);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the current session state data 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>ApiResponse of ConversationSessionState</returns>
        public ApiResponse< ConversationSessionState > GetSessionAttributesWithHttpInfo (string sessionId, string applicationId = null, string applicationSecret = null)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling UserProfileApi->GetSessionAttributes");

            var localVarPath = "/api/UserProfile/session/{sessionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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

            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId)); // path parameter
            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter
            if (applicationSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationSecret", applicationSecret)); // query parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSessionAttributes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConversationSessionState>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationSessionState) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationSessionState)));
        }

        /// <summary>
        /// Gets the current session state data 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>Task of ConversationSessionState</returns>
        public async System.Threading.Tasks.Task<ConversationSessionState> GetSessionAttributesAsync (string sessionId, string applicationId = null, string applicationSecret = null)
        {
             ApiResponse<ConversationSessionState> localVarResponse = await GetSessionAttributesAsyncWithHttpInfo(sessionId, applicationId, applicationSecret);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the current session state data 
        /// </summary>
        /// <exception cref="Voicify.Sdk.Assistant.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sessionId"></param>
        /// <param name="applicationId"> (optional)</param>
        /// <param name="applicationSecret"> (optional)</param>
        /// <returns>Task of ApiResponse (ConversationSessionState)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConversationSessionState>> GetSessionAttributesAsyncWithHttpInfo (string sessionId, string applicationId = null, string applicationSecret = null)
        {
            // verify the required parameter 'sessionId' is set
            if (sessionId == null)
                throw new ApiException(400, "Missing required parameter 'sessionId' when calling UserProfileApi->GetSessionAttributes");

            var localVarPath = "/api/UserProfile/session/{sessionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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

            if (sessionId != null) localVarPathParams.Add("sessionId", this.Configuration.ApiClient.ParameterToString(sessionId)); // path parameter
            if (applicationId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationId", applicationId)); // query parameter
            if (applicationSecret != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "applicationSecret", applicationSecret)); // query parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSessionAttributes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ConversationSessionState>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ConversationSessionState) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ConversationSessionState)));
        }

    }
}
