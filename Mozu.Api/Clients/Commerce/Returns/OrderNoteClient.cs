
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

namespace Mozu.Api.Clients.Commerce.Returns
{
	/// <summary>
	/// Use the Return Notes resource to access and modify internal notes associated with returns. These notes can be useful to customer service representatives viewing them in .
	/// </summary>
	public partial class OrderNoteClient 	{
		
		/// <summary>
		/// Retrieves all internal notes associated with a return.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnNotes( returnId);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> GetReturnNotesClient(string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.OrderNoteUrl.GetReturnNotesUrl(returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a specific internal note from a return.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnNote( returnId,  noteId,  responseFields);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetReturnNoteClient(string returnId, string noteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.OrderNoteUrl.GetReturnNoteUrl(returnId, noteId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates an internal note on a given return. This note is visible in  for customer service representatives to see.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnNote"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturnNote( returnNote,  returnId,  responseFields);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> CreateReturnNoteClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote returnNote, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.OrderNoteUrl.CreateReturnNoteUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>(returnNote);
			return mozuClient;

		}

		/// <summary>
		/// Updates an internal note on a given return. This note is visible in  for customer service representatives to see.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnNote"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateReturnNote( returnNote,  returnId,  noteId,  responseFields);
		///   var orderNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> UpdateReturnNoteClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote returnNote, string returnId, string noteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.OrderNoteUrl.UpdateReturnNoteUrl(returnId, noteId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>(returnNote);
			return mozuClient;

		}

		/// <summary>
		/// Deletes an internal note from a given return.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteReturnNote( returnId,  noteId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteReturnNoteClient(string returnId, string noteId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.OrderNoteUrl.DeleteReturnNoteUrl(returnId, noteId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


