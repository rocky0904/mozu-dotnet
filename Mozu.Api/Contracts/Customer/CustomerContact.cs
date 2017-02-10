
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

namespace Mozu.Api.Contracts.Customer
{
		///
		///	Contact information, including the contact's name, address, phone numbers, email addresses, and company (if supplied). Also indicates whether this is a billing, shipping, or billing and shipping contact.
		///
		public class CustomerContact
		{
			///
			///Unique identifier of the customer account generated by the system. Account IDs are generated at account creation.
			///
			public int AccountId { get; set; }

			///
			///Address information to supply for a contact.
			///
			public Address Address { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The legal or doing business as (DBA) or tradestyle name of the business or organization. The maximum character length is 200.
			///
			public string CompanyOrOrganization { get; set; }

			///
			///The email address of the specified user or the email address associated with the specified entity.
			///
			public string Email { get; set; }

			///
			///The fax number associated with the customer account.
			///
			public string FaxNumber { get; set; }

			///
			///The first name of the contact. The maximum character length is 200.
			///
			public string FirstName { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:			
			///
			public int Id { get; set; }

			///
			///Descriptive text used as a label for objects, such as field names, facets, date ranges, contact information, and package information.
			///
			public string Label { get; set; }

			///
			///The last name or surname of the contact. The maximum character length is 200.
			///
			public string LastNameOrSurname { get; set; }

			///
			///The middle name or the first initial of the middle name of the contact. The maximum character length is 100.
			///
			public string MiddleNameOrInitial { get; set; }

			///
			///List of phone numbers associated with the customer account contact. The phone numbers include area codes.
			///
			public Phone PhoneNumbers { get; set; }

			///
			///List of the types associated with a customer contact, such as Billing or Fulfillment.
			///
			public List<ContactType> Types { get; set; }

		}

}