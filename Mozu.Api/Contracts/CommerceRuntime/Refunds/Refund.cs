
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Refunds
{
		///
		///	Mozu.CommerceRuntime.Contracts.Refunds.Refund ApiType DOCUMENT_HERE 
		///
		public class Refund
		{
			///
			///Amount refunded.
			///
			public decimal Amount { get; set; }

			///
			///Basic audit info about the object, including date, time, and user account. This data may be captured when creating, updating, and removing data.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:			
			///
			public string Id { get; set; }

			///
			///Unique identifier of the order associated with the payment.
			///
			public string OrderId { get; set; }

			///
			///The payment associated with this refund (if applicable).
			///
			public Payment Payment { get; set; }

			///
			///The reason description for an action, including item return, coupon not valid, and item is taxed. 
			///
			public string Reason { get; set; }

		}

}