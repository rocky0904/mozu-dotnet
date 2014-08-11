
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Localized page content for a product category.
		///
		public class CategoryContent
		{
			///
			///The localized description of the category to display on a storefront.
			///
			public string Description { get; set; }

			///
			///Defined description of the metadata used to manage product information internally, such as search engine optimization.
			///
			public string MetaTagDescription { get; set; }

			///
			///Defined keywords of the metadata used to manage product information internally, such as search engine optimization.
			///
			public string MetaTagKeywords { get; set; }

			///
			///Defined title of the metadata used to manage product information internally, such as search engine optimization.
			///
			public string MetaTagTitle { get; set; }

			///
			///Name of the product category.
			///
			public string Name { get; set; }

			///
			///Title that appears on the top of new pages associated with the product category on the storefront.
			///
			public string PageTitle { get; set; }

			///
			///Human-readable identifier to associated with a product category to create friendly URLs.
			///
			public string Slug { get; set; }

			///
			///Array list of image media associated with the product category.
			///
			public List<CategoryImage> CategoryImages { get; set; }

		}

}