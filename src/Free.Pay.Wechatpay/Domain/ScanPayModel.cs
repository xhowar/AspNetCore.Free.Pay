﻿using Free.Pay.Core.Utils;

namespace Free.Pay.Wechatpay.Domain
{
    public class ScanPayModel:BasePayModel
    {
        public ScanPayModel()
        {
            TradeType = "NATIVE";
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
        ///     商品ID
        /// </summary>
        public string ProductId { get; set; }
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
