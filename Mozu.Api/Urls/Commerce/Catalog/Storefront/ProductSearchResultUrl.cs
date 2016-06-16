
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Storefront
{
	public partial class ProductSearchResultUrl 
	{

		/// <summary>
        /// Get Resource Url for Search
        /// </summary>
        /// <param name="enableSearchTuningRules"></param>
        /// <param name="facet">Individually list the facet fields you want to display in a web storefront product search.</param>
        /// <param name="facetFieldRangeQuery">Display a range facet not specified in a template in a web storefront product search by listing the facet field and the range to display.</param>
        /// <param name="facetHierDepth">If filtering using category facets in a hierarchy, the number of category hierarchy levels to return for the facet. This option is only available for category facets.</param>
        /// <param name="facetHierPrefix">If filtering using category facets in a hierarchy, the parent categories you want to skip in the storefront product search. This parameter is only available for category facets.</param>
        /// <param name="facetHierValue">If filtering using category facets in a hierarchy, the category in the hierarchy to begin faceting on. This parameter is only available for category facets.</param>
        /// <param name="facetPageSize">The number of facet values to return for one or more facets.</param>
        /// <param name="facetPrefix"></param>
        /// <param name="facetSettings">Settings reserved for future facet search functionality on a web storefront product search.</param>
        /// <param name="facetStartIndex">When paging through multiple facets, the startIndex value for each facet.</param>
        /// <param name="facetTemplate">The facet template to use on the storefront. A template displays all facets associated with the template on the web storefront product search. Currently, only category-level facet templates are available.</param>
        /// <param name="facetTemplateExclude"></param>
        /// <param name="facetTemplateSubset">Display a subset of the facets defined in the template specified in facetTemplate parameter.</param>
        /// <param name="facetValueFilter">The facet values to apply to the filter.</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product search results by any of its properties, including product code, type, category, and name. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=categoryId+eq+12"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="query">The terms to search on.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="searchSettings"></param>
        /// <param name="searchTuningRuleCode"></param>
        /// <param name="searchTuningRuleContext"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SearchUrl(string query =  null, string filter =  null, string facetTemplate =  null, string facetTemplateSubset =  null, string facet =  null, string facetFieldRangeQuery =  null, string facetHierPrefix =  null, string facetHierValue =  null, string facetHierDepth =  null, string facetStartIndex =  null, string facetPageSize =  null, string facetSettings =  null, string facetValueFilter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, string searchSettings =  null, bool? enableSearchTuningRules =  null, string searchTuningRuleContext =  null, string searchTuningRuleCode =  null, string facetTemplateExclude =  null, string facetPrefix =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/productsearch/search/?query={query}&filter={filter}&facetTemplate={facetTemplate}&facetTemplateSubset={facetTemplateSubset}&facet={facet}&facetFieldRangeQuery={facetFieldRangeQuery}&facetHierPrefix={facetHierPrefix}&facetHierValue={facetHierValue}&facetHierDepth={facetHierDepth}&facetStartIndex={facetStartIndex}&facetPageSize={facetPageSize}&facetSettings={facetSettings}&facetValueFilter={facetValueFilter}&sortBy={sortBy}&pageSize={pageSize}&startIndex={startIndex}&searchSettings={searchSettings}&enableSearchTuningRules={enableSearchTuningRules}&searchTuningRuleContext={searchTuningRuleContext}&searchTuningRuleCode={searchTuningRuleCode}&facetTemplateExclude={facetTemplateExclude}&facetPrefix={facetPrefix}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "enableSearchTuningRules", enableSearchTuningRules);
			mozuUrl.FormatUrl( "facet", facet);
			mozuUrl.FormatUrl( "facetFieldRangeQuery", facetFieldRangeQuery);
			mozuUrl.FormatUrl( "facetHierDepth", facetHierDepth);
			mozuUrl.FormatUrl( "facetHierPrefix", facetHierPrefix);
			mozuUrl.FormatUrl( "facetHierValue", facetHierValue);
			mozuUrl.FormatUrl( "facetPageSize", facetPageSize);
			mozuUrl.FormatUrl( "facetPrefix", facetPrefix);
			mozuUrl.FormatUrl( "facetSettings", facetSettings);
			mozuUrl.FormatUrl( "facetStartIndex", facetStartIndex);
			mozuUrl.FormatUrl( "facetTemplate", facetTemplate);
			mozuUrl.FormatUrl( "facetTemplateExclude", facetTemplateExclude);
			mozuUrl.FormatUrl( "facetTemplateSubset", facetTemplateSubset);
			mozuUrl.FormatUrl( "facetValueFilter", facetValueFilter);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "query", query);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "searchSettings", searchSettings);
			mozuUrl.FormatUrl( "searchTuningRuleCode", searchTuningRuleCode);
			mozuUrl.FormatUrl( "searchTuningRuleContext", searchTuningRuleContext);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for Suggest
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="query"></param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SuggestUrl(string query =  null, string groups =  null, int? pageSize =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/storefront/productsearch/suggest?query={query}&groups={groups}&pageSize={pageSize}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "groups", groups);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "query", query);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

								
	}
}

