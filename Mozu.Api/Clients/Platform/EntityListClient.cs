
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// The Entity Lists resource manages all dynamic entities in your Mozu document store of the Mozu cloud. The content is JSON and can have up to five indexed properties (integer, decimal, string, date, and boolean) with support for additional customized elements as needed. Every document in the entity list has a validated unique ID. 
	/// </summary>
	public partial class EntityListClient 	{
		
		/// <summary>
		/// Get a filtered list of EntityLists for a specific tenant.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=50`.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityListCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEntityLists( pageSize,  startIndex,  filter,  sortBy,  responseFields);
		///   var entityListCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityListCollection> GetEntityListsClient(int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.EntityListUrl.GetEntityListsUrl(pageSize, startIndex, filter, sortBy, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityListCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Get an existing EntityList definition for a specific tenant
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEntityList( entityListFullName,  responseFields);
		///   var entityListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityList> GetEntityListClient(string entityListFullName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.EntityListUrl.GetEntityListUrl(entityListFullName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityList>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Create a new EntityList for a specific tenant.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="entityList">The definition of an MZDB EntityList which describes the characteristics of the EntityList on a per tenant basis. EntityLists are created at the tenant level, but instances of the EntityLists are implicitly created at the appropriate context level as entities are added or removed from the EntityList.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateEntityList( entityList,  responseFields);
		///   var entityListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityList> CreateEntityListClient(Mozu.Api.Contracts.MZDB.EntityList entityList, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.EntityListUrl.CreateEntityListUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityList>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.MZDB.EntityList>(entityList);
			return mozuClient;

		}

		/// <summary>
		/// Update an existing Entitylist for a specific tenant.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="entityList">The definition of an MZDB EntityList which describes the characteristics of the EntityList on a per tenant basis. EntityLists are created at the tenant level, but instances of the EntityLists are implicitly created at the appropriate context level as entities are added or removed from the EntityList.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateEntityList( entityList,  entityListFullName,  responseFields);
		///   var entityListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityList> UpdateEntityListClient(Mozu.Api.Contracts.MZDB.EntityList entityList, string entityListFullName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.EntityListUrl.UpdateEntityListUrl(entityListFullName, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityList>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.MZDB.EntityList>(entityList);
			return mozuClient;

		}

		/// <summary>
		/// Delete an existing EntityList for a specific tenant. This will also delete all Entities in all instances of this EntityList for the tenant.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteEntityList( entityListFullName);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteEntityListClient(string entityListFullName)
		{
			var url = Mozu.Api.Urls.Platform.EntityListUrl.DeleteEntityListUrl(entityListFullName);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


