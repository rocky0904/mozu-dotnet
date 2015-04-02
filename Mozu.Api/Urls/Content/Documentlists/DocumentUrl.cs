
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
	public partial class DocumentUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDocumentContent
        /// </summary>
        /// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentContentUrl(string documentListName, string documentId)
		{
			var url = "/api/content/documentlists/{documentListName}/documents/{documentId}/content";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentId", documentId);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDocument
        /// </summary>
        /// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentUrl(string documentListName, string documentId, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/documents/{documentId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentId", documentId);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetDocuments
        /// </summary>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentsUrl(string documentListName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/documents?filter={filter}&sortBy={sortBy}&pageSize={pageSize}&startIndex={startIndex}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateDocument
        /// </summary>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDocumentUrl(string documentListName, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/documents?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateDocumentContent
        /// </summary>
        /// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDocumentContentUrl(string documentListName, string documentId)
		{
			var url = "/api/content/documentlists/{documentListName}/documents/{documentId}/content";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentId", documentId);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateDocument
        /// </summary>
        /// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDocumentUrl(string documentListName, string documentId, string responseFields =  null)
		{
			var url = "/api/content/documentlists/{documentListName}/documents/{documentId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentId", documentId);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteDocument
        /// </summary>
        /// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteDocumentUrl(string documentListName, string documentId)
		{
			var url = "/api/content/documentlists/{documentListName}/documents/{documentId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentId", documentId);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteDocumentContent
        /// </summary>
        /// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
        /// <param name="documentListName">Name of content documentListName to delete</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteDocumentContentUrl(string documentListName, string documentId)
		{
			var url = "/api/content/documentlists/{documentListName}/documents/{documentId}/content";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentId", documentId);
			mozuUrl.FormatUrl( "documentListName", documentListName);
			return mozuUrl;
		}

		
	}
}
