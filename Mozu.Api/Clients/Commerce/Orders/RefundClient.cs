
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the refunds resource to create a refund.
	/// </summary>
	public partial class RefundClient 	{
		
		/// <summary>
		/// Creates a refund based on the information supplied in the request.  
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="refund">The details of the refund.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateRefund( refund,  orderId,  responseFields);
		///   var refundClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund> CreateRefundClient(Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund refund, string orderId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.RefundUrl.CreateRefundUrl(orderId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund>(refund);
			return mozuClient;

		}

		/// <summary>
		/// Resends the order refund email previously sent to the shopper. 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="refundId">Unique ID of the refund.        </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResendRefundEmail( orderId,  refundId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient ResendRefundEmailClient(string orderId, string refundId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.RefundUrl.ResendRefundEmailUrl(orderId, refundId);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


