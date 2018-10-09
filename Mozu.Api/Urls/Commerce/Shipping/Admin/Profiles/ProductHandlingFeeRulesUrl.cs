
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

namespace Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles
{
	public partial class ProductHandlingFeeRulesUrl 
	{

		/// <summary>
        /// Get Resource Url for GetProductHandlingFeeRule
        /// </summary>
        /// <param name="id">Unique identifier of the customer segment to retrieve.</param>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the product handling fee rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductHandlingFeeRuleUrl(string profilecode, string id, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/producthandlingfees/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductHandlingFeeRules
        /// </summary>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the product handling fee rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductHandlingFeeRulesUrl(string profilecode, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/producthandlingfees?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateProductHandlingFeeRule
        /// </summary>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the product handling fee rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateProductHandlingFeeRuleUrl(string profilecode, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/producthandlingfees?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateProductHandlingFeeRule
        /// </summary>
        /// <param name="id">Unique identifier of the customer segment to retrieve.</param>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the product handling fee rule is associated.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductHandlingFeeRuleUrl(string profilecode, string id, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/producthandlingfees/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteProductHandlingFeeRule
        /// </summary>
        /// <param name="id">Unique identifier of the customer segment to retrieve.</param>
        /// <param name="profilecode">The unique, user-defined code of the profile with which the product handling fee rule is associated.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteProductHandlingFeeRuleUrl(string profilecode, string id)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/producthandlingfees/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			return mozuUrl;
		}

		
	}
}
