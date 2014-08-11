
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class PickupUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAvailablePickupFulfillmentActions
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the pickup.</param>
        /// <param name="pickupId">Unique identifier of the pickup for which to retrieve available actions.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailablePickupFulfillmentActionsUrl(string orderId, string pickupId)
		{
			var url = "/api/commerce/orders/{orderId}/pickups/{pickupId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "pickupId", pickupId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPickup
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the pickup.</param>
        /// <param name="pickupId">Unique identifier of the pickup to retrieve.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPickupUrl(string orderId, string pickupId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/pickups/{pickupId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "pickupId", pickupId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreatePickup
        /// </summary>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePickupUrl(string orderId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/pickups?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdatePickup
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the in-store pickup.</param>
        /// <param name="pickupId">Unique identifier of the pickup to update.</param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePickupUrl(string orderId, string pickupId, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/pickups/{pickupId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "pickupId", pickupId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeletePickup
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the pickup.</param>
        /// <param name="pickupId">Unique identifier of the pickup to remove.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePickupUrl(string orderId, string pickupId)
		{
			var url = "/api/commerce/orders/{orderId}/pickups/{pickupId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "pickupId", pickupId);
			return mozuUrl;
		}

		
	}
}

