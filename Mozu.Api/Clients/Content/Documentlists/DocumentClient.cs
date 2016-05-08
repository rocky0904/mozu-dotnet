
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Content.Documentlists
{
	/// <summary>
	/// Use this subresource to manage documents in a document list.
	/// </summary>
	public partial class DocumentClient 	{
		
		/// <summary>
		/// Retrieve the content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentContent(dataViewMode,  documentListName,  documentId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetDocumentContentClient(DataViewMode dataViewMode, string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.GetDocumentContentUrl(documentListName, documentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Performs transformations on a document. For example, resizing an image.
		/// </summary>
		/// <param name="crop">Crops the image based on the specified coordinates. The reference point for positive coordinates is the top-left corner of the image, and the reference point for negative coordinates is the bottom-right corner of the image.Usage: Example:  removes 10 pixels from all edges of the image.  leaves the image uncropped.</param>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="height">Specifies an exact height dimension for the image, in pixels.</param>
		/// <param name="max">Specifies a pixel limitation for the largest side of an image.</param>
		/// <param name="maxHeight">Specifies a pixel limitation for the height of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="maxWidth">Specifies a pixel limitation for the width of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="quality">Adjusts the image compression. Accepts values from 0-100, where 100 = highest quality, least compression.</param>
		/// <param name="width">Specifies an exact width dimension for the image, in pixels.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=TransformDocumentContent( documentListName,  documentId,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> TransformDocumentContentClient(string documentListName, string documentId, int? width =  null, int? height =  null, int? max =  null, int? maxWidth =  null, int? maxHeight =  null, string crop =  null, int? quality =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.TransformDocumentContentUrl(documentListName, documentId, width, height, max, maxWidth, maxHeight, crop, quality);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a document within the specified document list.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Document"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocument(dataViewMode,  documentListName,  documentId,  includeInactive,  responseFields);
		///   var documentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Document> GetDocumentClient(DataViewMode dataViewMode, string documentListName, string documentId, bool? includeInactive =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.GetDocumentUrl(documentListName, documentId, includeInactive, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Document>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a collection of documents according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocuments(dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
		///   var documentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> GetDocumentsClient(DataViewMode dataViewMode, string documentListName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.GetDocumentsUrl(documentListName, filter, sortBy, pageSize, startIndex, includeInactive, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new document in an defined document list.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="document">The document properties that define the content used by the content management system (CMS).</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Document"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDocument(dataViewMode,  document,  documentListName,  responseFields);
		///   var documentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Document> CreateDocumentClient(DataViewMode dataViewMode, Mozu.Api.Contracts.Content.Document document, string documentListName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.CreateDocumentUrl(documentListName, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Document>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.Document>(document)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the binary data or content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocumentContent( stream,  documentListName,  documentId,  contentType);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient UpdateDocumentContentClient(System.IO.Stream stream, string documentListName, string documentId, String  contentType= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.UpdateDocumentContentUrl(documentListName, documentId);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(stream)									.WithHeader(Headers.CONTENT_TYPE ,contentType)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates a document in a document list.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="document">The document properties that define the content used by the content management system (CMS).</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Document"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocument( document,  documentListName,  documentId,  responseFields);
		///   var documentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Document> UpdateDocumentClient(Mozu.Api.Contracts.Content.Document document, string documentListName, string documentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.UpdateDocumentUrl(documentListName, documentId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Document>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.Document>(document);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a specific document based on the specified document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDocument( documentListName,  documentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDocumentClient(string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.DeleteDocumentUrl(documentListName, documentId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specification, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDocumentContent( documentListName,  documentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDocumentContentClient(string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.DeleteDocumentContentUrl(documentListName, documentId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


