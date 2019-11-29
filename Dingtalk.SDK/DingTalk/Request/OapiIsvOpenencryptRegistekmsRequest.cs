using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.isv.openencrypt.registekms
    /// </summary>
    public class OapiIsvOpenencryptRegistekmsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiIsvOpenencryptRegistekmsResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string TopKmsMeta { get; set; }

        public TopKMSMetaDomain TopKmsMeta_ { set { this.TopKmsMeta = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.isv.openencrypt.registekms";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("top_kms_meta", this.TopKmsMeta);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("top_kms_meta", this.TopKmsMeta);
        }

	/// <summary>
/// TopKMSMetaDomain Data Structure.
/// </summary>
[Serializable]

public class TopKMSMetaDomain : TopObject
{
	        /// <summary>
	        /// 微应用id
	        /// </summary>
	        [XmlElement("appid")]
	        public Nullable<long> Appid { get; set; }
	
	        /// <summary>
	        /// kms数据域名
	        /// </summary>
	        [XmlElement("endpoint")]
	        public string Endpoint { get; set; }
	
	        /// <summary>
	        /// 扩展字段,JSON格式
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 请求id
	        /// </summary>
	        [XmlElement("requestid")]
	        public string Requestid { get; set; }
	
	        /// <summary>
	        /// 0：禁用，1：启用
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
}

        #endregion
    }
}
