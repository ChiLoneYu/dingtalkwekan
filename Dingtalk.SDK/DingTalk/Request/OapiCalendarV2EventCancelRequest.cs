using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.calendar.v2.event.cancel
    /// </summary>
    public class OapiCalendarV2EventCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCalendarV2EventCancelResponse>
    {
        /// <summary>
        /// 开放平台应用对应的AgentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 日历id,目前仅支持传“primary”，表示“我的日程”下的日程
        /// </summary>
        public string CalendarId { get; set; }

        /// <summary>
        /// 加密后的日程Id
        /// </summary>
        public string EventId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.calendar.v2.event.cancel";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("calendar_id", this.CalendarId);
            parameters.Add("event_id", this.EventId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("calendar_id", this.CalendarId);
            RequestValidator.ValidateMaxLength("calendar_id", this.CalendarId, 64);
            RequestValidator.ValidateRequired("event_id", this.EventId);
            RequestValidator.ValidateMaxLength("event_id", this.EventId, 64);
        }

        #endregion
    }
}
