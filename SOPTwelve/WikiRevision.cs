using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.FileApi.Model;

namespace SOPTwelve
{
	/// <summary>
	/// Corresponds to the screen WI301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WikiRevision : Entity, ITopLevelEntity
	{

		[DataMember(Name = "PageID", EmitDefaultValue = false)]
		public StringValue? PageID { get; set; }


		[DataMember(Name = "Language", EmitDefaultValue = false)]
		public StringValue? Language { get; set; }


		[DataMember(Name = "PageRevisionID", EmitDefaultValue = false)]
		public StringValue? PageRevisionID { get; set; }

		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// Gets or Sets Files
		/// </summary>
		[DataMember(Name = "WikiFiles", EmitDefaultValue = false)]
		public List<WikiFileInPage>? WikiFiles
		{
			get; set;
		}

		public virtual string GetEndpointPath()
		{
			return "entity/Wiki/24.200.001";
		}
	}
}