
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Reference
{
		///
		///	The state code, name, and tags, if applicable. 
		///
		public class State
		{
			///
			///The two character state code. 
			///
			public string Code { get; set; }

			///
			///The user supplied name that appears in . You can use this field for identification purposes.
			///
			public string Name { get; set; }

			///
			///Distinguishing information about a state, such as IsArmedForces or IsUSTerritory
			///
			public string Tags { get; set; }

		}

}