
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin.Search
{
		///
		///	Mozu.ProductAdmin.Contracts.Search.SearchTuningRuleFilter ApiType DOCUMENT_HERE 
		///
		public class SearchTuningRuleFilter
		{
			///
			///Mozu.ProductAdmin.Contracts.Search.SearchTuningRuleFilter field ApiTypeMember DOCUMENT_HERE 
			///
			public string Field { get; set; }

			///
			///The value of a property, used by numerous objects within  including facets, attributes, products, localized content, metadata, capabilities ( and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public string Value { get; set; }

		}

}