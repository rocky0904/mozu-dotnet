
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Product Publishing resource to publish or discard pending changes to product definitions in the master catalog.
	/// </summary>
	public partial class PublishingScopeClient 	{
		
		/// <summary>
		/// Deletes the draft version of product changes for each product code specified in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Properties of the pending product changes to include in this operation.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DiscardDrafts( publishScope);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DiscardDraftsClient(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.PublishingScopeUrl.DiscardDraftsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.PublishingScope>(publishScope);
			return mozuClient;

		}

		/// <summary>
		/// Publishes the draft version of product changes for each product code specified in the request, and changes the product publish state to "live".
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Properties of the pending product changes to include in this operation.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PublishDrafts( publishScope);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient PublishDraftsClient(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.PublishingScopeUrl.PublishDraftsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.PublishingScope>(publishScope);
			return mozuClient;

		}


	}

}


