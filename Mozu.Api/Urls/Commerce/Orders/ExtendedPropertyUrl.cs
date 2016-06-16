
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class ExtendedPropertyUrl 
	{

		/// <summary>
        /// Get Resource Url for GetExtendedProperties
        /// </summary>
        /// <param name="draft"></param>
        /// <param name="orderId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetExtendedPropertiesUrl(string orderId, bool? draft =  null)
		{
			var url = "/api/commerce/orders/{orderId}/extendedproperties?draft={draft}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "draft", draft);
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddExtendedProperties
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="updateMode"></param>
        /// <param name="version"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddExtendedPropertiesUrl(string orderId, string updateMode =  null, string version =  null)
		{
			var url = "/api/commerce/orders/{orderId}/extendedproperties?updatemode={updateMode}&version={version}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateExtendedProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="orderId"></param>
        /// <param name="responseFields"></param>
        /// <param name="updateMode"></param>
        /// <param name="upsert"></param>
        /// <param name="version"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtendedPropertyUrl(string orderId, string key, string updateMode =  null, string version =  null, bool? upsert =  null, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/extendedproperties/{key}?updatemode={updateMode}&version={version}&upsert={upsert}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "key", key);
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "upsert", upsert);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateExtendedProperties
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="updateMode"></param>
        /// <param name="upsert"></param>
        /// <param name="version"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtendedPropertiesUrl(string orderId, string updateMode =  null, string version =  null, bool? upsert =  null)
		{
			var url = "/api/commerce/orders/{orderId}/extendedproperties?updatemode={updateMode}&version={version}&upsert={upsert}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "upsert", upsert);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteExtendedProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="orderId"></param>
        /// <param name="updateMode"></param>
        /// <param name="version"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteExtendedPropertyUrl(string orderId, string key, string updateMode =  null, string version =  null)
		{
			var url = "/api/commerce/orders/{orderId}/extendedproperties/{key}?updatemode={updateMode}&version={version}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "key", key);
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteExtendedProperties
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="updateMode"></param>
        /// <param name="version"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteExtendedPropertiesUrl(string orderId, string updateMode =  null, string version =  null)
		{
			var url = "/api/commerce/orders/{orderId}/extendedproperties?updatemode={updateMode}&version={version}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

		
	}
}

