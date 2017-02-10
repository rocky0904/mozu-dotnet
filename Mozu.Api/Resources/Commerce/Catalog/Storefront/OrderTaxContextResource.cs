
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Storefront Tax resource to retrieve tax information from the storefront.
	/// </summary>
	public partial class OrderTaxContextResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderTaxContextResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderTaxContextResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderTaxContextResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves tax information applicable to the site.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="taxableOrder"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PricingRuntime.OrderTaxContext"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordertaxcontext = new OrderTaxContext();
		///   var orderTaxContext = ordertaxcontext.EstimateTaxes( taxableOrder,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.PricingRuntime.OrderTaxContext EstimateTaxes(Mozu.Api.Contracts.PricingRuntime.TaxableOrder taxableOrder, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.PricingRuntime.OrderTaxContext> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.OrderTaxContextClient.EstimateTaxesClient( taxableOrder,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves tax information applicable to the site.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="taxableOrder"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.PricingRuntime.OrderTaxContext"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordertaxcontext = new OrderTaxContext();
		///   var orderTaxContext = await ordertaxcontext.EstimateTaxesAsync( taxableOrder,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.PricingRuntime.OrderTaxContext> EstimateTaxesAsync(Mozu.Api.Contracts.PricingRuntime.TaxableOrder taxableOrder, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.PricingRuntime.OrderTaxContext> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.OrderTaxContextClient.EstimateTaxesClient( taxableOrder,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


