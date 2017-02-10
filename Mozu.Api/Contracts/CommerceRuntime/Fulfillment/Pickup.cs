
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

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of an in-store pickup defined to fulfill items in an order.
		///
		public class Pickup
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Available actions you can complete for an order. These actions may differ depending on the status of the order, such as actions required to enter a payment, return of a package, and fulfillment of a shipment.
			///
			public List<string> AvailableActions { get; set; }

			///
			///Collection (list or paged) of change messages logged for each modification made by a shopper to their carts, wishlists, orders, package, payment, pickup, and returns. Change log messages are system-supplied based on shopper actions and read only.
			///
			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///The specific code that represents pickup.
			///
			public string Code { get; set; }

			///
			///Date and time when a shipment completes fulfillment by delivery to a customer's physical address, picked up by a customer at a store, or delivered digitally for downloadable products.
			///
			public DateTime? FulfillmentDate { get; set; }

			///
			///The code that identifies the location used to fulfill the cart/cart item or order/order item. This code can include physical store locations for in-store pickup, warehouse locations providing the products for shipment, or the location for the digital file(s).
			///
			public string FulfillmentLocationCode { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:			
			///
			public string Id { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<PickupItem> Items { get; set; }

			///
			///The current status of the object.This value is read only. Valid values for this field are: "Active", "Expired", and "Inactive".
			///
			public string Status { get; set; }

		}

}