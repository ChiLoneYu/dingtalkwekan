using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.catering.deduct.capacity
    /// </summary>
    public class OapiCateringDeductCapacityRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCateringDeductCapacityResponse>
    {
        /// <summary>
        /// 用餐时间
        /// </summary>
        public Nullable<long> MeaTime { get; set; }

        /// <summary>
        /// 应付金额
        /// </summary>
        public Nullable<long> OrderFullAmount { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        public string Orderid { get; set; }

        /// <summary>
        /// 点餐人userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.catering.deduct.capacity";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("mea_time", this.MeaTime);
            parameters.Add("order_full_amount", this.OrderFullAmount);
            parameters.Add("orderid", this.Orderid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("mea_time", this.MeaTime);
            RequestValidator.ValidateRequired("order_full_amount", this.OrderFullAmount);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
