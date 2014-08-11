
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
	/// Use the shipments resource to manage shipments of collections of packages for an order.
	/// </summary>
	public partial class ShipmentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ShipmentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}
				
		/// <summary>
		/// Retrieves the details of the order shipment specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the shipment to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <param name="shipmentId">Unique identifier of the shipment to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   var shipment = shipment.GetShipment( orderId,  shipmentId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment GetShipment(string orderId, string shipmentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.GetShipmentClient( orderId,  shipmentId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> GetShipmentAsync(string orderId, string shipmentId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.GetShipmentClient( orderId,  shipmentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the available shipping methods applicable to the order. Typically used to display available shipping method options on the checkout page.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for the available shipment methods being retrieved.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   var shippingRate = shipment.GetAvailableShipmentMethods( orderId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate> GetAvailableShipmentMethods(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.GetAvailableShipmentMethodsClient( orderId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate>> GetAvailableShipmentMethodsAsync(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.GetAvailableShipmentMethodsClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a shipment from one or more package associated with an order and assign a label and tracking number to an order shipment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for this shipment.</param>
		/// <param name="packageIds">List of unique identifiers for each package associated with this shipment. Not all packages must belong to the same shipment.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   var package = shipment.CreatePackageShipments( packageIds,  orderId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageShipments(List<string> packageIds, string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.CreatePackageShipmentsClient( packageIds,  orderId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> CreatePackageShipmentsAsync(List<string> packageIds, string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.CreatePackageShipmentsClient( packageIds,  orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the shipment specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to cancel shipment.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to cancel.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var shipment = new Shipment();
		///   shipment.DeleteShipment( orderId,  shipmentId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteShipment(string orderId, string shipmentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.DeleteShipmentClient( orderId,  shipmentId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteShipmentAsync(string orderId, string shipmentId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.ShipmentClient.DeleteShipmentClient( orderId,  shipmentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


