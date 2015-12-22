
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

namespace Mozu.Api.Urls.Platform
{
	public partial class SecureAppDataUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDBValue
        /// </summary>
        /// <param name="appKeyId"></param>
        /// <param name="dbEntryQuery">The database entry string to create.</param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDBValueUrl(string appKeyId, string dbEntryQuery, string responseFields =  null)
		{
			var url = "/api/platform/secureappdata/{appKeyId}/{dbEntryQuery}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "appKeyId", appKeyId);
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDBValue
        /// </summary>
        /// <param name="appKeyId"></param>
        /// <param name="dbEntryQuery">The database entry string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDBValueUrl(string appKeyId, string dbEntryQuery)
		{
			var url = "/api/platform/secureappdata/{appKeyId}/{dbEntryQuery}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "appKeyId", appKeyId);
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDBValue
        /// </summary>
        /// <param name="appKeyId"></param>
        /// <param name="dbEntryQuery">The database entry string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDBValueUrl(string appKeyId, string dbEntryQuery)
		{
			var url = "/api/platform/secureappdata/{appKeyId}/{dbEntryQuery}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "appKeyId", appKeyId);
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteDBValue
        /// </summary>
        /// <param name="appKeyId"></param>
        /// <param name="dbEntryQuery">The database entry string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteDBValueUrl(string appKeyId, string dbEntryQuery)
		{
			var url = "/api/platform/secureappdata/{appKeyId}/{dbEntryQuery}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "appKeyId", appKeyId);
			mozuUrl.FormatUrl( "dbEntryQuery", dbEntryQuery);
			return mozuUrl;
		}

		
	}
}

