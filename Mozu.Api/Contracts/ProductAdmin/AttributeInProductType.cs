
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
		///	Properties of an attribute definition associated with a specific product type. When an attribute is applied to a product type, each product of that type maintains the same set of attributes.
		///
		public class AttributeInProductType
		{
			///
			///The wrapper for the properties of the product attribute to set up or generate from the system in the product admin. Properties include namespace, attribute code, attribute sequence, site group ID, input type, value type, data type, boolean flags, and metadata key value pairs.
			///
			public Attribute AttributeDetail { get; set; }

			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			public AttributeInProductTypeDisplayInfo DisplayInfo { get; set; }

			public bool? IsAdminOnlyProperty { get; set; }

			///
			///If true, this property is hidden on the storefront. If false, this property is not hidden from the storefront.
			///
			public bool? IsHiddenProperty { get; set; }

			///
			///If true, this entity is inherited from the base type. If false, this entity is not inherited from the base type.
			///
			public bool? IsInheritedFromBaseType { get; set; }

			///
			///If true, this attribute has more than one possible value.
			///
			public bool? IsMultiValueProperty { get; set; }

			public bool? IsProductDetailsOnlyProperty { get; set; }

			///
			///If true, the entity is required by the admin. If false, the entity is not required by the admin.
			///
			public bool? IsRequiredByAdmin { get; set; }

			///
			///The sequence of this attribute within its product type.
			///
			public int? Order { get; set; }

			///
			///The list of vocabulary values available for the attribute associated with the product type.
			///
			public List<AttributeVocabularyValueInProductType> VocabularyValues { get; set; }

		}

}