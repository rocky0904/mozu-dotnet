
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

namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use the document tree subresource to retrieve documents and manage content within the document hierarchy.
	/// </summary>
	public partial class DocumentTreeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DocumentTreeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DocumentTreeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DocumentTreeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DocumentTreeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieve the content associated with the document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var stream = documenttree.GetTreeDocumentContent(_dataViewMode,  documentListName,  documentName);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual System.IO.Stream GetTreeDocumentContent(string documentListName, string documentName)
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentContentClient(_dataViewMode,  documentListName,  documentName);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieve the content associated with the document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var stream = await documenttree.GetTreeDocumentContentAsync(_dataViewMode,  documentListName,  documentName);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> GetTreeDocumentContentAsync(string documentListName, string documentName)
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentContentClient(_dataViewMode,  documentListName,  documentName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Performs transformations on a document. For example, resizing an image.
		/// </summary>
		/// <param name="crop">Crops the image based on the specified coordinates. The reference point for positive coordinates is the top-left corner of the image, and the reference point for negative coordinates is the bottom-right corner of the image.Usage: Example:  removes 10 pixels from all edges of the image.  leaves the image uncropped.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="height">Specifies an exact height dimension for the image, in pixels.</param>
		/// <param name="max">Specifies a pixel limitation for the largest side of an image.</param>
		/// <param name="maxHeight">Specifies a pixel limitation for the height of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="maxWidth">Specifies a pixel limitation for the width of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="quality">Adjusts the image compression. Accepts values from 0-100, where 100 = highest quality, least compression.</param>
		/// <param name="width">Specifies an exact width dimension for the image, in pixels.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var stream = documenttree.TransformTreeDocumentContent( documentListName,  documentName,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual System.IO.Stream TransformTreeDocumentContent(string documentListName, string documentName, int? width =  null, int? height =  null, int? max =  null, int? maxWidth =  null, int? maxHeight =  null, string crop =  null, int? quality =  null)
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.TransformTreeDocumentContentClient( documentListName,  documentName,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Performs transformations on a document. For example, resizing an image.
		/// </summary>
		/// <param name="crop">Crops the image based on the specified coordinates. The reference point for positive coordinates is the top-left corner of the image, and the reference point for negative coordinates is the bottom-right corner of the image.Usage: Example:  removes 10 pixels from all edges of the image.  leaves the image uncropped.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="height">Specifies an exact height dimension for the image, in pixels.</param>
		/// <param name="max">Specifies a pixel limitation for the largest side of an image.</param>
		/// <param name="maxHeight">Specifies a pixel limitation for the height of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="maxWidth">Specifies a pixel limitation for the width of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="quality">Adjusts the image compression. Accepts values from 0-100, where 100 = highest quality, least compression.</param>
		/// <param name="width">Specifies an exact width dimension for the image, in pixels.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var stream = await documenttree.TransformTreeDocumentContentAsync( documentListName,  documentName,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> TransformTreeDocumentContentAsync(string documentListName, string documentName, int? width =  null, int? height =  null, int? max =  null, int? maxWidth =  null, int? maxHeight =  null, string crop =  null, int? quality =  null)
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.TransformTreeDocumentContentClient( documentListName,  documentName,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a document based on its document list and folder path in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var document = documenttree.GetTreeDocument(_dataViewMode,  documentListName,  documentName,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.Document GetTreeDocument(string documentListName, string documentName, bool? includeInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentClient(_dataViewMode,  documentListName,  documentName,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a document based on its document list and folder path in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var document = await documenttree.GetTreeDocumentAsync(_dataViewMode,  documentListName,  documentName,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.Document> GetTreeDocumentAsync(string documentListName, string documentName, bool? includeInactive =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentClient(_dataViewMode,  documentListName,  documentName,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the binary data or content associated with a document, such as a product image or PDF specifications file, by supplying the document name.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.UpdateTreeDocumentContent( stream,  documentListName,  documentName,  contentType);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void UpdateTreeDocumentContent(System.IO.Stream stream, string documentListName, string documentName, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.UpdateTreeDocumentContentClient( stream,  documentListName,  documentName,  contentType);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Updates the binary data or content associated with a document, such as a product image or PDF specifications file, by supplying the document name.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   await documenttree.UpdateTreeDocumentContentAsync( stream,  documentListName,  documentName,  contentType);
		/// </code>
		/// </example>
		public virtual async Task UpdateTreeDocumentContentAsync(System.IO.Stream stream, string documentListName, string documentName, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.UpdateTreeDocumentContentClient( stream,  documentListName,  documentName,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.DeleteTreeDocumentContent( stream,  documentListName,  documentName,  contentType);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteTreeDocumentContent(System.IO.Stream stream, string documentListName, string documentName, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.DeleteTreeDocumentContentClient( stream,  documentListName,  documentName,  contentType);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="documentName">The name of the document in the site.</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   await documenttree.DeleteTreeDocumentContentAsync( stream,  documentListName,  documentName,  contentType);
		/// </code>
		/// </example>
		public virtual async Task DeleteTreeDocumentContentAsync(System.IO.Stream stream, string documentListName, string documentName, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.DeleteTreeDocumentContentClient( stream,  documentListName,  documentName,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


