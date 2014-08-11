
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Customer.Credits
{
	/// <summary>
	/// Use the Customer Credit Transactions subresource to manage the individual transactions performed using a store credit or gift card.
	/// </summary>
	public partial class CreditTransactionClient 	{
		
		/// <summary>
		/// Retrieves a list of the transactions performed using a customer credit that update the balance of the credit.
		/// </summary>
		/// <param name="code">User-defined code that identifies the customer credit.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTransactions( code,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var creditTransactionCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection> GetTransactionsClient(string code, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Credits.CreditTransactionUrl.GetTransactionsUrl(code, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransactionCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new transaction and updates the amount of a store credit or gift card.
		/// </summary>
		/// <param name="code">User-defined code that identifies the customer credit to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="creditTransaction">Properties of the transaction to create for the customer credit.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Credit.CreditTransaction"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddTransaction( creditTransaction,  code,  responseFields);
		///   var creditTransactionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransaction> AddTransactionClient(Mozu.Api.Contracts.Customer.Credit.CreditTransaction creditTransaction, string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Credits.CreditTransactionUrl.AddTransactionUrl(code, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditTransaction>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.Credit.CreditTransaction>(creditTransaction);
			return mozuClient;

		}


	}

}


