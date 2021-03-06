// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The instance view of a virtual machine extension.
    /// </summary>
    public partial class VirtualMachineExtensionInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionInstanceView class.
        /// </summary>
        public VirtualMachineExtensionInstanceView() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionInstanceView class.
        /// </summary>
        public VirtualMachineExtensionInstanceView(string name = default(string), string type = default(string), string typeHandlerVersion = default(string), IList<InstanceViewStatus> substatuses = default(IList<InstanceViewStatus>), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>))
        {
            Name = name;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            Substatuses = substatuses;
            Statuses = statuses;
        }

        /// <summary>
        /// Gets or sets the virtual machine extension name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full type of the extension handler which includes
        /// both publisher and type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "substatuses")]
        public IList<InstanceViewStatus> Substatuses { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

    }
}
