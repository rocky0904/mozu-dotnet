
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Location Inventory resource to manage the level of active product inventory maintained at each defined location, at the location level.
	/// </summary>
	public partial class LocationInventoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public LocationInventoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public LocationInventoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new LocationInventoryResource(_apiContext.CloneWith(contextModification));
		}

		public LocationInventoryResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves the details of a product's active inventory at the location specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.GetLocationInventory( locationCode,  productCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventory GetLocationInventory(string locationCode, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.GetLocationInventoryClient( locationCode,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.LocationInventory> GetLocationInventoryAsync(string locationCode, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.GetLocationInventoryClient( locationCode,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of all product inventory definitions for the location code specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventoryCollection = locationinventory.GetLocationInventories( locationCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection GetLocationInventories(string locationCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.GetLocationInventoriesClient( locationCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> GetLocationInventoriesAsync(string locationCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.GetLocationInventoriesClient( locationCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates an array of product inventory definitions for the location specified in the request. When adding a new inventory definition, you must specify the productCode and stockOnHand value in each array you define. All other properties are system-supplied and read only.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="performUpserts"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryList">Array list of product inventory definitions for all associated locations. For each location inventory in the list, define the productCode and stockOnHand values.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.AddLocationInventory(_dataViewMode,  locationInventoryList,  locationCode,  performUpserts);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> AddLocationInventory(List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string locationCode, bool? performUpserts =  null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.AddLocationInventoryClient(_dataViewMode,  locationInventoryList,  locationCode,  performUpserts);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> AddLocationInventoryAsync(List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string locationCode, bool? performUpserts =  null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.AddLocationInventoryClient(_dataViewMode,  locationInventoryList,  locationCode,  performUpserts);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the active stock on hand inventory of products for the location code specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryAdjustments"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.UpdateLocationInventory(_dataViewMode,  locationInventoryAdjustments,  locationCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> UpdateLocationInventory(List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string locationCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.UpdateLocationInventoryClient(_dataViewMode,  locationInventoryAdjustments,  locationCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> UpdateLocationInventoryAsync(List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string locationCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.UpdateLocationInventoryClient(_dataViewMode,  locationInventoryAdjustments,  locationCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the product code inventory definition for the location specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   locationinventory.DeleteLocationInventory(_dataViewMode,  locationCode,  productCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteLocationInventory(string locationCode, string productCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.DeleteLocationInventoryClient(_dataViewMode,  locationCode,  productCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteLocationInventoryAsync(string locationCode, string productCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.DeleteLocationInventoryClient(_dataViewMode,  locationCode,  productCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


