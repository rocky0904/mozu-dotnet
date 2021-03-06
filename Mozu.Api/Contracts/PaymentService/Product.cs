
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.PaymentService
{
		///
		///	The properties of a product, referenced and used by carts, orders, wish lists, and returns.
		///
		public class Product
		{
			///
			///The unique, user-defined product code of a product, used throughout  to reference and associate to a product.
			///
			public string ProductCode { get; set; }

			///
			///The name of the product that represents a line item in a taxable order or product bundle.
			///
			public string ProductName { get; set; }

			///
			///For configurable products, the unique identifier of the product variation that has been selected.
			///
			public string VariantProductCode { get; set; }

		}

}