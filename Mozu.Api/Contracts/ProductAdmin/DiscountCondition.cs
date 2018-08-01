
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of the conditions that must be met for a discount to apply to an order.
		///
		public class DiscountCondition
		{
			///
			///categoriesToExcludeFromMinOrderTotal ApiType DOCUMENT_HERE 
			///
			public List<CategoryDiscountCondition> CategoriesToExcludeFromMinOrderTotal { get; set; }

			///
			///The coupon code that a shopper uses to redeem an associated discount  on a purchase. This is also the unique identifier of the coupon itself.
			///
			public string CouponCode { get; set; }

			///
			///List of customer segments associated with the discount. Shoppers who are members of an associated customer segment can redeem this discount.
			///
			public List<CustomerSegment> CustomerSegments { get; set; }

			///
			///List of the product categories that are not eligible for the discount.
			///
			public List<CategoryDiscountCondition> ExcludedCategories { get; set; }

			///
			///List of products that are not eligible for the discount.
			///
			public List<ProductDiscountCondition> ExcludedProducts { get; set; }

			///
			///Date and time in UTC format when a discount, credit, wish list, or cart expires. An expired discount no longer can be redeemed. An expired wish list is no longer available. An expired credit can no longer be redeemed for a purchase. Acart becomes inactive and expired based on a system-calculated interval. For example, if an anonymous shopper has 14 days of inactivity, the cart is considered abandoned after that period of inactivity. System-supplied and read-only.
			///
			public DateTime? ExpirationDate { get; set; }

			///
			///List of product categories that are eligible for the discount.
			///
			public List<CategoryDiscountCondition> IncludedCategories { get; set; }

			///
			///List of payment types that trigger this discount to be valid.
			///
			public List<string> IncludedPaymentWorkflows { get; set; }

			///
			///List of products that are eligible for the discount.
			///
			public List<ProductDiscountCondition> IncludedProducts { get; set; }

			///
			///The maximum number of times the discount can be redeemed.
			///
			public int? MaxRedemptionCount { get; set; }

			///
			///This specifies the minimum amount that must be purchased in the combined categories defined in IncludedCategories. This amount is calculated before discounting and it is not used if IncludedCategories is empty.
			///
			public decimal? MinimumCategorySubtotalBeforeDiscounts { get; set; }

			///
			///The minimum customer lifetime value amount required to redeem this discount.
			///
			public decimal? MinimumLifetimeValueAmount { get; set; }

			///
			///The minimum order amount required to redeem this discount.
			///
			public decimal? MinimumOrderAmount { get; set; }

			///
			///This specifies the minimum quantity of products in the categories specified in IncludedCategories, which must be purchased to qualify for the associated discount. This defaults to 1 if null, and IncludedCategories has values.
			///
			public int? MinimumQuantityProductsRequiredInCategories { get; set; }

			///
			///This specifies the minimum quantity of products in the specified IncludedProducts that must be purchased to qualify for the associated discount. This defaults to 1 if null, and IncludedProducts has values.
			///
			public int? MinimumQuantityRequiredProducts { get; set; }

			public int? MinimumRequiredQuantityPerRedemption { get; set; }

			///
			///productsToExcludeFromMinOrderTotal ApiType DOCUMENT_HERE 
			///
			public List<ProductDiscountCondition> ProductsToExcludeFromMinOrderTotal { get; set; }

			///
			///If true, only authenticated users can redeem the discount. If false, anonymous users can redeem the discount.
			///
			public bool RequiresAuthenticatedUser { get; set; }

			///
			///If true, redemption of this discount requires entry of a coupon code.
			///
			public bool RequiresCoupon { get; set; }

			///
			///The earliest date and time this discount can be redeemed.
			///
			public DateTime? StartDate { get; set; }

		}

}