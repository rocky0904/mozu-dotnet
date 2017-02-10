
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


namespace Mozu.Api.Contracts.PricingRuntime
{
		///
		///	Details of a property defined for a product.
		///
		public class ProductProperty
		{
			///
			///The product attribute details common between all attribute types - properties, options, and extras.
			///
			public ProductAttribute AttributeDetail { get; set; }

			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///Indicates if the object is hidden or breaks inheritance, primarily used by facets, products, and attribute vocabulary values. For example, if true, the attribute vocabulary value does not appear in the list when defining a value for an attribute.
			///
			public bool? IsHidden { get; set; }

			///
			///Indicates if the object has or can have multiple properties or values. If true, the object can have more than one value, selectable by shoppers through the storefront or configurable through the catalogs. 
			///
			public bool? IsMultiValue { get; set; }

			///
			///List of value data for objects.
			///
			public List<ProductPropertyValue> Values { get; set; }

		}

}