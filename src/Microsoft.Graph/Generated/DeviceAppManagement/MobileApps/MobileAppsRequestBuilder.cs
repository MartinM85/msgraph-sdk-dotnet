// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.DeviceAppManagement.MobileApps.Count;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidStoreApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosStoreApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosVppApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSDmgApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedAndroidLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedIOSLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedMobileLobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMicrosoftStoreForBusinessApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWin32LobApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsAppX;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsMobileMSI;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsUniversalAppX;
using Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsWebApp;
using Microsoft.Graph.DeviceAppManagement.MobileApps.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.DeviceAppManagement.MobileApps
{
    /// <summary>
    /// Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class MobileAppsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidLobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder GraphAndroidLobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to androidStoreApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidStoreApp.GraphAndroidStoreAppRequestBuilder GraphAndroidStoreApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphAndroidStoreApp.GraphAndroidStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosLobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosLobApp.GraphIosLobAppRequestBuilder GraphIosLobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosLobApp.GraphIosLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosStoreApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosStoreApp.GraphIosStoreAppRequestBuilder GraphIosStoreApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosStoreApp.GraphIosStoreAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to iosVppApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosVppApp.GraphIosVppAppRequestBuilder GraphIosVppApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphIosVppApp.GraphIosVppAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSDmgApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSDmgApp.GraphMacOSDmgAppRequestBuilder GraphMacOSDmgApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSDmgApp.GraphMacOSDmgAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to macOSLobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSLobApp.GraphMacOSLobAppRequestBuilder GraphMacOSLobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMacOSLobApp.GraphMacOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedAndroidLobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedAndroidLobApp.GraphManagedAndroidLobAppRequestBuilder GraphManagedAndroidLobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedAndroidLobApp.GraphManagedAndroidLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedIOSLobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedIOSLobApp.GraphManagedIOSLobAppRequestBuilder GraphManagedIOSLobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedIOSLobApp.GraphManagedIOSLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to managedMobileLobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedMobileLobApp.GraphManagedMobileLobAppRequestBuilder GraphManagedMobileLobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphManagedMobileLobApp.GraphManagedMobileLobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to microsoftStoreForBusinessApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMicrosoftStoreForBusinessApp.GraphMicrosoftStoreForBusinessAppRequestBuilder GraphMicrosoftStoreForBusinessApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphMicrosoftStoreForBusinessApp.GraphMicrosoftStoreForBusinessAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to win32LobApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWin32LobApp.GraphWin32LobAppRequestBuilder GraphWin32LobApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWin32LobApp.GraphWin32LobAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsAppX.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsAppX.GraphWindowsAppXRequestBuilder GraphWindowsAppX
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsAppX.GraphWindowsAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsMobileMSI.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsMobileMSI.GraphWindowsMobileMSIRequestBuilder GraphWindowsMobileMSI
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsMobileMSI.GraphWindowsMobileMSIRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsUniversalAppX.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsUniversalAppX.GraphWindowsUniversalAppXRequestBuilder GraphWindowsUniversalAppX
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsUniversalAppX.GraphWindowsUniversalAppXRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to windowsWebApp.</summary>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsWebApp.GraphWindowsWebAppRequestBuilder GraphWindowsWebApp
        {
            get => new global::Microsoft.Graph.DeviceAppManagement.MobileApps.GraphWindowsWebApp.GraphWindowsWebAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileApps property of the microsoft.graph.deviceAppManagement entity.</summary>
        /// <param name="position">The unique identifier of mobileApp</param>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceAppManagement.MobileApps.Item.MobileAppItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.Item.MobileAppItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("mobileApp%2Did", position);
                return new global::Microsoft.Graph.DeviceAppManagement.MobileApps.Item.MobileAppItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MobileAppsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List properties and relationships of the managedIOSLobApp objects.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-managedioslobapp-list?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.MobileAppCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.MobileAppCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder.MobileAppsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.MobileAppCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder.MobileAppsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.MobileAppCollectionResponse>(requestInfo, global::Microsoft.Graph.Models.MobileAppCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new windowsAppX object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-apps-windowsappx-create?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.MobileApp"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.MobileApp?> PostAsync(global::Microsoft.Graph.Models.MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.MobileApp> PostAsync(global::Microsoft.Graph.Models.MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.MobileApp>(requestInfo, global::Microsoft.Graph.Models.MobileApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List properties and relationships of the managedIOSLobApp objects.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder.MobileAppsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder.MobileAppsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new windowsAppX object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Models.MobileApp body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List properties and relationships of the managedIOSLobApp objects.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class MobileAppsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class MobileAppsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.DeviceAppManagement.MobileApps.MobileAppsRequestBuilder.MobileAppsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class MobileAppsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
