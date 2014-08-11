
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of an item shipped in a physical package.
		///
		public class PackageItem
		{
			public string FulfillmentItemType { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///The quantity of an item shipped in the specified package.
			///
			public int Quantity { get; set; }

		}

}