
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use this subresource to view which order items are eligible for return.
	/// </summary>
	public partial class OrderReturnableItemResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderReturnableItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderReturnableItemResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderReturnableItemResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves information about which items are eligible for return on an order.Each item displays the following information:



		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderReturnableItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderreturnableitem = new OrderReturnableItem();
		///   var orderReturnableItemCollection = orderreturnableitem.GetOrderReturnableItems( orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderReturnableItemCollection GetOrderReturnableItems(string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderReturnableItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderReturnableItemClient.GetOrderReturnableItemsClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves information about which items are eligible for return on an order.Each item displays the following information:



		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderReturnableItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderreturnableitem = new OrderReturnableItem();
		///   var orderReturnableItemCollection = await orderreturnableitem.GetOrderReturnableItemsAsync( orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderReturnableItemCollection> GetOrderReturnableItemsAsync(string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderReturnableItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderReturnableItemClient.GetOrderReturnableItemsClient( orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


