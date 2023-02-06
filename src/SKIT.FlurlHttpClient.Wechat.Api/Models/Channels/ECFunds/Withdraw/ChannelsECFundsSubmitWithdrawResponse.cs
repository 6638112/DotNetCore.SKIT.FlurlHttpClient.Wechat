namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/submitwithdraw 接口的响应。</para>
    /// </summary>
    public class ChannelsECFundsSubmitWithdrawResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_ticket")]
        public string QrcodeTicket { get; set; } = default!;
    }
}
