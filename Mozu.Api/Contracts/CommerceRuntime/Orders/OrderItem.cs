
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	The details associated with a specific item in an order.
		///
		public class OrderItem
		{
			///
			///The adjusted subtotal of the line item, including all manual adjustments, discounts, shipping charges and discounts, and duty or any other additional line item fees.
			///
			public decimal? AdjustedLineItemSubtotal { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Custom data for a given vendor set within the commerce process.
			///
			public JObject Data { get; set; }

			///
			///The subtotal of the cart, order, and wishlist items, including any applied discount calculations. Wishlist subtotals may change depending on the length of time, available discounts, and stock amounts of products at the time of review by shoppers.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to all items in the carts and orders. System-supplied and read-only. This value will be available at the wish list, cart item, order item, and wish list item level at a later time.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///Duty or Tariff for this item
			///
			public decimal? DutyAmount { get; set; }

			///
			///Represents the total price of the cart item extended to the shopper. This begins with the Unit Price, then uses any of the following prices if they are defined, in the following order: Override Amount, Sale Amount, List Amount. This value is not calculated for wish lists at this time.
			///
			public decimal? ExtendedTotal { get; set; }

			///
			///The monetary sum of all fees incurred in the cart, order, line item in a cart, or line item in an order. This value is not calculated for wish lists at this time.
			///
			public decimal? FeeTotal { get; set; }

			///
			///The code that identifies the location used to fulfill the cart/cart item or order/order item. This code can include physical store locations for in-store pickup, warehouse locations providing the products for shipment, or the location for the digital file(s).
			///
			public string FulfillmentLocationCode { get; set; }

			///
			///The method used to fulfill this cart or order item. The method includes direct ship or in-store pickup. The available methods depend on the supported fulfillment types for the product. 
			///
			public string FulfillmentMethod { get; set; }

			///
			///The combined price for all handling costs calculated together for shipped orders, not for digital or in-store pickup. This includes all handling costs per the product line items and options, excluding taxes and discounts. 
			///
			public decimal? HandlingAmount { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:			
			///
			public string Id { get; set; }

			///
			///Indicates if the product in a cart, order, or wish list is purchased on a recurring schedule. If true, the item can be purchased or fulfilled at regular intervals, such as a monthly billing cycle. For example, digital or physical product subscriptions are recurring cart items. This property is not used at this time and is reserved for future functionality.
			///
			public bool? IsRecurring { get; set; }

			///
			///Indicates if the item is subject to taxation, used by products, options, extras, cart and order items, line items, and wish lists. If true, the entity is subject to tax based on the relevant tax rate and rules.
			///
			public bool? IsTaxable { get; set; }

			///
			///The total amount of calculated tax for items, used by carts, orders, and wish lists.
			///
			public decimal? ItemTaxTotal { get; set; }

			///
			///The line id assigned to the order item. Visible only in the Admin, this is set from the Admin or in CommerceRuntime when a cart is converted to an order.
			///
			public int? LineId { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///The unique identifier of the item when it was applied to a cart, prior to checkout, when the cart became an order.
			///
			public string OriginalCartItemId { get; set; }

			///
			///The properties of a product, referenced and used by carts, orders, wish lists, and returns.
			///
			public Product Product { get; set; }

			///
			///The applicable product discount for an associated cart, order, or wish list. 
			///
			public AppliedLineItemProductDiscount ProductDiscount { get; set; }

			///
			///List of product-level discounts projected to apply to a cart, order, or wish list.
			///
			public List<AppliedLineItemProductDiscount> ProductDiscounts { get; set; }

			///
			///The specified quantity of objects and items. This property is used for numerous object types including products, options, components within a product bundle, cart and order items, returned items, shipping line items, items in a digital product. and items associated with types and reservations.
			///
			public int Quantity { get; set; }

			///
			///The total shipping amount for the line item before discounts and adjustments.
			///
			public decimal? ShippingAmountBeforeDiscountsAndAdjustments { get; set; }

			///
			///List of shipping discounts projected to apply to carts, orders, and wish lists and items at checkout.
			///
			public List<AppliedLineItemShippingDiscount> ShippingDiscounts { get; set; }

			///
			///The total amount of tax incurred on the shipping charges in the cart and order. This property is not calculated at this time for wish lists.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///The calculated total shipping amount estimated for carts or orders, including tax. This amount is not calculated for wish lists at this time.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///Estimated amount of the cart or order without sales tax, shipping costs, and other fees. This amount is not calculated for wish lists at this time.
			///
			public decimal? Subtotal { get; set; }

			///
			///The monetary amount of an item in the cart that is subject to tax. This amount typically represents the line item subtotal before applied discounts for an order.
			///
			public decimal? TaxableTotal { get; set; }

			///
			///Leverage this property within a [tax Arc.js action](https://www.mozu.com/docs/arcjs/commerce-catalog-storefront-tax/commerce-catalog-storefront-tax.htm) to supplement the tax information for this item or object with custom JSON data.
			///
			public JObject TaxData { get; set; }

			///
			///Total is used to indicate the monetary, estimated total amount of the cart or order, including items, sales tax, shipping costs, and other fees. Totals are not estimated for wish lists at this time.
			///
			public decimal? Total { get; set; }

			///
			///The total charge for the line item without any weighted order level shipping and handling charges.
			///
			public decimal? TotalWithoutWeightedShippingAndHandling { get; set; }

			///
			///The total charge for the line item with all weighted order level shipping and handling charges.
			///
			public decimal? TotalWithWeightedShippingAndHandling { get; set; }

			///
			///Properties of the price per unit of a product, associated with cart and order items. This price is not used for wish lists at this time.
			///
			public CommerceUnitPrice UnitPrice { get; set; }

			///
			///The total weighted order level manual adjustment amount.
			///
			public decimal? WeightedOrderAdjustment { get; set; }

			///
			///The total weighted order level discount amount.
			///
			public decimal? WeightedOrderDiscount { get; set; }

			///
			///The total weighted order level duty charges.
			///
			public decimal? WeightedOrderDuty { get; set; }

			///
			///The weighted order handling adjustment.
			///
			public decimal? WeightedOrderHandlingAdjustment { get; set; }

			///
			///The total weighted order level handling fee amount.
			///
			public decimal? WeightedOrderHandlingFee { get; set; }

			///
			///The total weighted order handling fee discount amount.
			///
			public decimal? WeightedOrderHandlingFeeDiscount { get; set; }

			///
			///The total weighted order level handling fee tax amount.
			///
			public decimal? WeightedOrderHandlingFeeTax { get; set; }

			///
			///The total weighted order level shipping charge.
			///
			public decimal? WeightedOrderShipping { get; set; }

			///
			///The total weighted order level shipping discount amount.
			///
			public decimal? WeightedOrderShippingDiscount { get; set; }

			///
			///The total weighted order level shipping manual adjustment amount.
			///
			public decimal? WeightedOrderShippingManualAdjustment { get; set; }

			///
			///The total weighted order level shipping tax amount.
			///
			public decimal? WeightedOrderShippingTax { get; set; }

			///
			///The total weighted order level tax amount.
			///
			public decimal? WeightedOrderTax { get; set; }

		}

}