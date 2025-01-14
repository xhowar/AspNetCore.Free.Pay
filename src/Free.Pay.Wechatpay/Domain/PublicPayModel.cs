﻿using Free.Pay.Core.Utils;

namespace Free.Pay.Wechatpay.Domain
{
    public class PublicPayModel:BasePayModel
    {
        public PublicPayModel()
        {
            TradeType = "JSAPI";
        }
        /// <summary>
        ///     交易类型
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        ///     机器IP
        /// </summary>
        public string SpbillCreateIp { get; set; } = HttpUtil.LocalIpAddress;
        /// <summary>
        ///     用户标识
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        ///     场景信息
        /// </summary>
        public string SceneInfo { get; set; }
    }
}
