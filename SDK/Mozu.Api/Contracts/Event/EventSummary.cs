
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


namespace Mozu.Api.Contracts.Event
{
		public class EventSummary
		{
			public int? CatalogId { get; set; }

			public string CorrelationId { get; set; }

			public DateTime? CreateDate { get; set; }

			public string EntityId { get; set; }

			public string EventId { get; set; }

			public List<EventExtendedProperty> ExtendedProperties { get; set; }

			public int? MasterCatalogId { get; set; }

			public int? SiteId { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			public string Topic { get; set; }

		}

}