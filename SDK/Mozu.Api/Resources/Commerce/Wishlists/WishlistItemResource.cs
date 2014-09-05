
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

namespace Mozu.Api.Resources.Commerce.Wishlists
{
	/// <summary>
	/// Use the Wish List Items subresource to manage items in a shopper wish list. The same product can be defined as an item in any number of wish lists for the customer account. Use the Wish Lists resource to manage shopper wish lists.
	/// </summary>
	public partial class WishlistItemResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public WishlistItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public WishlistItemResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new WishlistItemResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the details of an item in a shopper wish list.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="wishlistId">Unique identifier of the wish list item to retrieve.</param>
		/// <param name="wishlistItemId">Unique identifier of the wish list associated with the item to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlistItem = wishlistitem.GetWishlistItem( wishlistId,  wishlistItemId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem GetWishlistItem(string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.GetWishlistItemClient( wishlistId,  wishlistItemId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> GetWishlistItemAsync(string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.GetWishlistItemClient( wishlistId,  wishlistItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of items in a shopper wish list according to any specified filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="wishlistId">Unique identifier of the wish list associated with the items to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlistItemCollection = wishlistitem.GetWishlistItems( wishlistId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection GetWishlistItems(string wishlistId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.GetWishlistItemsClient( wishlistId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> GetWishlistItemsAsync(string wishlistId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.GetWishlistItemsClient( wishlistId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieve a list of items in a customer wish list by supplying the wish list name.
		/// </summary>
		/// <param name="customerAccountId">The unique identifier of the customer account associated with the wish list.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="wishlistName">The name of the wish list that contains the items to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlistItemCollection = wishlistitem.GetWishlistItemsByWishlistName( customerAccountId,  wishlistName,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection GetWishlistItemsByWishlistName(int customerAccountId, string wishlistName, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.GetWishlistItemsByWishlistNameClient( customerAccountId,  wishlistName,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> GetWishlistItemsByWishlistNameAsync(int customerAccountId, string wishlistName, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.GetWishlistItemsByWishlistNameClient( customerAccountId,  wishlistName,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a product in a site's catalog as an item in a shopper wish list.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="wishlistId">Unique identifier of the wish list associated with the item to add.</param>
		/// <param name="wishlistItem">Properties of the item to add to the wish list.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlistItem = wishlistitem.AddItemToWishlist( wishlistItem,  wishlistId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem AddItemToWishlist(Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem wishlistItem, string wishlistId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.AddItemToWishlistClient( wishlistItem,  wishlistId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> AddItemToWishlistAsync(Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem wishlistItem, string wishlistId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.AddItemToWishlistClient( wishlistItem,  wishlistId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the quantity of an item in a shopper wish list.
		/// </summary>
		/// <param name="quantity">The quantity of the item in the wish list.</param>
		/// <param name="responseFields"></param>
		/// <param name="wishlistId">Unique identifier of the wish list associated with the item quantity to update.</param>
		/// <param name="wishlistItemId">Unique identifier of the item in the wish list to update quantity.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlistItem = wishlistitem.UpdateWishlistItemQuantity( wishlistId,  wishlistItemId,  quantity,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem UpdateWishlistItemQuantity(string wishlistId, string wishlistItemId, int quantity, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.UpdateWishlistItemQuantityClient( wishlistId,  wishlistItemId,  quantity,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> UpdateWishlistItemQuantityAsync(string wishlistId, string wishlistItemId, int quantity, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.UpdateWishlistItemQuantityClient( wishlistId,  wishlistItemId,  quantity,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the details of an item in a shopper wish list.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="wishlistId">Unique identifier of the wish list associated with the item to update.</param>
		/// <param name="wishlistItemId">Unique identifier of the item in the shopper wish list to update.</param>
		/// <param name="wishlistItem">Properties of the shopper wish list item to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlistItem = wishlistitem.UpdateWishlistItem( wishlistItem,  wishlistId,  wishlistItemId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem UpdateWishlistItem(Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem wishlistItem, string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.UpdateWishlistItemClient( wishlistItem,  wishlistId,  wishlistItemId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> UpdateWishlistItemAsync(Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem wishlistItem, string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.UpdateWishlistItemClient( wishlistItem,  wishlistId,  wishlistItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes all items associated with a shopper wish list.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list associated with the items to remove.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   var wishlist = wishlistitem.RemoveAllWishlistItems( wishlistId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist RemoveAllWishlistItems(string wishlistId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.RemoveAllWishlistItemsClient( wishlistId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> RemoveAllWishlistItemsAsync(string wishlistId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.RemoveAllWishlistItemsClient( wishlistId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes an item from the wish list specified in the request.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list associated with the item to remove.</param>
		/// <param name="wishlistItemId">Unique identifier of the item to remove from the shopper wish list.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var wishlistitem = new WishlistItem();
		///   wishlistitem.DeleteWishlistItem( wishlistId,  wishlistItemId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteWishlistItem(string wishlistId, string wishlistItemId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.DeleteWishlistItemClient( wishlistId,  wishlistItemId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteWishlistItemAsync(string wishlistId, string wishlistItemId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Wishlists.WishlistItemClient.DeleteWishlistItemClient( wishlistId,  wishlistItemId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


