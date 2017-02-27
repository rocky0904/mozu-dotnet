
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
			public bool AllowFilteringAndSortingInStorefront { get; set; }

			///
			///The data type (such as datetime or string) associated with the attribute.
			///
			public string DataType { get; set; }

			///
			///Unique sequence of the attribute for its data type.
			///
			public int DataTypeSequence { get; set; }

			///
			///Description of the attribute in the language specified by the locale code.
			///
			public string Description { get; set; }

			public string DisplayIntention { get; set; }

			///
			///The input type (such as date or text area) accepted for the attribute's data type.
			///
			public string InputType { get; set; }

			///
			///Name of the atrribute in the language specified by the locale code.
			///
			public string Name { get; set; }

			///
			///Indicates whether the attribute value is searchable in the storefont by a shopper.
			///
			public bool SearchableInStorefront { get; set; }

			///
			///If true, the system indexes the display value of string attributes instead of the canonical value for searching. The canonical value is always used for filtering. This does not apply for for non-string attributes.
			///
			public bool SearchDisplayValue { get; set; }

			///
			///The usage type of the product attribute, which is property, option, or extra.
			///
			public string UsageType { get; set; }

			///
			///Validation rules of an attribute that determine which values are valid for ShopperEntered and AdminEntered ValueTypes.
			///
			public AttributeValidation Validation { get; set; }

			///
			///The type of value for the attribute, which is either ShopperEntered, AdminEntered, or Predefined.
			///
			public string ValueType { get; set; }

		}

}