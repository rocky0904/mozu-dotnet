
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of an extra attribute to defined for a product that is associated with a product type that uses the extra. Setting up extras for a product enables shopper-entered information, such as initials for a monogram.
		///
		public class ProductExtra
		{
			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///If true, the shopper can select more than one value from a predefined list for this extra.
			///
			public bool? IsMultiSelect { get; set; }

			///
			///If true, the shopper must select the product extra and specify a value for it during checkout.
			///
			public bool? IsRequired { get; set; }

			///
			///The list of predefined values a shopper can select for the product when defining this extra.
			///
			public List<ProductExtraValue> Values { get; set; }

		}

}