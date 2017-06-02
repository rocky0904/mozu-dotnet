
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

namespace Mozu.Api.Resources.Commerce.Settings
{
	/// <summary>
	/// Use the cart subresource to manage settings for the cart, such as whether to include handling fees in the cost calculations.
	/// </summary>
	public partial class CartSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CartSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CartSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CartSettingsResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves cart settings.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartsettings = new CartSettings();
		///   var cartSettings = cartsettings.GetCartSettings( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Order.CartSettings GetCartSettings(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.CartSettingsClient.GetCartSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves cart settings.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartsettings = new CartSettings();
		///   var cartSettings = await cartsettings.GetCartSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> GetCartSettingsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.CartSettingsClient.GetCartSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates cart settings.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartSettings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartsettings = new CartSettings();
		///   var cartSettings = cartsettings.CreateCartSettings( cartSettings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Order.CartSettings CreateCartSettings(Mozu.Api.Contracts.SiteSettings.Order.CartSettings cartSettings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.CartSettingsClient.CreateCartSettingsClient( cartSettings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates cart settings.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartSettings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartsettings = new CartSettings();
		///   var cartSettings = await cartsettings.CreateCartSettingsAsync( cartSettings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> CreateCartSettingsAsync(Mozu.Api.Contracts.SiteSettings.Order.CartSettings cartSettings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.CartSettingsClient.CreateCartSettingsClient( cartSettings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates cart settings.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartSettings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartsettings = new CartSettings();
		///   var cartSettings = cartsettings.UpdateCartSettings( cartSettings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Order.CartSettings UpdateCartSettings(Mozu.Api.Contracts.SiteSettings.Order.CartSettings cartSettings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.CartSettingsClient.UpdateCartSettingsClient( cartSettings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates cart settings.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartSettings"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartsettings = new CartSettings();
		///   var cartSettings = await cartsettings.UpdateCartSettingsAsync( cartSettings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> UpdateCartSettingsAsync(Mozu.Api.Contracts.SiteSettings.Order.CartSettings cartSettings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.CartSettingsClient.UpdateCartSettingsClient( cartSettings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


