// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Request parameters for create a new group
    /// </summary>
    public partial class GroupCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the GroupCreateParameters class.
        /// </summary>
        public GroupCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the GroupCreateParameters class.
        /// </summary>
        public GroupCreateParameters(string displayName, bool? mailEnabled, string mailNickname, bool? securityEnabled)
        {
            DisplayName = displayName;
            MailEnabled = mailEnabled;
            MailNickname = mailNickname;
            SecurityEnabled = securityEnabled;
        }

        /// <summary>
        /// Group display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Mail
        /// </summary>
        [JsonProperty(PropertyName = "mailEnabled")]
        public bool? MailEnabled { get; set; }

        /// <summary>
        /// Mail nick name
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Is security enabled
        /// </summary>
        [JsonProperty(PropertyName = "securityEnabled")]
        public bool? SecurityEnabled { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (MailEnabled == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MailEnabled");
            }
            if (MailNickname == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MailNickname");
            }
            if (SecurityEnabled == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecurityEnabled");
            }
        }
    }
}
