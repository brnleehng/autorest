// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial class AutoRestAzureSpecialParametersTestClient : ServiceClient<AutoRestAzureSpecialParametersTestClient>, IAutoRestAzureSpecialParametersTestClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets JSON serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets JSON deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription id, which appears in the path, always modeled in
        /// credentials. The value is always '1234-5678-9012-3456'
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The api version, which appears in the query, the value is always
        /// '2015-07-01-preview'
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IXMsClientRequestIdOperations.
        /// </summary>
        public virtual IXMsClientRequestIdOperations XMsClientRequestId { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionInCredentialsOperations.
        /// </summary>
        public virtual ISubscriptionInCredentialsOperations SubscriptionInCredentials { get; private set; }

        /// <summary>
        /// Gets the ISubscriptionInMethodOperations.
        /// </summary>
        public virtual ISubscriptionInMethodOperations SubscriptionInMethod { get; private set; }

        /// <summary>
        /// Gets the IApiVersionDefaultOperations.
        /// </summary>
        public virtual IApiVersionDefaultOperations ApiVersionDefault { get; private set; }

        /// <summary>
        /// Gets the IApiVersionLocalOperations.
        /// </summary>
        public virtual IApiVersionLocalOperations ApiVersionLocal { get; private set; }

        /// <summary>
        /// Gets the ISkipUrlEncodingOperations.
        /// </summary>
        public virtual ISkipUrlEncodingOperations SkipUrlEncoding { get; private set; }

        /// <summary>
        /// Gets the IOdataOperations.
        /// </summary>
        public virtual IOdataOperations Odata { get; private set; }

        /// <summary>
        /// Gets the IHeaderOperations.
        /// </summary>
        public virtual IHeaderOperations Header { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        protected AutoRestAzureSpecialParametersTestClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        protected AutoRestAzureSpecialParametersTestClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        protected AutoRestAzureSpecialParametersTestClient(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        protected AutoRestAzureSpecialParametersTestClient(Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The subscription id, which appears in the path, always modeled in credentials. The value is always '1234-5678-9012-3456'
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        public AutoRestAzureSpecialParametersTestClient(ServiceClientCredentials credentials, string subscriptionId, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The subscription id, which appears in the path, always modeled in credentials. The value is always '1234-5678-9012-3456'
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        public AutoRestAzureSpecialParametersTestClient(ServiceClientCredentials credentials, string subscriptionId, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The subscription id, which appears in the path, always modeled in credentials. The value is always '1234-5678-9012-3456'
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        public AutoRestAzureSpecialParametersTestClient(Uri baseUri, ServiceClientCredentials credentials, string subscriptionId, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestAzureSpecialParametersTestClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. The subscription id, which appears in the path, always modeled in credentials. The value is always '1234-5678-9012-3456'
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The HTTP client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP client pipeline.
        /// </param>
        public AutoRestAzureSpecialParametersTestClient(Uri baseUri, ServiceClientCredentials credentials, string subscriptionId, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.XMsClientRequestId = new XMsClientRequestIdOperations(this);
            this.SubscriptionInCredentials = new SubscriptionInCredentialsOperations(this);
            this.SubscriptionInMethod = new SubscriptionInMethodOperations(this);
            this.ApiVersionDefault = new ApiVersionDefaultOperations(this);
            this.ApiVersionLocal = new ApiVersionLocalOperations(this);
            this.SkipUrlEncoding = new SkipUrlEncodingOperations(this);
            this.Odata = new OdataOperations(this);
            this.Header = new HeaderOperations(this);
            this.BaseUri = new Uri("http://localhost");
            this.ApiVersion = "2015-07-01-preview";
            this.AcceptLanguage = "en-US";
            this.LongRunningOperationRetryTimeout = 30;
            this.GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter()); 
        }    
    }
}
