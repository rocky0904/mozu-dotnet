
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


namespace Mozu.Api.Contracts.Customer
{
		///
		///	Paged list of customer accounts sorted and filtered by any query parameters specified in the request.
		///
		public class CustomerAccountCollection
		{
			public List<CustomerAccount> Items { get; set; }

			public int PageCount { get; set; }

			public int PageSize { get; set; }

			public int StartIndex { get; set; }

			public int TotalCount { get; set; }

		}

}