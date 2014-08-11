
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Content
{
	public partial class PropertyTypeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPropertyTypes
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPropertyTypesUrl(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = "/api/content/propertytypes/?pageSize={pageSize}&startIndex={startIndex}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPropertyType
        /// </summary>
        /// <param name="propertyTypeName"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPropertyTypeUrl(string propertyTypeName, string responseFields =  null)
		{
			var url = "/api/content/propertytypes/{propertyTypeName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "propertyTypeName", propertyTypeName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

								
	}
}

