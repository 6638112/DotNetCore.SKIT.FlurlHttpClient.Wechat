﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/address/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantAddressAddRequest : WechatApiRequest, IInferable<ChannelsECMerchantAddressAddRequest, ChannelsECMerchantAddressAddResponse>
    {
        public static class Types
        {
            public class AddressDetail
            {
                public static class Types
                {
                    public class Address : ChannelsECMerchantAddFreightTemplateRequest.Types.FreightTemplate.Types.Address
                    {
                        /// <summary>
                        /// 获取或设置门牌号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("house_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("house_number")]
                        public string? HouseNumber { get; set; }

                        /// <summary>
                        /// 获取或设置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lng")]
                        [System.Text.Json.Serialization.JsonPropertyName("lng")]
                        public double? Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lat")]
                        [System.Text.Json.Serialization.JsonPropertyName("lat")]
                        public double? Latitude { get; set; }
                    }

                    public class AddressType
                    {
                        /// <summary>
                        /// 获取或设置是否为同城配送地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("same_city")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("same_city")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsSupportSameCity { get; set; }

                        /// <summary>
                        /// 获取或设置是否为线下自提地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pickup")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pickup")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                        public bool? IsSupportPickup { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                public Types.Address Address { get; set; } = new Types.Address();

                /// <summary>
                /// 获取或设置地址类型信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_type")]
                [System.Text.Json.Serialization.JsonPropertyName("address_type")]
                public Types.AddressType? AddressType { get; set; }

                /// <summary>
                /// 获取或设置座机。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("landline")]
                [System.Text.Json.Serialization.JsonPropertyName("landline")]
                public string? Landline { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置是否为发货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_addr")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("send_addr")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsSendAddress { get; set; }

                /// <summary>
                /// 获取或设置是否为默认发货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_send")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("default_send")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsDefaultSendAddress { get; set; }

                /// <summary>
                /// 获取或设置是否为收货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recv_addr")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("recv_addr")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsReceiveAddress { get; set; }

                /// <summary>
                /// 获取或设置是否为默认收货地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_recv")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("default_recv")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsDefaultReceiveAddress { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置地址详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
        public Types.AddressDetail AddressDetail { get; set; } = new Types.AddressDetail();
    }
}
