
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
using System.Threading;

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Extended Properties resource to store tracking strings for your orders. Extended properties can help you track affiliate sources.
	/// </summary>
	public partial class ExtendedPropertyResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ExtendedPropertyResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ExtendedPropertyResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ExtendedPropertyResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var extendedproperty = new ExtendedProperty();
		///   var extendedProperty = await extendedproperty.GetExtendedPropertiesAsync( orderId,  draft);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> GetExtendedPropertiesAsync(string orderId, bool? draft =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ExtendedPropertyClient.GetExtendedPropertiesClient( orderId,  draft);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">Determines whether or not to check versioning of items for concurrency purposes.</param>
		/// <param name="extendedProperties">The details of the extended property.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var extendedproperty = new ExtendedProperty();
		///   var extendedProperty = await extendedproperty.AddExtendedPropertiesAsync( extendedProperties,  orderId,  updateMode,  version);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> AddExtendedPropertiesAsync(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties, string orderId, string updateMode =  null, string version =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ExtendedPropertyClient.AddExtendedPropertiesClient( extendedProperties,  orderId,  updateMode,  version);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">The extended property key.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="upsert">Inserts and updates an extended property.        </param>
		/// <param name="version">Determines whether or not to check versioning of items for concurrency purposes.</param>
		/// <param name="extendedProperty">The details of the updated extended property.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var extendedproperty = new ExtendedProperty();
		///   var extendedProperty = await extendedproperty.UpdateExtendedPropertyAsync( extendedProperty,  orderId,  key,  updateMode,  version,  upsert,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> UpdateExtendedPropertyAsync(Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty extendedProperty, string orderId, string key, string updateMode =  null, string version =  null, bool? upsert =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ExtendedPropertyClient.UpdateExtendedPropertyClient( extendedProperty,  orderId,  key,  updateMode,  version,  upsert,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="upsert">Inserts and updates the extended property.        </param>
		/// <param name="version">Determines whether or not to check versioning of items for concurrency purposes.</param>
		/// <param name="extendedProperties">The details of the updated extended properties.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var extendedproperty = new ExtendedProperty();
		///   var extendedProperty = await extendedproperty.UpdateExtendedPropertiesAsync( extendedProperties,  orderId,  updateMode,  version,  upsert);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> UpdateExtendedPropertiesAsync(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties, string orderId, string updateMode =  null, string version =  null, bool? upsert =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.ExtendedPropertyClient.UpdateExtendedPropertiesClient( extendedProperties,  orderId,  updateMode,  version,  upsert);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">The extended property key.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">Determines whether or not to check versioning of items for concurrency purposes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var extendedproperty = new ExtendedProperty();
		///   await extendedproperty.DeleteExtendedPropertyAsync( orderId,  key,  updateMode,  version);
		/// </code>
		/// </example>
		public virtual async Task DeleteExtendedPropertyAsync(string orderId, string key, string updateMode =  null, string version =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.ExtendedPropertyClient.DeleteExtendedPropertyClient( orderId,  key,  updateMode,  version);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">Determines whether or not to check versioning of items for concurrency purposes.</param>
		/// <param name="keys">The extended property keys.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var extendedproperty = new ExtendedProperty();
		///   await extendedproperty.DeleteExtendedPropertiesAsync( keys,  orderId,  updateMode,  version);
		/// </code>
		/// </example>
		public virtual async Task DeleteExtendedPropertiesAsync(List<string> keys, string orderId, string updateMode =  null, string version =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.ExtendedPropertyClient.DeleteExtendedPropertiesClient( keys,  orderId,  updateMode,  version);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


