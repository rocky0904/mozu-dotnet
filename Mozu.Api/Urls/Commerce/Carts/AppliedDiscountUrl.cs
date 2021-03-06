
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Carts
{
	public partial class AppliedDiscountUrl 
	{

						/// <summary>
        /// Get Resource Url for ApplyCoupon
        /// </summary>
        /// <param name="cartId">Identifier of the cart to delete.</param>
        /// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ApplyCouponUrl(string cartId, string couponCode, string responseFields =  null)
		{
			var url = "/api/commerce/carts/{cartId}/coupons/{couponCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cartId", cartId);
			mozuUrl.FormatUrl( "couponCode", couponCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RemoveCoupons
        /// </summary>
        /// <param name="cartId">Identifier of the cart to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveCouponsUrl(string cartId)
		{
			var url = "/api/commerce/carts/{cartId}/coupons";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cartId", cartId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for RemoveCoupon
        /// </summary>
        /// <param name="cartId">Identifier of the cart to delete.</param>
        /// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveCouponUrl(string cartId, string couponCode)
		{
			var url = "/api/commerce/carts/{cartId}/coupons/{couponcode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "cartId", cartId);
			mozuUrl.FormatUrl( "couponCode", couponCode);
			return mozuUrl;
		}

		
	}
}

