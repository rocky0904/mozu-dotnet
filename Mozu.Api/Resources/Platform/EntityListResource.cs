
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// The Entity Lists resource manages all dynamic entities in your  document store of the  cloud. The content is JSON and can have up to five indexed properties (integer, decimal, string, date, and boolean) with support for additional customized elements as needed. Every document in the entity list has a validated unique ID.
	/// </summary>
	public partial class EntityListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EntityListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EntityListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EntityListResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Get a filtered list of EntityLists for a specific tenant.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityListCollection = entitylist.GetEntityLists( pageSize,  startIndex,  filter,  sortBy,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.MZDB.EntityListCollection GetEntityLists(int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityListCollection> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.GetEntityListsClient( pageSize,  startIndex,  filter,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Get a filtered list of EntityLists for a specific tenant.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityListCollection = await entitylist.GetEntityListsAsync( pageSize,  startIndex,  filter,  sortBy,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityListCollection> GetEntityListsAsync(int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityListCollection> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.GetEntityListsClient( pageSize,  startIndex,  filter,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Get an existing EntityList definition for a specific tenant
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = entitylist.GetEntityList( entityListFullName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.MZDB.EntityList GetEntityList(string entityListFullName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.GetEntityListClient( entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Get an existing EntityList definition for a specific tenant
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = await entitylist.GetEntityListAsync( entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityList> GetEntityListAsync(string entityListFullName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.GetEntityListClient( entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Create a new EntityList for a specific tenant.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="entityList">The definition of an MZDB EntityList which describes the characteristics of the EntityList on a per tenant basis. EntityLists are created at the tenant level, but instances of the EntityLists are implicitly created at the appropriate context level as entities are added or removed from the EntityList.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = entitylist.CreateEntityList( entityList,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.MZDB.EntityList CreateEntityList(Mozu.Api.Contracts.MZDB.EntityList entityList, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.CreateEntityListClient( entityList,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Create a new EntityList for a specific tenant.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="entityList">The definition of an MZDB EntityList which describes the characteristics of the EntityList on a per tenant basis. EntityLists are created at the tenant level, but instances of the EntityLists are implicitly created at the appropriate context level as entities are added or removed from the EntityList.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = await entitylist.CreateEntityListAsync( entityList,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityList> CreateEntityListAsync(Mozu.Api.Contracts.MZDB.EntityList entityList, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.CreateEntityListClient( entityList,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update an existing Entitylist for a specific tenant.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="entityList">The definition of an MZDB EntityList which describes the characteristics of the EntityList on a per tenant basis. EntityLists are created at the tenant level, but instances of the EntityLists are implicitly created at the appropriate context level as entities are added or removed from the EntityList.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = entitylist.UpdateEntityList( entityList,  entityListFullName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.MZDB.EntityList UpdateEntityList(Mozu.Api.Contracts.MZDB.EntityList entityList, string entityListFullName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.UpdateEntityListClient( entityList,  entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Update an existing Entitylist for a specific tenant.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="entityList">The definition of an MZDB EntityList which describes the characteristics of the EntityList on a per tenant basis. EntityLists are created at the tenant level, but instances of the EntityLists are implicitly created at the appropriate context level as entities are added or removed from the EntityList.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   var entityList = await entitylist.UpdateEntityListAsync( entityList,  entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityList> UpdateEntityListAsync(Mozu.Api.Contracts.MZDB.EntityList entityList, string entityListFullName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityList> response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.UpdateEntityListClient( entityList,  entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Delete an existing EntityList for a specific tenant. This will also delete all Entities in all instances of this EntityList for the tenant.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   entitylist.DeleteEntityList( entityListFullName);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteEntityList(string entityListFullName)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.DeleteEntityListClient( entityListFullName);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Delete an existing EntityList for a specific tenant. This will also delete all Entities in all instances of this EntityList for the tenant.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var entitylist = new EntityList();
		///   await entitylist.DeleteEntityListAsync( entityListFullName);
		/// </code>
		/// </example>
		public virtual async Task DeleteEntityListAsync(string entityListFullName)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.EntityListClient.DeleteEntityListClient( entityListFullName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


