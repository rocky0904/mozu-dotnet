
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

namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// The B2B feature includes the primary shared B2B account and a set of user account logins that have access to that primary account. This primary account has its own identifying data and customer attributes, as well as the list of users associated with it. These attributes and users can be managed through other operations of the B2B APIs.
	/// </summary>
	public partial class B2BAccountClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fields"></param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetB2BAccounts( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  responseFields);
		///   var b2BAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BAccountCollection> GetB2BAccountsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.GetB2BAccountsUrl(startIndex, pageSize, sortBy, filter, fields, q, qLimit, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BAccountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetB2BAccountAttribute( accountId,  attributeFQN,  responseFields);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> GetB2BAccountAttributeClient(int accountId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.GetB2BAccountAttributeUrl(accountId, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetB2BAccountAttributes( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerAttributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> GetB2BAccountAttributesClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.GetB2BAccountAttributesUrl(accountId, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.UserRoleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUserRolesAsync( accountId,  userId,  responseFields);
		///   var userRoleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.UserRoleCollection> GetUserRolesAsyncClient(int accountId, string userId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.GetUserRolesAsyncUrl(accountId, userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.UserRoleCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BUserCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUsers( accountId,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  responseFields);
		///   var b2BUserCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BUserCollection> GetUsersClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.GetUsersUrl(accountId, startIndex, pageSize, sortBy, filter, q, qLimit, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BUserCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetB2BAccount( accountId,  responseFields);
		///   var b2BAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BAccount> GetB2BAccountClient(int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.GetB2BAccountUrl(accountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BAccount>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="account"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccount( account,  responseFields);
		///   var b2BAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BAccount> AddAccountClient(Mozu.Api.Contracts.Customer.B2BAccount account, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.AddAccountUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.B2BAccount>(account);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="attribute">The attribute details being applied to the B2B account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddB2BAccountAttribute( attribute,  accountId,  responseFields);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> AddB2BAccountAttributeClient(Mozu.Api.Contracts.Customer.CustomerAttribute attribute, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.AddB2BAccountAttributeUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAttribute>(attribute);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="roleId">Identifier for the role that the user account should belong to. For B2B, these roles include Admin, Purchaser, and Non-Purchaser.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddUserRoleAsync( accountId,  userId,  roleId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient AddUserRoleAsyncClient(int accountId, string userId, int roleId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.AddUserRoleAsyncUrl(accountId, userId, roleId);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="user"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BUser"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddUser( user,  accountId,  responseFields);
		///   var b2BUserClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BUser> AddUserClient(Mozu.Api.Contracts.Customer.B2BUserAndAuthInfo user, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.AddUserUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BUser>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.B2BUserAndAuthInfo>(user);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="attribute"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateB2BAccountAttribute( attribute,  accountId,  attributeFQN,  responseFields);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> UpdateB2BAccountAttributeClient(Mozu.Api.Contracts.Customer.CustomerAttribute attribute, int accountId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.UpdateB2BAccountAttributeUrl(accountId, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAttribute>(attribute);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveUser( accountId,  userId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RemoveUserClient(int accountId, string userId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.RemoveUserUrl(accountId, userId);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <param name="user"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BUser"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateUser( user,  accountId,  userId,  responseFields);
		///   var b2BUserClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BUser> UpdateUserClient(Mozu.Api.Contracts.Customer.B2BUser user, int accountId, string userId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.UpdateUserUrl(accountId, userId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BUser>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.B2BUser>(user);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="account"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.B2BAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccount( account,  accountId,  responseFields);
		///   var b2BAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.B2BAccount> UpdateAccountClient(Mozu.Api.Contracts.Customer.B2BAccount account, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.UpdateAccountUrl(accountId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.B2BAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.B2BAccount>(account);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteB2BAccountAttribute( accountId,  attributeFQN);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteB2BAccountAttributeClient(int accountId, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.DeleteB2BAccountAttributeUrl(accountId, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="roleId">The ID corresponding to the type of permissions being removed, e.g. 1 for Admin.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveUserRoleAsync( accountId,  userId,  roleId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RemoveUserRoleAsyncClient(int accountId, string userId, int roleId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.B2BAccountUrl.RemoveUserRoleAsyncUrl(accountId, userId, roleId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


