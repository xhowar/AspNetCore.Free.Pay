﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Free.Pay.Core.Request;

namespace Free.Pay.Wechatpay.Utils
{
    /// <summary>
    ///     签名工具类
    /// </summary>
    public static class SignatureUtil
    {
        #region 验签
        /// <summary>
        /// 验签
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="sign">签名</param>
        /// <returns></returns>
        public static bool VerifyData<TModel,TResponse>(BaseRequest<TModel, TResponse> request, string sign)
        {
           return request.GetSign()==sign;
        }

        #endregion
    }
}
