//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use the facets subresource to allow a merchant to add information for product indexing and searching.
	/// </summary>
	public partial class FacetFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves the properties of facets that aid in indexing and searching.
		/// <example> 
		///  <code> 
		/// var result = FacetFactory.GetFacets(handler : handler,  documentListName :  documentListName,  propertyName :  propertyName,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<Facet>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.Content.Facet> GetFacets(ServiceClientMessageHandler handler, 
 		 string documentListName, string propertyName,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Content.Documentlists.FacetClient.GetFacetsClient(
				 documentListName :  documentListName,  propertyName :  propertyName, dataViewMode: dataViewMode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


