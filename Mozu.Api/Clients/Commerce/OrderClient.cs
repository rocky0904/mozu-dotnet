
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

namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// Use the Orders resource to manage all components of order processing, payment, and fulfillment.
	/// </summary>
	public partial class OrderClient 	{
		
		/// <summary>
		/// Retrieves a list of orders according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrders( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		///   var orderCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> GetOrdersClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetOrdersUrl(startIndex, pageSize, sortBy, filter, q, qLimit, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the actions available to perform for an order based on its current status.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableActions( orderId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableActionsClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetAvailableActionsUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves an order for the purpose of splitting it into multiple taxable orders in order to fulfill the order in multiple locations.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.PricingRuntime.TaxableOrder"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTaxableOrders( orderId);
		///   var taxableOrderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> GetTaxableOrdersClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetTaxableOrdersUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of an order specified by the order ID.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrder( orderId,  draft,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> GetOrderClient(string orderId, bool? draft =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.GetOrderUrl(orderId, draft, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new order from an existing cart when the customer chooses to proceed to checkout.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderFromCart( cartId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderFromCartClient(string cartId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.CreateOrderFromCartUrl(cartId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new order for no-cart quick-ordering scenarios.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="order">Properties of an order, including its components.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrder( order,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderClient(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.CreateOrderUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>(order);
			return mozuClient;

		}

		/// <summary>
		/// Perform the specified action for an order. The actions you can perform depend on the current status of the order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="action">The action to perform for the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformOrderAction( action,  orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformOrderActionClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.PerformOrderActionUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="digitalWalletType"></param>
		/// <param name="orderId"></param>
		/// <param name="responseFields"></param>
		/// <param name="digitalWallet"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ProcessDigitalWallet( digitalWallet,  orderId,  digitalWalletType,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ProcessDigitalWalletClient(Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet digitalWallet, string orderId, string digitalWalletType, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ProcessDigitalWalletUrl(orderId, digitalWalletType, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.DigitalWallet>(digitalWallet);
			return mozuClient;

		}

		/// <summary>
		/// Update the properties of a discount applied to an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="discount">Properties of all applied discounts for an associated cart, order, or product. </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderDiscount( discount,  orderId,  discountId,  updateMode,  version,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderDiscountClient(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.UpdateOrderDiscountUrl(orderId, discountId, updateMode, version, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount>(discount);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the current draft version of the order, which also deletes any uncommitted changes made to the order in draft mode.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="version">Determines whether or not to check versioning of items for concurrency purposes.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderDraft( orderId,  version);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteOrderDraftClient(string orderId, string version =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.DeleteOrderDraftUrl(orderId, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// commerce-orders Put ResendOrderConfirmationEmail description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="action">The action to perform for the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendOrderConfirmationEmail( action,  orderId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient ResendOrderConfirmationEmailClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ResendOrderConfirmationEmailUrl(orderId);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// Updates the user ID of the shopper who placed the order to the current user.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangeOrderUserId( orderId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ChangeOrderUserIdClient(string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.ChangeOrderUserIdUrl(orderId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the specified order when additional order information, such as shipping or billing information, is modified during the checkout process.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="order">Properties of an order, including its components.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrder( order,  orderId,  updateMode,  version,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderClient(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.OrderUrl.UpdateOrderUrl(orderId, updateMode, version, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>(order);
			return mozuClient;

		}


	}

}


