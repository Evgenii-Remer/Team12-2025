﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace SOPTwelve
{
	/// <summary>
	/// Corresponds to the screen WI301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WikiFileInPage : Entity, ITopLevelEntity
	{

		[DataMember(Name = "PageID", EmitDefaultValue = false)]
		public StringValue? PageID { get; set; }


		[DataMember(Name = "Language", EmitDefaultValue = false)]
		public StringValue? Language { get; set; }

		[DataMember(Name = "FileID", EmitDefaultValue = false)]
		public StringValue? FileID { get; set; }

		[DataMember(Name = "PageRevisionID", EmitDefaultValue = false)]
		public IntValue? PageRevisionID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Wiki/24.200.001";
		}
	}
}