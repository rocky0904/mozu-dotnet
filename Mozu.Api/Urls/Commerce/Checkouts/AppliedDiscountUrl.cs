
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

namespace Mozu.Api.Urls.Commerce.Checkouts
{
	public partial class AppliedDiscountUrl 
	{

						/// <summary>
        /// Get Resource Url for ApplyCoupon
        /// </summary>
        /// <param name="checkoutId">The unique identifier of the checkout.</param>
        /// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ApplyCouponUrl(string checkoutId, string couponCode, string responseFields =  null)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/coupons/{couponCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			mozuUrl.FormatUrl( "couponCode", couponCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RemoveCoupons
        /// </summary>
        /// <param name="checkoutId">The unique identifier of the checkout.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveCouponsUrl(string checkoutId)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/coupons";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for RemoveCoupon
        /// </summary>
        /// <param name="checkoutId">The unique identifier of the checkout.</param>
        /// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveCouponUrl(string checkoutId, string couponCode)
		{
			var url = "/api/commerce/checkouts/{checkoutId}/coupons/{couponcode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "checkoutId", checkoutId);
			mozuUrl.FormatUrl( "couponCode", couponCode);
			return mozuUrl;
		}

		
	}
}

