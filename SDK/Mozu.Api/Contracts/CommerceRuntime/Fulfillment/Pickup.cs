
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

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.CommerceRuntime.Commerce;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of an in-store pickup defined to fulfill items in an order.
		///
		public class Pickup
		{
			///
			///Array list of actions that can be performed for the in-store pickup.
			///
			public List<string> AvailableActions { get; set; }

			public string Code { get; set; }

			///
			///The date and time the customer picked up the order items.
			///
			public DateTime? FulfillmentDate { get; set; }

			public string FulfillmentLocationCode { get; set; }

			///
			///Unique identifier of the in-store pickup.
			///
			public string Id { get; set; }

			///
			///The fulfillment status of the in-store pickup, which is "Fulfilled," "NotFulfilled," or "PartiallyFulfilled."
			///
			public string Status { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<PickupItem> Items { get; set; }

		}

}