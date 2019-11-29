using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.role.addrole
    /// </summary>
    public class OapiRoleAddroleRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRoleAddroleResponse>
    {
        /// <summary>
        /// test
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        public string RoleName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.role.addrole";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("groupId", this.GroupId);
            parameters.Add("roleName", this.RoleName);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("groupId", this.GroupId);
            RequestValidator.ValidateRequired("roleName", this.RoleName);
        }

        #endregion
    }
}
