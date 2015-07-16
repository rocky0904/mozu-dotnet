
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

namespace Mozu.Api.Clients.Content
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DocumentDraftSummaryClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.PublishSetSummaryPagedCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPublishSets( pageSize,  startIndex,  responseFields);
		///   var publishSetSummaryPagedCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.PublishSetSummaryPagedCollection> GetPublishSetsClient(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentDraftSummaryUrl.GetPublishSetsUrl(pageSize, startIndex, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.PublishSetSummaryPagedCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPublishSetItems( code,  pageSize,  startIndex,  responseFields);
		///   var documentDraftSummaryPagedCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection> GetPublishSetItemsClient(string code, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentDraftSummaryUrl.GetPublishSetItemsUrl(code, pageSize, startIndex, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="responseFields"></param>
		/// <param name="shouldDiscard"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{object}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePublishSet( code,  shouldDiscard,  responseFields);
		///   var objectClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<object> DeletePublishSetClient(string code, bool? shouldDiscard =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentDraftSummaryUrl.DeletePublishSetUrl(code, shouldDiscard, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<object>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="responseFields"></param>
		/// <param name="documentIds"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{object}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddPublishSetItems( documentIds,  code,  responseFields);
		///   var objectClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<object> AddPublishSetItemsClient(List<string> documentIds, string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentDraftSummaryUrl.AddPublishSetItemsUrl(code, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<object>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(documentIds);
			return mozuClient;

		}


	}

}


