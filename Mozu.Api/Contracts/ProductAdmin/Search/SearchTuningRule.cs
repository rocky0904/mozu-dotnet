
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

namespace Mozu.Api.Contracts.ProductAdmin.Search
{
		///
		///	Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE 
		///
		public class SearchTuningRule
		{
			///
			///Specifies whether the search results tuning rule is active.
			///
			public bool Active { get; set; }

			///
			///The date that the search tuning rule is no longer active.
			///
			public DateTime? ActiveEndDate { get; set; }

			///
			///The date the search tuning rule starts being active.
			///
			public DateTime? ActiveStartDate { get; set; }

			///
			///Basic audit info about the object, including date, time, and user account. This data may be captured when creating, updating, and removing data.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///A list of product codes that you wish to block from appearing on a search result, or on a specific category page. Use the filters field to specify a category page.
			///
			public List<string> BlockedProductCodes { get; set; }

			///
			///A list of product codes that you wish to explicitly boost using the search tuning rule.  The order that you list products in defines the order that they appear in a search result, or category page.
			///
			public List<string> BoostedProductCodes { get; set; }

			///
			///The filters that limit what the search tuning rule is applied to. Currently, the only supported filters are category pages.For example, you can limit the search tuning rule to only apply when a shopper either navigates to or searches for a specific keyword on a category page.
			///
			public List<SearchTuningRuleFilter> Filters { get; set; }

			///
			///Indicates if the object is default. This indicator is used for product variations and site search settings. If true, the value/object is the default option. 
			///
			public bool IsDefault { get; set; }

			///
			///The keywords that trigger the search tuning rule. These are specific keywords that shoppers search for.
			///
			public List<string> Keywords { get; set; }

			///
			///The unique identifier of the search tuning rule.
			///
			public string SearchTuningRuleCode { get; set; }

			///
			///The description of the search tuning rule. Use this field for further identification purposes.
			///
			public string SearchTuningRuleDescription { get; set; }

			///
			///The name of the search tuning rule. Use this field for further identification purposes.
			///
			public string SearchTuningRuleName { get; set; }

			///
			///Unique identifier for the site. This ID is used at all levels of a store, catalog, and tenant to associate objects to a site.
			///
			public int SiteId { get; set; }

		}

}