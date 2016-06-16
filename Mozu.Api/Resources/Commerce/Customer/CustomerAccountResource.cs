
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

namespace Mozu.Api.Resources.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Accounts resource to manage the components of shopper accounts, including attributes, contact information, company notes, and groups associated with the customer account.
	/// </summary>
	public partial class CustomerAccountResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerAccountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerAccountResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerAccountResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of customer accounts.
		/// </summary>
		/// <param name="fields">The fields to include in the response.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="isAnonymous">If true, retrieve anonymous shopper accounts in the response.</param>
		/// <param name="pageSize"></param>
		/// <param name="q">A list of customer account search terms to use in the query when searching across customer name and email. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccountCollection = customeraccount.GetAccounts( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  isAnonymous,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAccountCollection GetAccounts(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, bool? isAnonymous =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetAccountsClient( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  isAnonymous,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of customer accounts.
		/// </summary>
		/// <param name="fields">The fields to include in the response.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="isAnonymous">If true, retrieve anonymous shopper accounts in the response.</param>
		/// <param name="pageSize"></param>
		/// <param name="q">A list of customer account search terms to use in the query when searching across customer name and email. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccountCollection = await customeraccount.GetAccountsAsync( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  isAnonymous,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAccountCollection> GetAccountsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, bool? isAnonymous =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetAccountsClient( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  isAnonymous,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the current login state of the customer account specified in the request.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.LoginState"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var loginState = customeraccount.GetLoginState( accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.LoginState GetLoginState(int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.LoginState> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetLoginStateClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the current login state of the customer account specified in the request.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.LoginState"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var loginState = await customeraccount.GetLoginStateAsync( accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateAsync(int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.LoginState> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetLoginStateClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieve details of a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccount = customeraccount.GetAccount( accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAccount GetAccount(int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetAccountClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieve details of a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccount = await customeraccount.GetAccountAsync( accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAccount> GetAccountAsync(int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetAccountClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new customer account based on the information specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="account">Properties of the customer account to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccount = customeraccount.AddAccount( account,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAccount AddAccount(Mozu.Api.Contracts.Customer.CustomerAccount account, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountClient( account,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new customer account based on the information specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="account">Properties of the customer account to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccount = await customeraccount.AddAccountAsync( account,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAccount> AddAccountAsync(Mozu.Api.Contracts.Customer.CustomerAccount account, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountClient( account,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Modify the password associated with a customer account.
		/// </summary>
		/// <param name="accountId">The customer account information required to change the userpassword.</param>
		/// <param name="unlockAccount"></param>
		/// <param name="passwordInfo">The password information required to change the user password.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   customeraccount.ChangePassword( passwordInfo,  accountId,  unlockAccount);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ChangePassword(Mozu.Api.Contracts.Customer.PasswordInfo passwordInfo, int accountId, bool? unlockAccount =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.ChangePasswordClient( passwordInfo,  accountId,  unlockAccount);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Modify the password associated with a customer account.
		/// </summary>
		/// <param name="accountId">The customer account information required to change the userpassword.</param>
		/// <param name="unlockAccount"></param>
		/// <param name="passwordInfo">The password information required to change the user password.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   await customeraccount.ChangePasswordAsync( passwordInfo,  accountId,  unlockAccount);
		/// </code>
		/// </example>
		public virtual async Task ChangePasswordAsync(Mozu.Api.Contracts.Customer.PasswordInfo passwordInfo, int accountId, bool? unlockAccount =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.ChangePasswordClient( passwordInfo,  accountId,  unlockAccount);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Adds a new user login to a defined customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="customerAuthInfo">The authentication information for the customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAuthTicket = customeraccount.AddLoginToExistingCustomer( customerAuthInfo,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAuthTicket AddLoginToExistingCustomer(Mozu.Api.Contracts.Customer.CustomerLoginInfo customerAuthInfo, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddLoginToExistingCustomerClient( customerAuthInfo,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds a new user login to a defined customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="customerAuthInfo">The authentication information for the customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAuthTicket = await customeraccount.AddLoginToExistingCustomerAsync( customerAuthInfo,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAuthTicket> AddLoginToExistingCustomerAsync(Mozu.Api.Contracts.Customer.CustomerLoginInfo customerAuthInfo, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddLoginToExistingCustomerClient( customerAuthInfo,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the customer lifetime value of the specified customer account in the event of an order import or a lifetime value calculation error.
		/// </summary>
		/// <param name="accountId">The unique identifier of the customer account for which to calculate customer lifetime value.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   customeraccount.RecomputeCustomerLifetimeValue( accountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void RecomputeCustomerLifetimeValue(int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.RecomputeCustomerLifetimeValueClient( accountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Updates the customer lifetime value of the specified customer account in the event of an order import or a lifetime value calculation error.
		/// </summary>
		/// <param name="accountId">The unique identifier of the customer account for which to calculate customer lifetime value.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   await customeraccount.RecomputeCustomerLifetimeValueAsync( accountId);
		/// </code>
		/// </example>
		public virtual async Task RecomputeCustomerLifetimeValueAsync(int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.RecomputeCustomerLifetimeValueClient( accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Lock or unlock a customer account.
		/// </summary>
		/// <param name="accountId">The unique identifier of the customer account.</param>
		/// <param name="isLocked">If true, the customer account is locked from logging in.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   customeraccount.SetLoginLocked( isLocked,  accountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void SetLoginLocked(bool isLocked, int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.SetLoginLockedClient( isLocked,  accountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Lock or unlock a customer account.
		/// </summary>
		/// <param name="accountId">The unique identifier of the customer account.</param>
		/// <param name="isLocked">If true, the customer account is locked from logging in.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   await customeraccount.SetLoginLockedAsync( isLocked,  accountId);
		/// </code>
		/// </example>
		public virtual async Task SetLoginLockedAsync(bool isLocked, int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.SetLoginLockedClient( isLocked,  accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Requires the password for the customer account to be changed.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="isPasswordChangeRequired">If true, the password for the customer account must be changed.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   customeraccount.SetPasswordChangeRequired( isPasswordChangeRequired,  accountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void SetPasswordChangeRequired(bool isPasswordChangeRequired, int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.SetPasswordChangeRequiredClient( isPasswordChangeRequired,  accountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Requires the password for the customer account to be changed.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="isPasswordChangeRequired">If true, the password for the customer account must be changed.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   await customeraccount.SetPasswordChangeRequiredAsync( isPasswordChangeRequired,  accountId);
		/// </code>
		/// </example>
		public virtual async Task SetPasswordChangeRequiredAsync(bool isPasswordChangeRequired, int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.SetPasswordChangeRequiredClient( isPasswordChangeRequired,  accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Creates a new customer account and logs the user associated with the customer account into the site.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="accountAndAuthInfo">Properties of the customer account to create, including the user authentication information.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAuthTicket = customeraccount.AddAccountAndLogin( accountAndAuthInfo,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAuthTicket AddAccountAndLogin(Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo accountAndAuthInfo, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountAndLoginClient( accountAndAuthInfo,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new customer account and logs the user associated with the customer account into the site.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="accountAndAuthInfo">Properties of the customer account to create, including the user authentication information.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAuthTicket = await customeraccount.AddAccountAndLoginAsync( accountAndAuthInfo,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAuthTicket> AddAccountAndLoginAsync(Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo accountAndAuthInfo, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountAndLoginClient( accountAndAuthInfo,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates multiple customer accounts based on the information specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="customers">Properties of the customer accounts to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccountCollection = customeraccount.AddAccounts( customers,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAccountCollection AddAccounts(List<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo> customers, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountsClient( customers,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates multiple customer accounts based on the information specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="customers">Properties of the customer accounts to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccountCollection = await customeraccount.AddAccountsAsync( customers,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAccountCollection> AddAccountsAsync(List<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo> customers, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountsClient( customers,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="accountPasswordInfos"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.ChangePasswordResultCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var changePasswordResultCollection = customeraccount.ChangePasswords( accountPasswordInfos,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.ChangePasswordResultCollection ChangePasswords(Mozu.Api.Contracts.Customer.AccountPasswordInfoCollection accountPasswordInfos, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.ChangePasswordResultCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.ChangePasswordsClient( accountPasswordInfos,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="accountPasswordInfos"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.ChangePasswordResultCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var changePasswordResultCollection = await customeraccount.ChangePasswordsAsync( accountPasswordInfos,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.ChangePasswordResultCollection> ChangePasswordsAsync(Mozu.Api.Contracts.Customer.AccountPasswordInfoCollection accountPasswordInfos, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.ChangePasswordResultCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.ChangePasswordsClient( accountPasswordInfos,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the current login state of a customer account by providing the customer's email address.
		/// </summary>
		/// <param name="emailAddress">The email address associated with the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.LoginState"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var loginState = customeraccount.GetLoginStateByEmailAddress( emailAddress,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.LoginState GetLoginStateByEmailAddress(string emailAddress, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.LoginState> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetLoginStateByEmailAddressClient( emailAddress,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the current login state of a customer account by providing the customer's email address.
		/// </summary>
		/// <param name="emailAddress">The email address associated with the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.LoginState"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var loginState = await customeraccount.GetLoginStateByEmailAddressAsync( emailAddress,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateByEmailAddressAsync(string emailAddress, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.LoginState> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetLoginStateByEmailAddressClient( emailAddress,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the current login state of a customer account by providing the user name associated with the customer account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userName">The user name associated with the customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.LoginState"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var loginState = customeraccount.GetLoginStateByUserName( userName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.LoginState GetLoginStateByUserName(string userName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.LoginState> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetLoginStateByUserNameClient( userName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the current login state of a customer account by providing the user name associated with the customer account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userName">The user name associated with the customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.LoginState"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var loginState = await customeraccount.GetLoginStateByUserNameAsync( userName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateByUserNameAsync(string userName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.LoginState> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetLoginStateByUserNameClient( userName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Resets the password for a customer account.
		/// </summary>
		/// <param name="resetPasswordInfo">Information required to reset the password for a customer account.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   customeraccount.ResetPassword( resetPasswordInfo);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ResetPassword(Mozu.Api.Contracts.Customer.ResetPasswordInfo resetPasswordInfo)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.ResetPasswordClient( resetPasswordInfo);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Resets the password for a customer account.
		/// </summary>
		/// <param name="resetPasswordInfo">Information required to reset the password for a customer account.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   await customeraccount.ResetPasswordAsync( resetPasswordInfo);
		/// </code>
		/// </example>
		public virtual async Task ResetPasswordAsync(Mozu.Api.Contracts.Customer.ResetPasswordInfo resetPasswordInfo)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.ResetPasswordClient( resetPasswordInfo);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="account">Properties of the customer account to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccount = customeraccount.UpdateAccount( account,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerAccount UpdateAccount(Mozu.Api.Contracts.Customer.CustomerAccount account, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.UpdateAccountClient( account,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="account">Properties of the customer account to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   var customerAccount = await customeraccount.UpdateAccountAsync( account,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerAccount> UpdateAccountAsync(Mozu.Api.Contracts.Customer.CustomerAccount account, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.UpdateAccountClient( account,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a customer account. A customer account cannot be deleted if any orders exist, past or present.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   customeraccount.DeleteAccount( accountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteAccount(int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.DeleteAccountClient( accountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a customer account. A customer account cannot be deleted if any orders exist, past or present.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customeraccount = new CustomerAccount();
		///   await customeraccount.DeleteAccountAsync( accountId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAccountAsync(int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.DeleteAccountClient( accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


