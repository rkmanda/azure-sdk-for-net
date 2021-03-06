// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL table partition item.
    /// </summary>
    public partial class USqlTablePartition : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlTablePartition class.
        /// </summary>
        public USqlTablePartition() { }

        /// <summary>
        /// Initializes a new instance of the USqlTablePartition class.
        /// </summary>
        public USqlTablePartition(string computeAccountName = default(string), Guid? version = default(Guid?), string databaseName = default(string), string schemaName = default(string), string name = default(string), int? indexId = default(int?), IList<string> label = default(IList<string>))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            Name = name;
            IndexId = indexId;
            Label = label;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this table
        /// partition and database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the table partition.
        /// </summary>
        [JsonProperty(PropertyName = "partitionName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the index ID for this partition.
        /// </summary>
        [JsonProperty(PropertyName = "indexId")]
        public int? IndexId { get; set; }

        /// <summary>
        /// Gets or sets the list of labels associated with this partition.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public IList<string> Label { get; set; }

    }
}
