using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.visible_scopes
    /// </summary>
    public class OapiMicroappVisibleScopesRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappVisibleScopesResponse>
    {
        /// <summary>
        /// 微应用实例化id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.visible_scopes";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
