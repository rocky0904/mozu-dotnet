
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
	/// Use the Applications resource to update and retrieve details about the applications installed for your tenant.
	/// </summary>
	public partial class ApplicationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ApplicationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ApplicationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ApplicationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the details of the installed application specified in the request.
		/// </summary>
		/// <param name="appId">The application ID that represents the application to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = application.GetApplication( appId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.InstalledApplications.Application GetApplication(string appId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.Application> response;
			var client = Mozu.Api.Clients.Platform.ApplicationClient.GetApplicationClient( appId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the installed application specified in the request.
		/// </summary>
		/// <param name="appId">The application ID that represents the application to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = await application.GetApplicationAsync( appId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.InstalledApplications.Application> GetApplicationAsync(string appId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.Application> response;
			var client = Mozu.Api.Clients.Platform.ApplicationClient.GetApplicationClient( appId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more properties of the application specified in the request.
		/// </summary>
		/// <param name="appId">The application ID that represents the application to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="application">Properties of the application to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = application.UpdateApplication( application,  appId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.InstalledApplications.Application UpdateApplication(Mozu.Api.Contracts.InstalledApplications.Application application, string appId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.Application> response;
			var client = Mozu.Api.Clients.Platform.ApplicationClient.UpdateApplicationClient( application,  appId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of the application specified in the request.
		/// </summary>
		/// <param name="appId">The application ID that represents the application to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="application">Properties of the application to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.Application"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var application = new Application();
		///   var application = await application.UpdateApplicationAsync( application,  appId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.InstalledApplications.Application> UpdateApplicationAsync(Mozu.Api.Contracts.InstalledApplications.Application application, string appId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.Application> response;
			var client = Mozu.Api.Clients.Platform.ApplicationClient.UpdateApplicationClient( application,  appId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


