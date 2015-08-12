
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Properties of the billing information entered for an order during checkout.
		///
		public class BillingInfo
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The cardholder's billing contact information, including addresses.
			///
			public Contact BillingContact { get; set; }

			///
			///If the customer is paying by card, the credit card information.
			///
			public PaymentCard Card { get; set; }

			///
			///If true, the system overrides the customer's billing address information with the supplied fulfillment information.
			///
			public bool IsSameBillingShippingAddress { get; set; }

			///
			///The type of payment, such as credit card, check, or PayPal Express. Additional payment types will be supported in future releases.
			///
			public string PaymentType { get; set; }

			public string PaymentWorkflow { get; set; }

			///
			///The code that identifies the store credit to apply to the order.
			///
			public string StoreCreditCode { get; set; }

		}

}