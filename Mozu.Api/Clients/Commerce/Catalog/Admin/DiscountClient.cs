
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Discounts resource to define and manage discounts to apply to products, product categories, or orders. The discounts can be a specified amount off the price, percentage off the price, or for free shipping. You can create a coupon code that shoppers can use to redeem the discount.
	/// </summary>
	public partial class DiscountClient 	{
		
		/// <summary>
		/// Retrieves a list of discounts according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscounts(dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var discountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection> GetDiscountsClient(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GetDiscountsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the localized content specified for the specified discount.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscountContent(dataViewMode,  discountId,  responseFields);
		///   var discountLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> GetDiscountContentClient(DataViewMode dataViewMode, int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GetDiscountContentUrl(discountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a single discount.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscount(dataViewMode,  discountId,  responseFields);
		///   var discountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> GetDiscountClient(DataViewMode dataViewMode, int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GetDiscountUrl(discountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Generates a random code for a coupon.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GenerateRandomCoupon( responseFields);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<string> GenerateRandomCouponClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GenerateRandomCouponUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<string>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new discount or coupon to apply to a product, category, order, or shipping.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="discount">Name of the discount added and applied to a shopping cart and order for a shopper's purchase. </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDiscount( discount,  responseFields);
		///   var discountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> CreateDiscountClient(Mozu.Api.Contracts.ProductAdmin.Discount discount, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.CreateDiscountUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Discount>(discount);
			return mozuClient;

		}

		/// <summary>
		/// Updates the localizable content for the specified discount or renames the discount without modifying its other properties.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="content">The container for the language-specific name of the discount. A container exists for each supported language (LocaleCode). This parameter enables you to display the discount name in multiple languages yet manage it as a single discount internally.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDiscountContent( content,  discountId,  responseFields);
		///   var discountLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> UpdateDiscountContentClient(Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent content, int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.UpdateDiscountContentUrl(discountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent>(content);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of the specified discount.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="discount">Name of the discount added and applied to a shopping cart and order for a shopper's purchase. </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDiscount( discount,  discountId,  responseFields);
		///   var discountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> UpdateDiscountClient(Mozu.Api.Contracts.ProductAdmin.Discount discount, int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.UpdateDiscountUrl(discountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Discount>(discount);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a discount specified by its discount ID.
		/// </summary>
		/// <param name="discountId">discountId parameter description DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDiscount( discountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDiscountClient(int discountId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.DeleteDiscountUrl(discountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


