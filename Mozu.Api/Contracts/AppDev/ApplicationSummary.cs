
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.AppDev
{
		public class ApplicationSummary
		{
			public string AppId { get; set; }

			public string AppKey { get; set; }

			public int ApplicationId { get; set; }

			public string ApplicationNamespace { get; set; }

			public int ApplicationStatusId { get; set; }

			public string ApplicationStatusName { get; set; }

			public int ApplicationTypeId { get; set; }

			public AppVersion ApplicationVersion { get; set; }

			public byte AppSchemeVersion { get; set; }

			public bool HasVersions { get; set; }

			public string Name { get; set; }

			public string ParentAppKey { get; set; }

			public string ParentName { get; set; }

			public int ReleasePackageId { get; set; }

			public string ReleasePackageName { get; set; }

			public bool UpdateAvailable { get; set; }

			public string UpdateParentAppKey { get; set; }

		}

}