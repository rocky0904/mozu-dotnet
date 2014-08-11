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
	/// Use the product variations sub-resource to manage the variations of a product based on its attributes. For example, a t-shirt product could be offered in six variations: Small Black, Medium Black, Large Black, Small White, Medium White, and Large White.
	/// </summary>
	public partial class ProductVariationFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.GetProductVariationLocalizedDeltaPrices(handler : handler,  productCode :  productCode,  variationKey :  variationKey,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<ProductVariationDeltaPrice>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> GetProductVariationLocalizedDeltaPrices(ServiceClientMessageHandler handler, 
 		 string productCode, string variationKey,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedDeltaPricesClient(
				 productCode :  productCode,  variationKey :  variationKey, dataViewMode: dataViewMode		);
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
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.GetProductVariationLocalizedDeltaPrice(handler : handler,  productCode :  productCode,  variationKey :  variationKey,  currencyCode :  currencyCode,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariationDeltaPrice/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice GetProductVariationLocalizedDeltaPrice(ServiceClientMessageHandler handler, 
 		 string productCode, string variationKey, string currencyCode, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationLocalizedDeltaPriceClient(
				 productCode :  productCode,  variationKey :  variationKey,  currencyCode :  currencyCode,  responseFields :  responseFields, dataViewMode: dataViewMode		);
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
		/// Retrieves the details of a product variation based on the supplied product code and variation key.
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.GetProductVariation(handler : handler,  productCode :  productCode,  variationKey :  variationKey,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariation/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariation GetProductVariation(ServiceClientMessageHandler handler, 
 		 string productCode, string variationKey, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationClient(
				 productCode :  productCode,  variationKey :  variationKey,  responseFields :  responseFields, dataViewMode: dataViewMode		);
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
		/// Retrieves a list of the product variations configured for the specified product code.
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.GetProductVariations(handler : handler,  productCode :  productCode,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariationPagedCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GetProductVariations(ServiceClientMessageHandler handler, 
 		 string productCode, int? startIndex = null, int? pageSize = null, string sortBy = null, string filter = null, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationsClient(
				 productCode :  productCode,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  responseFields :  responseFields, dataViewMode: dataViewMode		);
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
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.AddProductVariationLocalizedDeltaPrice(handler : handler,  localizedDeltaPrice :  localizedDeltaPrice,  productCode :  productCode,  variationKey :  variationKey,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariationDeltaPrice/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice AddProductVariationLocalizedDeltaPrice(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.AddProductVariationLocalizedDeltaPriceClient(
				 localizedDeltaPrice :  localizedDeltaPrice,  productCode :  productCode,  variationKey :  variationKey,  responseFields :  responseFields		);
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
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.UpdateProductVariationLocalizedDeltaPrices(handler : handler,  localizedDeltaPrice :  localizedDeltaPrice,  productCode :  productCode,  variationKey :  variationKey,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<ProductVariationDeltaPrice>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> UpdateProductVariationLocalizedDeltaPrices(ServiceClientMessageHandler handler, 
 		 List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> localizedDeltaPrice, string productCode, string variationKey, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedDeltaPricesClient(
				 localizedDeltaPrice :  localizedDeltaPrice,  productCode :  productCode,  variationKey :  variationKey		);
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
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.UpdateProductVariationLocalizedDeltaPrice(handler : handler,  localizedDeltaPrice :  localizedDeltaPrice,  productCode :  productCode,  variationKey :  variationKey,  currencyCode :  currencyCode,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariationDeltaPrice/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice UpdateProductVariationLocalizedDeltaPrice(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string currencyCode, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationLocalizedDeltaPriceClient(
				 localizedDeltaPrice :  localizedDeltaPrice,  productCode :  productCode,  variationKey :  variationKey,  currencyCode :  currencyCode,  responseFields :  responseFields		);
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
		/// Modifies the details of a variation, based on the supplied variation key, for the specified product code.
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.UpdateProductVariation(handler : handler,  productVariation :  productVariation,  productCode :  productCode,  variationKey :  variationKey,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariation/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariation UpdateProductVariation(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.ProductVariation productVariation, string productCode, string variationKey, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationClient(
				 productVariation :  productVariation,  productCode :  productCode,  variationKey :  variationKey,  responseFields :  responseFields		);
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
		/// Modifies the collection of variations for the specified product code. Because this PUT replaces the existing resource, supply all information necessary to maintain for the product variation.
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.UpdateProductVariations(handler : handler,  productVariations :  productVariations,  productCode :  productCode,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductVariationCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection UpdateProductVariations(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection productVariations, string productCode, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationsClient(
				 productVariations :  productVariations,  productCode :  productCode,  responseFields :  responseFields		);
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
		/// Deletes a variation, based on the supplied variation key, for the specified product code.
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.DeleteProductVariation(handler : handler,  productCode :  productCode,  variationKey :  variationKey,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteProductVariation(ServiceClientMessageHandler handler, 
 		string productCode, string variationKey, 
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationClient(
				 productCode :  productCode,  variationKey :  variationKey		);
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
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductVariationFactory.DeleteProductVariationLocalizedDeltaPrice(handler : handler,  productCode :  productCode,  variationKey :  variationKey,  currencyCode :  currencyCode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteProductVariationLocalizedDeltaPrice(ServiceClientMessageHandler handler, 
 		string productCode, string variationKey, string currencyCode, 
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationLocalizedDeltaPriceClient(
				 productCode :  productCode,  variationKey :  variationKey,  currencyCode :  currencyCode		);
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


