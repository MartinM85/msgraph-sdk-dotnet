using Microsoft.Graph.Print.Shares.Item.AllowedUsers.Item.MailboxSettings;
using Microsoft.Graph.Print.Shares.Item.AllowedUsers.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Print.Shares.Item.AllowedUsers.Item {
    /// <summary>
    /// Builds and executes requests for operations under \print\shares\{printerShare-id}\allowedUsers\{user-id}
    /// </summary>
    public class UserItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The mailboxSettings property</summary>
        public MailboxSettingsRequestBuilder MailboxSettings { get =>
            new MailboxSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of print entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/shares/{printerShare%2Did}/allowedUsers/{user%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/shares/{printerShare%2Did}/allowedUsers/{user%2Did}", rawUrl) {
        }
    }
}
