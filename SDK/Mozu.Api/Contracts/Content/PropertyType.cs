
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Content
{
		///
		///	Property type available for content. Property types are like templates that can be reused.
		///
		public class PropertyType
		{
			public string AdminName { get; set; }

			public string DataType { get; set; }

			public string InstallationPackage { get; set; }

			///
			///If true, this entity can be grouped.
			///
			public bool? IsAggregatable { get; set; }

			///
			///If true, the entity can be searched. If false, the entity cannot be searched.
			///
			public bool? IsQueryable { get; set; }

			///
			///If true, the property type results are sortable. If false, the property type results cannot be sorted by any options.
			///
			public bool? IsSortable { get; set; }

			///
			///The name of the content property type.
			///
			public string Name { get; set; }

			public string Namespace { get; set; }

			public string PropertyTypeFQN { get; set; }

			public string Version { get; set; }

		}

}