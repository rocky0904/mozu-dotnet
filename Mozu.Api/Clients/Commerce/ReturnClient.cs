
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
	/// Use the Returns resource to manage returned items that were previously fufilled. Returns can include any number of items associated with an original Mozu order. Each return must either be associated with an original order or a product definition to represent each returned item.
	/// </summary>
	public partial class ReturnClient 	{
		
		/// <summary>
		/// Retrieves a list of all returns according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturns( startIndex,  pageSize,  sortBy,  filter,  q,  responseFields);
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> GetReturnsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnsUrl(startIndex, pageSize, sortBy, filter, q, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the actions available to perform for the specified return based on its current state.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return for which to retrieve available actions.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableReturnActions( returnId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableReturnActionsClient(string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetAvailableReturnActionsUrl(returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId"></param>
		/// <param name="returnItemId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnItem( returnId,  returnItemId,  responseFields);
		///   var returnItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem> GetReturnItemClient(string returnId, string returnItemId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnItemUrl(returnId, returnItemId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturnItems( returnId,  responseFields);
		///   var returnItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection> GetReturnItemsClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnItemsUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItemCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the payment actions available to perform for the specified return when a return results in a refund to the customer.
		/// </summary>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="returnId">Unique identifier of the return associated with the payment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePaymentActionsForReturn( returnId,  paymentId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePaymentActionsForReturnClient(string returnId, string paymentId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetAvailablePaymentActionsForReturnUrl(returnId, paymentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a payment submitted as part of a refund associated with a customer return.
		/// </summary>
		/// <param name="paymentId">Unique identifier of the return payment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return associated with the payment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayment( returnId,  paymentId,  responseFields);
		///   var paymentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentClient(string returnId, string paymentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetPaymentUrl(returnId, paymentId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of all payments submitted as part of a refund associated with a customer return.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Returns the details of the refund payment associated with the return specified in the request.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayments( returnId,  responseFields);
		///   var paymentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetPaymentsUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of properties for the specified return.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Returns the properties of the return specified in the request as well as system-supplied information.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturn( returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> GetReturnClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnUrl(returnId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReasons( responseFields);
		///   var reasonCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection> GetReasonsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReasonsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReasonCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a return for previously fulfilled items. Each return must either be associated with an original order or a product definition to represent each returned item.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="ret">Wrapper for the properties of the return to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturn( ret,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnClient(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>(ret);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId"></param>
		/// <param name="returnItem"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturnItem( returnItem,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnItemClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem returnItem, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnItemUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnItem>(returnItem);
			return mozuClient;

		}

		/// <summary>
		/// Updates a refund payment associated with a customer return by performing the specified action.
		/// </summary>
		/// <param name="paymentId">Unique identifier of the return payment to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return associated with the refund payment.</param>
		/// <param name="action">The payment action to perform for the refund payment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformPaymentActionForReturn( action,  returnId,  paymentId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> PerformPaymentActionForReturnClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string paymentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.PerformPaymentActionForReturnUrl(returnId, paymentId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// Creates a new payment for a return that results in a refund to the customer.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return associated with the payment action.</param>
		/// <param name="action">The payment action to perform for the customer return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePaymentActionForReturn( action,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreatePaymentActionForReturnClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreatePaymentActionForReturnUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="returnId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturnShippingOrder( returnId,  responseFields);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateReturnShippingOrderClient(string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnShippingOrderUrl(returnId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the return by performing the action specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="action">The name of the return action to perform, such as "Reject" or "Authorize".</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformReturnActions( action,  responseFields);
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> PerformReturnActionsClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.PerformReturnActionsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a return for items previously shipped in a completed order.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="returnId">Unique identifier of the return.</param>
		/// <param name="ret">Wrapper for the array of properties to update for the return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateReturn( ret,  returnId,  responseFields);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> UpdateReturnClient(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string returnId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.UpdateReturnUrl(returnId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>(ret);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="action"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendReturnEmail( action);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient ResendReturnEmailClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.ResendReturnEmailUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction>(action);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId"></param>
		/// <param name="returnItemId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderItem( returnId,  returnItemId);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> DeleteOrderItemClient(string returnId, string returnItemId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.DeleteOrderItemUrl(returnId, returnItemId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the return specified in the request.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteReturn( returnId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteReturnClient(string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.DeleteReturnUrl(returnId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


