using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteChannelsExtensions
    {
        #region ECBasics
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/basics/img/upload 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/img_upload.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECBasicsImageUploadResponse> ExecuteChannelsECBasicsImageUploadAsync(this WechatApiClient client, Models.ChannelsECBasicsImageUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "basics", "img", "upload")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("resp_type", request.ResponseType);

            if (request.ImageUrl != null)
            {
                flurlReq.SetQueryParam("upload_type", 1)
                        .SetQueryParam("img_url", request.ImageUrl);

                return await client.SendRequestWithJsonAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
            }
            else
            {
                flurlReq.SetQueryParam("upload_type", 0)
                        .SetQueryParam("height", request.Height)
                        .SetQueryParam("width", request.Width);

                string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                using var httpContent = new MultipartFormDataContent(boundary);
                using var fileContent = new ByteArrayContent(request.ImageFileBytes ?? Array.Empty<byte>());
                httpContent.Add(fileContent, "\"media\"", "\"image.png\"");
                httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                fileContent.Headers.ContentLength = request.ImageFileBytes?.Length;

                return await client.SendRequestAsync<Models.ChannelsECBasicsImageUploadResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
            }
        }
        #endregion

        #region ECCategory
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/availablesoncategories/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/getavailablesoncategories.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse> ExecuteChannelsECCategoryAvailableSonCategoriesGetAsync(this WechatApiClient client, Models.ChannelsECCategoryAvailableSonCategoriesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "availablesoncategories", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAvailableSonCategoriesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/add.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAddResponse> ExecuteChannelsECCategoryAddAsync(this WechatApiClient client, Models.ChannelsECCategoryAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/category/audit/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/category/audit_get.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECCategoryAuditGetResponse> ExecuteChannelsECCategoryAuditGetAsync(this WechatApiClient client, Models.ChannelsECCategoryAuditGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "category", "audit", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECCategoryAuditGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ECWindow
        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/add.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductAddResponse> ExecuteChannelsECWindowProductAddAsync(this WechatApiClient client, Models.ChannelsECWindowProductAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWindowProductAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /channels/ec/window/product/off 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/off.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ChannelsECWindowProductOffResponse> ExecuteChannelsECWindowProductOffAsync(this WechatApiClient client, Models.ChannelsECWindowProductOffRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "channels", "ec", "window", "product", "off")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ChannelsECWindowProductOffResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
