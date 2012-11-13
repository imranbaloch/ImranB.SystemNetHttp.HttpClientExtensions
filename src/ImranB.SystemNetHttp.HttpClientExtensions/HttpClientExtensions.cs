using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace ImranB.SystemNetHttp
{
    /// <summary>
    /// Extension methods that aid in making formatted requests using <see cref="HttpClient"/>.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class HttpClientExtensions
    {
        /// <summary>Send a DELETE request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> DeleteAsync(this HttpClient client, string requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.DeleteAsync(requestUri);
        }

        /// <summary>Send a DELETE request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>		
        public static Task<HttpResponseMessage> DeleteAsync(this HttpClient client, Uri requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.DeleteAsync(requestUri);
        }

        /// <summary>Send a DELETE request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> DeleteAsync(this HttpClient client, string requestUri, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.DeleteAsync(requestUri, cancellationToken);
        }

        /// <summary>Send a DELETE request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> DeleteAsync(this HttpClient client, Uri requestUri, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.DeleteAsync(requestUri, cancellationToken);
        }

        /// <summary>Send a GET request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, string requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, Uri requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri with an HTTP completion option as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, string requestUri, HttpCompletionOption completionOption, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri, completionOption);
        }

        /// <summary>Send a GET request to the specified Uri with an HTTP completion option as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, Uri requestUri, HttpCompletionOption completionOption, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri, completionOption);
        }

        /// <summary>Send a GET request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, string requestUri, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri, cancellationToken);
        }

        /// <summary>Send a GET request to the specified Uri with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, Uri requestUri, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri, cancellationToken);
        }

        /// <summary>Send a GET request to the specified Uri with an HTTP completion option and a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri, completionOption, cancellationToken);
        }

        /// <summary>Send a GET request to the specified Uri with an HTTP completion option and a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="completionOption">An HTTP  completion option value that indicates when the operation should be considered completed.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetAsync(requestUri, completionOption, cancellationToken);
        }

        /// <summary>Send a GET request to the specified Uri and return the response body as a byte array in an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<byte[]> GetByteArrayAsync(this HttpClient client, string requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetByteArrayAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri and return the response body as a byte array in an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<byte[]> GetByteArrayAsync(this HttpClient client, Uri requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetByteArrayAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<Stream> GetStreamAsync(this HttpClient client, string requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetStreamAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<Stream> GetStreamAsync(this HttpClient client, Uri requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetStreamAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<string> GetStringAsync(this HttpClient client, string requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetStringAsync(requestUri);
        }

        /// <summary>Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<string> GetStringAsync(this HttpClient client, Uri requestUri, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.GetStringAsync(requestUri);
        }

        /// <summary>Send a POST request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PostAsync(this HttpClient client, string requestUri, HttpContent content, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, content);
        }

        /// <summary>Send a POST request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PostAsync(this HttpClient client, Uri requestUri, HttpContent content, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, content);
        }

        /// <summary>Send a POST request with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PostAsync(this HttpClient client, string requestUri, HttpContent content, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, content, cancellationToken);
        }

        /// <summary>Send a POST request with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PostAsync(this HttpClient client, Uri requestUri, HttpContent content, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, content, cancellationToken);
        }

        /// <summary>Send a PUT request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PutAsync(this HttpClient client, string requestUri, HttpContent content, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, content);
        }

        /// <summary>Send a PUT request to the specified Uri as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PutAsync(this HttpClient client, Uri requestUri, HttpContent content, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, content);
        }

        /// <summary>Send a PUT request with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PutAsync(this HttpClient client, string requestUri, HttpContent content, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, content, cancellationToken);
        }

        /// <summary>Send a PUT request with a cancellation token as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="requestUri" /> was null.</exception>
        public static Task<HttpResponseMessage> PutAsync(this HttpClient client, Uri requestUri, HttpContent content, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, content, cancellationToken);
        }

        /// <summary>Send an HTTP request as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="request">The HTTP request message to send.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
        public static Task<HttpResponseMessage> SendAsync(this HttpClient client, HttpRequestMessage request, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.SendAsync(request);
        }

        /// <summary>Send an HTTP request as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="request">The HTTP request message to send.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
        public static Task<HttpResponseMessage> SendAsync(this HttpClient client, HttpRequestMessage request, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.SendAsync(request, cancellationToken);
        }

        /// <summary>Send an HTTP request as an asynchronous operation. </summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="request">The HTTP request message to send.</param>
        /// <param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
        public static Task<HttpResponseMessage> SendAsync(this HttpClient client, HttpRequestMessage request, HttpCompletionOption completionOption, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.SendAsync(request, completionOption);
        }

        /// <summary>Send an HTTP request as an asynchronous operation.</summary>
        /// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="request">The HTTP request message to send.</param>
        /// <param name="completionOption">When the operation should complete (as soon as a response is available or after reading the whole response content).</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="request" /> was null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The request message was already sent by the <see cref="T:System.Net.Http.HttpClient" /> instance.</exception>
        public static Task<HttpResponseMessage> SendAsync(this HttpClient client, HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.SendAsync(request, completionOption, cancellationToken);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as JSON.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="JsonMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>        
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsJsonAsync(requestUri, value);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as JSON.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="JsonMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsJsonAsync(requestUri, value, cancellationToken);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as XML.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="XmlMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsXmlAsync<T>(this HttpClient client, string requestUri, T value, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsXmlAsync(requestUri, value);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as XML.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="XmlMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsXmlAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsXmlAsync(requestUri, value, cancellationToken);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <seealso cref="PostAsync{T}(HttpClient, string, T, MediaTypeFormatter, string, CancellationToken)"/>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, value, formatter);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <seealso cref="PostAsync{T}(HttpClient, string, T, MediaTypeFormatter, string, CancellationToken)"/>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, value, formatter, cancellationToken);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <seealso cref="PostAsync{T}(HttpClient, string, T, MediaTypeFormatter, string, CancellationToken)"/>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="mediaType">The authoritative value of the request's content's Content-Type header. Can be <c>null</c> in which case the
        /// <paramref name="formatter">formatter's</paramref> default content type will be used.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, string mediaType, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, value, formatter, mediaType);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="mediaType">The authoritative value of the request's content's Content-Type header. Can be <c>null</c> in which case the
        /// <paramref name="formatter">formatter's</paramref> default content type will be used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, string mediaType, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, value, formatter, mediaType, cancellationToken);
        }

        /// <summary>
        /// Sends a POST request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="mediaType">The authoritative value of the request's content's Content-Type header. Can be <c>null</c> in which case the
        /// <paramref name="formatter">formatter's</paramref> default content type will be used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "The caller is responsible for disposing the object")]
        [SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Justification = "The called method will convert to Uri instance.")]
        public static Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, MediaTypeHeaderValue mediaType, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PostAsync(requestUri, value, formatter, mediaType, cancellationToken);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as JSON.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="JsonMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsJsonAsync(requestUri, value);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as JSON.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="JsonMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsJsonAsync(requestUri, value, cancellationToken);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as XML.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="XmlMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsXmlAsync<T>(this HttpClient client, string requestUri, T value, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsXmlAsync(requestUri, value);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with the given <paramref name="value"/> serialized
        /// as XML.
        /// </summary>
        /// <remarks>
        /// This method uses the default instance of <see cref="XmlMediaTypeFormatter"/>.
        /// </remarks>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsXmlAsync<T>(this HttpClient client, string requestUri, T value, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsXmlAsync(requestUri, value, cancellationToken);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <seealso cref="PutAsync{T}(HttpClient, string, T, MediaTypeFormatter, string, CancellationToken)"/>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, value, formatter);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <seealso cref="PutAsync{T}(HttpClient, string, T, MediaTypeFormatter, string, CancellationToken)"/>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, value, formatter, cancellationToken);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <seealso cref="PutAsync{T}(HttpClient, string, T, MediaTypeFormatter, string, CancellationToken)"/>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="mediaType">The authoritative value of the request's content's Content-Type header. Can be <c>null</c> in which case the
        /// <paramref name="formatter">formatter's</paramref> default content type will be used.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, string mediaType, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, value, formatter, mediaType);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="mediaType">The authoritative value of the request's content's Content-Type header. Can be <c>null</c> in which case the
        /// <paramref name="formatter">formatter's</paramref> default content type will be used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        public static Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, string mediaType, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, value, formatter, mediaType, cancellationToken);
        }

        /// <summary>
        /// Sends a PUT request as an asynchronous operation to the specified Uri with <paramref name="value"/>
        /// serialized using the given <paramref name="formatter"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="client">The client used to make the request.</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="value">The value that will be placed in the request's entity body.</param>
        /// <param name="formatter">The formatter used to serialize the <paramref name="value"/>.</param>
        /// <param name="mediaType">The authoritative value of the request's content's Content-Type header. Can be <c>null</c> in which case the
        /// <paramref name="formatter">formatter's</paramref> default content type will be used.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="browser">The browser making the request.</param>
        /// <returns>A task object representing the asynchronous operation.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Justification = "We want to support URIs as strings")]
        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "The caller is responsible for disposing the object")]
        [SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Justification = "The called method will convert to Uri instance.")]
        public static Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string requestUri, T value, MediaTypeFormatter formatter, MediaTypeHeaderValue mediaType, CancellationToken cancellationToken, Browser browser)
        {
            SetBrowserSpecificHeaders(client, browser);
            return client.PutAsync(requestUri, value, formatter, mediaType, cancellationToken);
        }

        private static void SetBrowserSpecificHeaders(HttpClient client, Browser browser)
        {
            var headers = client.DefaultRequestHeaders;
            headers.Accept.Clear();
            headers.AcceptLanguage.Clear();
            headers.AcceptEncoding.Clear();
            switch (browser)
            {
                case Browser.Firefox:
                    headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
                    headers.Add("Accept-Language", "en-US,en;q=0.5");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.Chrome:
                    headers.AcceptCharset.Clear();
                    headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
                    headers.Add("Accept-Language", "en-US,en;q=0.8");
                    headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                    headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.3");
                    break;
                case Browser.Safari:
                    headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.Maxthon:
                    headers.AcceptCharset.Clear();
                    headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.3");
                    break;
                case Browser.Opera:
                    headers.Add("Accept", "text/html, application/xml;q=0.9, application/xhtml+xml, image/png, image/webp, image/jpeg, image/gif, image/x-xbitmap, */*;q=0.1");
                    headers.Add("Accept-Language", "en-US,en;q=0.9");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.IE10:
                    headers.Add("Accept", "text/html, application/xhtml+xml, */*");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.IE9:
                    headers.Add("Accept", "text/html, application/xhtml+xml, */*");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.IE8:
                    headers.Add("Accept", "*/*");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.IE7:
                    headers.Add("Accept", "*/*");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                case Browser.IE6:
                    headers.Add("Accept", "*/*");
                    headers.Add("Accept-Language", "en-US");
                    headers.Add("Accept-Encoding", "gzip, deflate");
                    break;
                default:
                    break;
            }
        }
    }
}
