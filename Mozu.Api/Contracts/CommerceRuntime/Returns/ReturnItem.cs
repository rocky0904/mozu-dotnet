
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

using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Products;

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of a previously fulfilled item associated with a return.
		///
		public class ReturnItem
		{
			///
			///Properties of a collection of component products that make up a single product bundle with its own product code. Tenants can define product bundles for any product type that supports the Bundle product usage.
			///
			public List<ReturnBundle> BundledProducts { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:			
			///
			public string Id { get; set; }

			///
			///Paged list collection of note content for objects including customers, orders, and returns. 
			///
			public List<OrderNote> Notes { get; set; }

			///
			///Unique identifier of the order item associated with a validation message, order, or return.
			///
			public string OrderItemId { get; set; }

			///
			///This is the Option attribute FQN for the item being returned .. typically only when the return item is a product bundle item.
			///
			public string OrderItemOptionAttributeFQN { get; set; }

			///
			///The OrderLineId that this ReturnItem is associated with. If order item is present, the orderLineId should be present also.
			///
			public int? OrderLineId { get; set; }

			///
			///The properties of a product, referenced and used by carts, orders, wish lists, and returns.
			///
			public Product Product { get; set; }

			///
			///The total value of the product returned to the merchant for accounting purposes, calculated by multiplying the cost of the item by its quantity returned.
			///
			public decimal? ProductLossAmount { get; set; }

			///
			///The total tax amount levied on the product loss amount.
			///
			public decimal? ProductLossTaxAmount { get; set; }

			///
			///The actual quantity received for the return item.
			///
			public int QuantityReceived { get; set; }

			///
			///The quantity of the given line item that will be replaced.
			///
			public int? QuantityReplaced { get; set; }

			///
			///The quantity of returned items that can be returned to active product stock.
			///
			public int QuantityRestockable { get; set; }

			///
			///The quantity of the item shipped to the shopper in the event of a return item replacement.
			///
			public int QuantityShipped { get; set; }

			///
			///The list of return reasons for the item and the quantity associated with each return reason.
			///
			public List<ReturnReason> Reasons { get; set; }

			///
			///The status that indicates whether the shopper has returned the item. The accepted values are , , or .
			///
			public string ReceiveStatus { get; set; }

			///
			///The amount of the refund.
			///
			public decimal? RefundAmount { get; set; }

			///
			///The status of the refund for the item. The accepted values are  if the shopper only wants a replacement or  if either a partial or full refund is applied to the item.
			///
			public string RefundStatus { get; set; }

			///
			///The status of the replacement order for the item. The accepted values are  if there is no replacement order or  if a replacement order exits.
			///
			public string ReplaceStatus { get; set; }

			///
			///A Boolean that indicates whether the item requires the shopper to return the item.
			///
			public bool ReturnNotRequired { get; set; }

			///
			///The type of the return for the item. Either  or .
			///
			public string ReturnType { get; set; }

			///
			///The total value of shipping the returned product to the merchant for accounting purposes, calculated by multiplying the shipping cost of the item by its quantity returned.
			///
			public decimal? ShippingLossAmount { get; set; }

			///
			///The total tax amount levied on the shipping loss amount.
			///
			public decimal? ShippingLossTaxAmount { get; set; }

			///
			///The total cost without shipping and handling applied.
			///
			public decimal? TotalWithoutWeightedShippingAndHandling { get; set; }

			///
			///The total cost with shipping and handling applied.
			///
			public decimal? TotalWithWeightedShippingAndHandling { get; set; }

		}

}