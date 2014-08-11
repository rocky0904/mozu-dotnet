
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

namespace Mozu.Api.Resources.Platform.Adminuser
{
	/// <summary>
	/// Use the Admin User authentication tickets resource to generate and refresh authentication tickets that enable Mozu administrator or developer account users to access development or production tenants.
	/// </summary>
	public partial class TenantAdminUserAuthTicketResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TenantAdminUserAuthTicketResource() 
		{
			_apiContext = null;
		}
		 public TenantAdminUserAuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}
				
		/// <summary>
		/// Creates an authentication ticket for the supplied user to specify in API requests associated with the supplied tenant.
		/// </summary>
		/// <param name="tenantId">Unique identifier of the development or production tenant for which to generate the user authentication ticket.</param>
		/// <param name="userAuthInfo">The user authentication information required to generate the user authentication ticket, which consists of a user name and password.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = tenantadminuserauthticket.CreateUserAuthTicket( userAuthInfo,  tenantId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket CreateUserAuthTicket(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? tenantId =  null)
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.CreateUserAuthTicketClient( userAuthInfo,  tenantId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> CreateUserAuthTicketAsync(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? tenantId =  null)
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.CreateUserAuthTicketClient( userAuthInfo,  tenantId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Generates a new user authentication ticket for the specified tenant by supplying the user's existing refresh token information.
		/// </summary>
		/// <param name="tenantId"></param>
		/// <param name="existingAuthTicket">Properties of the authentication ticket to refresh. The refresh token is required to complete this request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   var tenantAdminUserAuthTicket = tenantadminuserauthticket.RefreshAuthTicket( existingAuthTicket,  tenantId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket RefreshAuthTicket(Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket existingAuthTicket, int? tenantId =  null)
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.RefreshAuthTicketClient( existingAuthTicket,  tenantId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> RefreshAuthTicketAsync(Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket existingAuthTicket, int? tenantId =  null)
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.TenantAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.RefreshAuthTicketClient( existingAuthTicket,  tenantId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the authentication ticket for the user by supplying the refresh token.
		/// </summary>
		/// <param name="refreshToken">Refresh token string associated with the user authentication ticket.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantadminuserauthticket = new TenantAdminUserAuthTicket();
		///   tenantadminuserauthticket.DeleteUserAuthTicket( refreshToken);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteUserAuthTicket(string refreshToken)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.DeleteUserAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteUserAuthTicketAsync(string refreshToken)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Adminuser.TenantAdminUserAuthTicketClient.DeleteUserAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


