
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Mozu.ProductAdmin.Contracts.PriceListEntryExtra ApiType DOCUMENT_HERE 
		///
		public class PriceListEntryExtra
		{
			///
			///Merchant-defined code for an extensible attribute. This code may be used to generate an object's fully qualified name, such as for products.
			///
			public string AttributeCode { get; set; }

			///
			///The fully qualified name of the attribute. The attributeDefiniteId may be used to generate this name.
			///
			public string AttributeFQN { get; set; }

			///
			///Name of attribute that this extra is based on. ReadOnly
			///
			public string AttributeName { get; set; }

			///
			///Value to display. Currently only vaild when Value is a string type. ReadOnly
			///
			public string DisplayValue { get; set; }

			///
			///PriceList price for the extra
			///
			public decimal Price { get; set; }

			///
			///The value of a property, used by numerous objects within  including facets, attributes, products, localized content, metadata, capabilities ( and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public object Value { get; set; }

		}

}