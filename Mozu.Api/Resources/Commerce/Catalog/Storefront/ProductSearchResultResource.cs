
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Use the Product Search resource to provide dynamic search results to shoppers as they browse and search for products on the web storefront, and to suggest possible search terms as the shopper enters text.
	/// </summary>
	public partial class ProductSearchResultResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ProductSearchResultResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ProductSearchResultResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductSearchResultResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Random access paging computes a set of , which can each then be provided to the  operation in the  resource or the  operation in the  resource. You can provide the computed groups in any order to the operations, and can therefore parallelize calls to retrieve products more quickly. To generate the set of , call this () operation, in which you can optionally provide query and/or filter parameters to limit the products matched by the cursor. After executing this operation, pass one of the returned  to the  parameter of the  or  operations.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var productSearchRandomAccessCursor = productsearchresult.GetRandomAccessCursor( query,  filter,  pageSize,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor GetRandomAccessCursor(string query =  null, string filter =  null, int? pageSize =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.GetRandomAccessCursorClient( query,  filter,  pageSize,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Random access paging computes a set of , which can each then be provided to the  operation in the  resource or the  operation in the  resource. You can provide the computed groups in any order to the operations, and can therefore parallelize calls to retrieve products more quickly. To generate the set of , call this () operation, in which you can optionally provide query and/or filter parameters to limit the products matched by the cursor. After executing this operation, pass one of the returned  to the  parameter of the  or  operations.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var productSearchRandomAccessCursor = await productsearchresult.GetRandomAccessCursorAsync( query,  filter,  pageSize,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor> GetRandomAccessCursorAsync(string query =  null, string filter =  null, int? pageSize =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductSearchRandomAccessCursor> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.GetRandomAccessCursorClient( query,  filter,  pageSize,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Searches the categories displayed on the web storefront for products or product options that the shopper types in a search query.
		/// </summary>
		/// <param name="cursorMark">In your first deep paged request, set this parameter to . Then, in all subsequent requests, set this parameter to the subsequent values of  that's returned in each response to continue paging through the results. Continue this pattern until  is null, which signifies the end of the paged results.</param>
		/// <param name="enableSearchTuningRules">Enables search tuning rules on your site.</param>
		/// <param name="facet">Individually list the facet fields you want to display in a web storefront product search.</param>
		/// <param name="facetFieldRangeQuery">Display a range facet not specified in a template in a web storefront product search by listing the facet field and the range to display.</param>
		/// <param name="facetHierDepth">If filtering using category facets in a hierarchy, the number of category hierarchy levels to return for the facet. This option is only available for category facets.</param>
		/// <param name="facetHierPrefix">If filtering using category facets in a hierarchy, the parent categories you want to skip in the storefront product search. This parameter is only available for category facets.</param>
		/// <param name="facetHierValue">If filtering using category facets in a hierarchy, the category in the hierarchy to begin faceting on. This parameter is only available for category facets.</param>
		/// <param name="facetPageSize">The number of facet values to return for one or more facets.</param>
		/// <param name="facetPrefix">Use this parameter to filter facet values that are returned by an associated search result by a prefix.For example, to filter on colors that start with b, such as blue, black, or brown you can specify the following:</param>
		/// <param name="facetSettings">Settings reserved for future facet search functionality on a web storefront product search.</param>
		/// <param name="facetStartIndex">When paging through multiple facets, the startIndex value for each facet.</param>
		/// <param name="facetTemplate">The facet template to use on the storefront. A template displays all facets associated with the template on the web storefront product search. Currently, only category-level facet templates are available.</param>
		/// <param name="facetTemplateExclude">A comma-separated list of the facets to exclude from the facetTemplate.        </param>
		/// <param name="facetTemplateSubset">Display a subset of the facets defined in the template specified in facetTemplate parameter.</param>
		/// <param name="facetValueFilter">The facet values to apply to the filter.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="responseOptions">Options you can specify for the response. This parameter is null by default.You can primarily use this parameter to return volume price band information in product details, which you can then display on category pages and search results depanding on your theme configuration. To return volume price band information, set this parameter to .</param>
		/// <param name="searchSettings">The settings to control product search and indexing behavior.</param>
		/// <param name="searchTuningRuleCode">The unique identifier of the search tuning rule.</param>
		/// <param name="searchTuningRuleContext">The category ID that the search tuning rule applies to.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductSearchResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var productSearchResult = productsearchresult.Search( query,  filter,  facetTemplate,  facetTemplateSubset,  facet,  facetFieldRangeQuery,  facetHierPrefix,  facetHierValue,  facetHierDepth,  facetStartIndex,  facetPageSize,  facetSettings,  facetValueFilter,  sortBy,  pageSize,  startIndex,  searchSettings,  enableSearchTuningRules,  searchTuningRuleContext,  searchTuningRuleCode,  facetTemplateExclude,  facetPrefix,  responseOptions,  cursorMark,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.ProductSearchResult Search(string query =  null, string filter =  null, string facetTemplate =  null, string facetTemplateSubset =  null, string facet =  null, string facetFieldRangeQuery =  null, string facetHierPrefix =  null, string facetHierValue =  null, string facetHierDepth =  null, string facetStartIndex =  null, string facetPageSize =  null, string facetSettings =  null, string facetValueFilter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string searchSettings =  null, bool? enableSearchTuningRules =  null, string searchTuningRuleContext =  null, string searchTuningRuleCode =  null, string facetTemplateExclude =  null, string facetPrefix =  null, string responseOptions =  null, string cursorMark =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductSearchResult> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SearchClient( query,  filter,  facetTemplate,  facetTemplateSubset,  facet,  facetFieldRangeQuery,  facetHierPrefix,  facetHierValue,  facetHierDepth,  facetStartIndex,  facetPageSize,  facetSettings,  facetValueFilter,  sortBy,  pageSize,  startIndex,  searchSettings,  enableSearchTuningRules,  searchTuningRuleContext,  searchTuningRuleCode,  facetTemplateExclude,  facetPrefix,  responseOptions,  cursorMark,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Searches the categories displayed on the web storefront for products or product options that the shopper types in a search query.
		/// </summary>
		/// <param name="cursorMark">In your first deep paged request, set this parameter to . Then, in all subsequent requests, set this parameter to the subsequent values of  that's returned in each response to continue paging through the results. Continue this pattern until  is null, which signifies the end of the paged results.</param>
		/// <param name="enableSearchTuningRules">Enables search tuning rules on your site.</param>
		/// <param name="facet">Individually list the facet fields you want to display in a web storefront product search.</param>
		/// <param name="facetFieldRangeQuery">Display a range facet not specified in a template in a web storefront product search by listing the facet field and the range to display.</param>
		/// <param name="facetHierDepth">If filtering using category facets in a hierarchy, the number of category hierarchy levels to return for the facet. This option is only available for category facets.</param>
		/// <param name="facetHierPrefix">If filtering using category facets in a hierarchy, the parent categories you want to skip in the storefront product search. This parameter is only available for category facets.</param>
		/// <param name="facetHierValue">If filtering using category facets in a hierarchy, the category in the hierarchy to begin faceting on. This parameter is only available for category facets.</param>
		/// <param name="facetPageSize">The number of facet values to return for one or more facets.</param>
		/// <param name="facetPrefix">Use this parameter to filter facet values that are returned by an associated search result by a prefix.For example, to filter on colors that start with b, such as blue, black, or brown you can specify the following:</param>
		/// <param name="facetSettings">Settings reserved for future facet search functionality on a web storefront product search.</param>
		/// <param name="facetStartIndex">When paging through multiple facets, the startIndex value for each facet.</param>
		/// <param name="facetTemplate">The facet template to use on the storefront. A template displays all facets associated with the template on the web storefront product search. Currently, only category-level facet templates are available.</param>
		/// <param name="facetTemplateExclude">A comma-separated list of the facets to exclude from the facetTemplate.        </param>
		/// <param name="facetTemplateSubset">Display a subset of the facets defined in the template specified in facetTemplate parameter.</param>
		/// <param name="facetValueFilter">The facet values to apply to the filter.</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="responseOptions">Options you can specify for the response. This parameter is null by default.You can primarily use this parameter to return volume price band information in product details, which you can then display on category pages and search results depanding on your theme configuration. To return volume price band information, set this parameter to .</param>
		/// <param name="searchSettings">The settings to control product search and indexing behavior.</param>
		/// <param name="searchTuningRuleCode">The unique identifier of the search tuning rule.</param>
		/// <param name="searchTuningRuleContext">The category ID that the search tuning rule applies to.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ProductSearchResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var productSearchResult = await productsearchresult.SearchAsync( query,  filter,  facetTemplate,  facetTemplateSubset,  facet,  facetFieldRangeQuery,  facetHierPrefix,  facetHierValue,  facetHierDepth,  facetStartIndex,  facetPageSize,  facetSettings,  facetValueFilter,  sortBy,  pageSize,  startIndex,  searchSettings,  enableSearchTuningRules,  searchTuningRuleContext,  searchTuningRuleCode,  facetTemplateExclude,  facetPrefix,  responseOptions,  cursorMark,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ProductSearchResult> SearchAsync(string query =  null, string filter =  null, string facetTemplate =  null, string facetTemplateSubset =  null, string facet =  null, string facetFieldRangeQuery =  null, string facetHierPrefix =  null, string facetHierValue =  null, string facetHierDepth =  null, string facetStartIndex =  null, string facetPageSize =  null, string facetSettings =  null, string facetValueFilter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string searchSettings =  null, bool? enableSearchTuningRules =  null, string searchTuningRuleContext =  null, string searchTuningRuleCode =  null, string facetTemplateExclude =  null, string facetPrefix =  null, string responseOptions =  null, string cursorMark =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ProductSearchResult> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SearchClient( query,  filter,  facetTemplate,  facetTemplateSubset,  facet,  facetFieldRangeQuery,  facetHierPrefix,  facetHierValue,  facetHierDepth,  facetStartIndex,  facetPageSize,  facetSettings,  facetValueFilter,  sortBy,  pageSize,  startIndex,  searchSettings,  enableSearchTuningRules,  searchTuningRuleContext,  searchTuningRuleCode,  facetTemplateExclude,  facetPrefix,  responseOptions,  cursorMark,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Suggests possible search terms as the shopper enters search text.
		/// </summary>
		/// <param name="groups">Specifies the group that you want this operation to return in the response. This parameter accepts one or more values, separated by comma.For example, if you set this parameter to , then this operation returns a  object that contains suggestions for products that match the user entered characters in the search field.The valid values for this parameter are the following:*  — Indicates that products should be matched against and returned in the response. The search  value is compared against product name and code. The response contains a  with a name of  and a collection of . Each collection item has a  of Product and contains a  equal to a complete product object.*  — Indicates that categories should be matched against and returned in the response. The search  value is compared to category name.  The response contains a  with a name of  and a collection of . Each collection item has a  of Category and contains a  equal to a complete category object.*  — Indicates that previously used search terms (keywords) should be matched against and returned in the response, sorted by frequency of use. Keep in mind that it is not currently possible to edit or remove search terms that may be considered undesirable via the  API. The response contains a  with a name of  and a collection of . Each collection item has a  of Term and contains a  equal to a string value of the matched search term.The default value is ; however, the  Core Theme only integrates  and ignores the  group.This operation only returns data that is then made available to your theme. If you set this paramter to multiple values,  returns multiple  in the response. Depending on your requirements, you can then customize your theme to display the groups together or as separate lists in the displayed search suggestions.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var searchSuggestionResult = productsearchresult.Suggest( query,  groups,  pageSize,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult Suggest(string query =  null, string groups =  null, int? pageSize =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SuggestClient( query,  groups,  pageSize,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Suggests possible search terms as the shopper enters search text.
		/// </summary>
		/// <param name="groups">Specifies the group that you want this operation to return in the response. This parameter accepts one or more values, separated by comma.For example, if you set this parameter to , then this operation returns a  object that contains suggestions for products that match the user entered characters in the search field.The valid values for this parameter are the following:*  — Indicates that products should be matched against and returned in the response. The search  value is compared against product name and code. The response contains a  with a name of  and a collection of . Each collection item has a  of Product and contains a  equal to a complete product object.*  — Indicates that categories should be matched against and returned in the response. The search  value is compared to category name.  The response contains a  with a name of  and a collection of . Each collection item has a  of Category and contains a  equal to a complete category object.*  — Indicates that previously used search terms (keywords) should be matched against and returned in the response, sorted by frequency of use. Keep in mind that it is not currently possible to edit or remove search terms that may be considered undesirable via the  API. The response contains a  with a name of  and a collection of . Each collection item has a  of Term and contains a  equal to a string value of the matched search term.The default value is ; however, the  Core Theme only integrates  and ignores the  group.This operation only returns data that is then made available to your theme. If you set this paramter to multiple values,  returns multiple  in the response. Depending on your requirements, you can then customize your theme to display the groups together or as separate lists in the displayed search suggestions.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="query">Properties for the product location inventory provided for queries to locate products by their location.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productsearchresult = new ProductSearchResult();
		///   var searchSuggestionResult = await productsearchresult.SuggestAsync( query,  groups,  pageSize,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult> SuggestAsync(string query =  null, string groups =  null, int? pageSize =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.SearchSuggestionResult> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductSearchResultClient.SuggestClient( query,  groups,  pageSize,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


