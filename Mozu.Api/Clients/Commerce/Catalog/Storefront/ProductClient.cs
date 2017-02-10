
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

namespace Mozu.Api.Clients.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Storefront Products resource to manage the shopper product selection process during a visit to the web storefront. You can update product options as shoppers pick and choose their product choices. A shopper cannot add a product to a cart until all of its required options have been selected.
	/// </summary>
	public partial class ProductClient 	{
		
		/// <summary>
		/// Retrieves a list of products that appear on the web storefront according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="cursorMark">In your first deep paged request, set this parameter to . Then, in all subsequent requests, set this parameter to the subsequent values of  that's returned in each response to continue paging through the results. Continue this pattern until  is null, which signifies the end of the paged results.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="responseOptions">Options you can specify for the response. This parameter is null by default.You can primarily use this parameter to return volume price band information in product details, which you can then display on category pages and search results depanding on your theme configuration. To return volume price band information, set this parameter to .</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.ProductCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProducts(dataViewMode,  filter,  startIndex,  pageSize,  sortBy,  responseOptions,  cursorMark,  responseFields);
		///   var productCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductCollection> GetProductsClient(DataViewMode dataViewMode, string filter =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string responseOptions =  null, string cursorMark =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.GetProductsUrl(filter, startIndex, pageSize, sortBy, responseOptions, cursorMark, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the active inventory level information associated with the product or location specified in the request.
		/// </summary>
		/// <param name="locationCodes">Array of location codes for which to retrieve product inventory information.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductInventory(dataViewMode,  productCode,  locationCodes,  responseFields);
		///   var locationInventoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> GetProductInventoryClient(DataViewMode dataViewMode, string productCode, string locationCodes =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.GetProductInventoryUrl(productCode, locationCodes, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves information about a single product given its product code.
		/// </summary>
		/// <param name="acceptVariantProductCode">Specifies whether to accept a product variant's code as the .When you set this parameter to , you can pass in a product variant's code in the GetProduct call to retrieve the product variant details that are associated with the base product.</param>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="supressOutOfStock404">Specifies whether to supress the 404 error when the product is out of stock.</param>
		/// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.Product"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProduct(dataViewMode,  productCode,  variationProductCode,  allowInactive,  skipInventoryCheck,  supressOutOfStock404,  quantity,  acceptVariantProductCode,  responseFields);
		///   var productClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.Product> GetProductClient(DataViewMode dataViewMode, string productCode, string variationProductCode =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, bool? supressOutOfStock404 =  null, int? quantity =  null, bool? acceptVariantProductCode =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.GetProductUrl(productCode, variationProductCode, allowInactive, skipInventoryCheck, supressOutOfStock404, quantity, acceptVariantProductCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.Product>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves information about a single product given its product code for  to index in the search engine
		/// </summary>
		/// <param name="lastModifiedDate">The date when the product was last updated.</param>
		/// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
		/// <param name="productVersion">The product version.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.Product"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductForIndexing(dataViewMode,  productCode,  productVersion,  lastModifiedDate,  responseFields);
		///   var productClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.Product> GetProductForIndexingClient(DataViewMode dataViewMode, string productCode, long? productVersion =  null, DateTime? lastModifiedDate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.GetProductForIndexingUrl(productCode, productVersion, lastModifiedDate, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.Product>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new product configuration each time a shopper selects a product option value. After the shopper defines values for all required product options, the shopper can add the product configuration to a cart.
		/// </summary>
		/// <param name="includeOptionDetails">If true, the response returns details about the product. If false, returns a product summary such as the product name, price, and sale price.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="productOptionSelections">For a product with shopper-configurable options, the properties of the product options selected by the shopper.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ConfiguredProduct( productOptionSelections,  productCode,  includeOptionDetails,  skipInventoryCheck,  quantity,  responseFields);
		///   var configuredProductClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct> ConfiguredProductClient(Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? includeOptionDetails =  null, bool? skipInventoryCheck =  null, int? quantity =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.ConfiguredProductUrl(productCode, includeOptionDetails, skipInventoryCheck, quantity, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections>(productOptionSelections);
			return mozuClient;

		}

		/// <summary>
		/// Validate the final state of shopper-selected options.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="productOptionSelections">For a product with shopper-configurable options, the properties of the product options selected by the shopper.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ValidateProduct( productOptionSelections,  productCode,  skipInventoryCheck,  quantity,  responseFields);
		///   var productValidationSummaryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary> ValidateProductClient(Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? skipInventoryCheck =  null, int? quantity =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.ValidateProductUrl(productCode, skipInventoryCheck, quantity, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections>(productOptionSelections);
			return mozuClient;

		}

		/// <summary>
		/// Evaluates whether a collection of discounts specified in the request can be redeemed for the supplied product code.
		/// </summary>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="skipInventoryCheck">If true, skip the process to validate inventory when creating this product reservation.</param>
		/// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
		/// <param name="discountSelections">The discounts to evaluate for a specified product code at the time of purchase.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ValidateDiscounts( discountSelections,  productCode,  variationProductCode,  customerAccountId,  allowInactive,  skipInventoryCheck,  responseFields);
		///   var discountValidationSummaryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary> ValidateDiscountsClient(Mozu.Api.Contracts.ProductRuntime.DiscountSelections discountSelections, string productCode, string variationProductCode =  null, int? customerAccountId =  null, bool? allowInactive =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.ValidateDiscountsUrl(productCode, variationProductCode, customerAccountId, allowInactive, skipInventoryCheck, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductRuntime.DiscountSelections>(discountSelections);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the product cost based on a list of product codes. The product cost is the amount the merchant pays for the product—it is not the price that the shopper sees on the storefront (which is usually higher).
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.ProductCostCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductCosts(dataViewMode,  query,  responseFields);
		///   var productCostCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductCostCollection> GetProductCostsClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductRuntime.ProductCostQuery query, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.GetProductCostsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductCostCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductRuntime.ProductCostQuery>(query)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves product inventories for the storefront displayed products.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductInventories(dataViewMode,  query,  responseFields);
		///   var locationInventoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection> GetProductInventoriesClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductRuntime.LocationInventoryQuery query, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.ProductUrl.GetProductInventoriesUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductRuntime.LocationInventoryQuery>(query)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


