
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Specifies the target on a payment action or on an interaction
		///
		public class PaymentActionTarget
		{
			///
			///The Id of the checkout/order to target.
			///
			public string TargetId { get; set; }

			///
			///The number of the checkout/order to target.
			///
			public int? TargetNumber { get; set; }

			///
			///Specifies if the TargetId is a checkout Id or order Id.
			///
			public string TargetType { get; set; }

		}

}