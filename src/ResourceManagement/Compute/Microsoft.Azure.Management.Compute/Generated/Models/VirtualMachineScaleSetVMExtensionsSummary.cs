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
    /// Extensions summary for virtual machines of a virtual machine scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetVMExtensionsSummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMExtensionsSummary class.
        /// </summary>
        public VirtualMachineScaleSetVMExtensionsSummary() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMExtensionsSummary class.
        /// </summary>
        public VirtualMachineScaleSetVMExtensionsSummary(string name = default(string), IList<VirtualMachineStatusCodeCount> statusesSummary = default(IList<VirtualMachineStatusCodeCount>))
        {
            Name = name;
            StatusesSummary = statusesSummary;
        }

        /// <summary>
        /// Gets the extension name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "statusesSummary")]
        public IList<VirtualMachineStatusCodeCount> StatusesSummary { get; private set; }

    }
}
