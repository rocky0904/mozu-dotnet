
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The product attribute details common between all attribute types - properties, options, and extras.
		///
		public class AttributeDetail
		{
			///
			///Indicates whether the attribute should be able to be used in filters, facets, and sorting on the public storefront.
			///
			public bool AllowFilteringAndSortingInStorefront { get; set; }

			///
			///When set to true, enables you to set a custom search weight for a product attribute in search-settings.
			///
			public bool? CustomWeightInStorefrontSearch { get; set; }

			public string DataType { get; set; }

			public int DataTypeSequence { get; set; }

			public string Description { get; set; }

			///
			///Defines the intended display of this attribute in the storefront. Options include Drop Down, Image Picker, and Radio Buttons.
			///
			public string DisplayIntention { get; set; }

			///
			///Specifies whether to create a case-sensitive Solr search index. The default is .
			///
			public bool? IndexValueWithCase { get; set; }

			public string InputType { get; set; }

			public string Name { get; set; }

			///
			///Indicates if the attribute value is searchable on the public storefront.
			///
			public bool SearchableInStorefront { get; set; }

			///
			///Indicates what kind of values search queries and returns. If true, the system indexes the display value of string attributes instead of the canonical value for searching. Always use the canonical value for filtering. This does not apply for non-string attributes.
			///
			public bool SearchDisplayValue { get; set; }

			public string UsageType { get; set; }

			public AttributeValidation Validation { get; set; }

			public string ValueType { get; set; }

		}

}