
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

namespace Mozu.Api.Urls.Content.Documentlists
{
	public partial class ViewUrl 
	{

		/// <summary>
        /// Get Resource Url for GetViewDocuments
        /// </summary>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="includeInactive">Include inactive content.</param>
        /// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
        /// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetViewDocumentsUrl(string documentListName, string viewName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/views/{viewName}/documents?filter={filter}&sortBy={sortBy}&pageSize={pageSize}&startIndex={startIndex}&includeInactive={includeInactive}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "includeInactive", includeInactive);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			mozuUrl.FormatUrl( "viewName", viewName);
			return mozuUrl;
		}

								
	}
}

