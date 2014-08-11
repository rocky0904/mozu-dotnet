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
	/// Use the Attribute Definition resource to manage the properties, options, and extras that uniquely describe products of a specific type. Attributes can be associated with a product type, assigned values by a client or shopper, and added as faceted search filters for a product category. Options are product attributes that describe unique configurations made by the shopper, such as size or color, and generate a new product variation (or unique SKU). Properties are product attributes that describe aspects of the product that do not represent an option configurable by the shopper, such as screen resolution or brand. Extras are product attributes that describe add-on configurations made by the shopper that do not represent a product variation, such as a monogram.
	/// </summary>
	public partial class AttributeFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a paged list of attributes according to any specified filter criteria and sort options.
		/// <example> 
		///  <code> 
		/// var result = AttributeFactory.GetAttributes(handler : handler,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<AttributeCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeCollection GetAttributes(ServiceClientMessageHandler handler, 
 		 int? startIndex = null, int? pageSize = null, string sortBy = null, string filter = null, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.GetAttributesClient(
				 startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  responseFields :  responseFields, dataViewMode: dataViewMode		);
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
  
		/// <summary> 
		/// Retrieves the details of the specified product attribute.
		/// <example> 
		///  <code> 
		/// var result = AttributeFactory.GetAttribute(handler : handler,  attributeFQN :  attributeFQN,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Attribute/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.Attribute GetAttribute(ServiceClientMessageHandler handler, 
 		 string attributeFQN, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.GetAttributeClient(
				 attributeFQN :  attributeFQN,  responseFields :  responseFields, dataViewMode: dataViewMode		);
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
  
		/// <summary> 
		/// Creates a new attribute to describe one aspect of a product such as color or size, based on its defined product type. The attribute name, attribute type, input type, and data type are required.
		/// <example> 
		///  <code> 
		/// var result = AttributeFactory.AddAttribute(handler : handler,  attribute :  attribute,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Attribute/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.Attribute AddAttribute(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.Attribute attribute, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.AddAttributeClient(
				 attribute :  attribute,  responseFields :  responseFields		);
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
  
		/// <summary> 
		/// Updates an existing attribute with attribute properties to set.
		/// <example> 
		///  <code> 
		/// var result = AttributeFactory.UpdateAttribute(handler : handler,  attribute :  attribute,  attributeFQN :  attributeFQN,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Attribute/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.Attribute UpdateAttribute(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.Attribute attribute, string attributeFQN, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.UpdateAttributeClient(
				 attribute :  attribute,  attributeFQN :  attributeFQN,  responseFields :  responseFields		);
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
  
		/// <summary> 
		/// Deletes a defined product attribute. You cannot delete an attribute assigned a value for a product.
		/// <example> 
		///  <code> 
		/// var result = AttributeFactory.DeleteAttribute(handler : handler,  attributeFQN :  attributeFQN,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteAttribute(ServiceClientMessageHandler handler, 
 		string attributeFQN, 
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.DeleteAttributeClient(
				 attributeFQN :  attributeFQN		);
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
			}
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


