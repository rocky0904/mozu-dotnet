
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Vocabulary values are predefined for an attribute.
	/// </summary>
	public partial class AttributeVocabularyValueClient 	{
		
		/// <summary>
		/// Retrieves a list of vocabulary values defined for the attribute specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValues(dataViewMode,  attributeFQN);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> GetAttributeVocabularyValuesClient(DataViewMode dataViewMode, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.GetAttributeVocabularyValuesUrl(attributeFQN);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValueLocalizedContents(dataViewMode,  attributeFQN,  value);
		///   var attributeVocabularyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> GetAttributeVocabularyValueLocalizedContentsClient(DataViewMode dataViewMode, string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.GetAttributeVocabularyValueLocalizedContentsUrl(attributeFQN, value);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValueLocalizedContent(dataViewMode,  attributeFQN,  value,  localeCode,  responseFields);
		///   var attributeVocabularyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> GetAttributeVocabularyValueLocalizedContentClient(DataViewMode dataViewMode, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.GetAttributeVocabularyValueLocalizedContentUrl(attributeFQN, value, localeCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a vocabulary value defined for an attribute by providing the attribute's fully qualified name and the value to retrieve.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary to retrieve. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValue(dataViewMode,  attributeFQN,  value,  responseFields);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> GetAttributeVocabularyValueClient(DataViewMode dataViewMode, string attributeFQN, string value, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.GetAttributeVocabularyValueUrl(attributeFQN, value, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAttributeVocabularyValueLocalizedContent( localizedContent,  attributeFQN,  value,  responseFields);
		///   var attributeVocabularyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> AddAttributeVocabularyValueLocalizedContentClient(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.AddAttributeVocabularyValueLocalizedContentUrl(attributeFQN, value, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>(localizedContent);
			return mozuClient;

		}

		/// <summary>
		/// Creates a vocabulary value for a defined product attribute.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAttributeVocabularyValue( attributeVocabularyValue,  attributeFQN,  responseFields);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> AddAttributeVocabularyValueClient(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.AddAttributeVocabularyValueUrl(attributeFQN, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>(attributeVocabularyValue);
			return mozuClient;

		}

		/// <summary>
		/// Update existing vocabulary values for an attribute.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="vocabularyValues">The actual vocabulary values for the attribute being updated.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAttributeVocabularyValues( vocabularyValues,  attributeFQN);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> UpdateAttributeVocabularyValuesClient(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> vocabularyValues, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.UpdateAttributeVocabularyValuesUrl(attributeFQN);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>>(vocabularyValues);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAttributeVocabularyValueLocalizedContents( localizedContent,  attributeFQN,  value);
		///   var attributeVocabularyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>> UpdateAttributeVocabularyValueLocalizedContentsClient(List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> localizedContent, string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.UpdateAttributeVocabularyValueLocalizedContentsUrl(attributeFQN, value);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>>(localizedContent);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAttributeVocabularyValueLocalizedContent( localizedContent,  attributeFQN,  value,  localeCode,  responseFields);
		///   var attributeVocabularyValueLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent> UpdateAttributeVocabularyValueLocalizedContentClient(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent localizedContent, string attributeFQN, string value, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.UpdateAttributeVocabularyValueLocalizedContentUrl(attributeFQN, value, localeCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValueLocalizedContent>(localizedContent);
			return mozuClient;

		}

		/// <summary>
		/// Updates existing attribute vocabulary values.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields"></param>
		/// <param name="value">The actual unique value of the attribute vocabulary value to update. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAttributeVocabularyValue( attributeVocabularyValue,  attributeFQN,  value,  responseFields);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> UpdateAttributeVocabularyValueClient(Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string value, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.UpdateAttributeVocabularyValueUrl(attributeFQN, value, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>(attributeVocabularyValue);
			return mozuClient;

		}

		/// <summary>
		/// Deletes an attribute's vocabulary value.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="value">The actual unique value of the attribute vocabulary to delete. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAttributeVocabularyValue( attributeFQN,  value);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAttributeVocabularyValueClient(string attributeFQN, string value)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.DeleteAttributeVocabularyValueUrl(attributeFQN, value);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeFQN"></param>
		/// <param name="localeCode"></param>
		/// <param name="value"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAttributeVocabularyValueLocalizedContent( attributeFQN,  value,  localeCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAttributeVocabularyValueLocalizedContentClient(string attributeFQN, string value, string localeCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.DeleteAttributeVocabularyValueLocalizedContentUrl(attributeFQN, value, localeCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


