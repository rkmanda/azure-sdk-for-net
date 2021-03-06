// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DataLakeAnalyticsAccountStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataLakeAnalyticsAccountStatus
    {
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Patching")]
        Patching,
        [EnumMember(Value = "Suspending")]
        Suspending,
        [EnumMember(Value = "Resuming")]
        Resuming,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Deleted")]
        Deleted
    }
}
