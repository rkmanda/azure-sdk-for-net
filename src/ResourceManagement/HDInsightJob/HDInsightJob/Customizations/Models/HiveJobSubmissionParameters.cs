// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Management.HDInsight.Job.Models
{
    /// <summary>
    /// Parameters specifying the HDInsight Hive job definition.
    /// </summary>
    public partial class HiveJobSubmissionParameters
    {
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> Arguments { get; set; }
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IDictionary<string, string> Defines { get; set; }
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> Files { get; set; }
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Query { get; set; }
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string StatusDir { get; set; }
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the HiveJobSubmissionParameters class.
        /// </summary>
        public HiveJobSubmissionParameters()
        {
        }

        internal string GetJobPostRequestContent()
        {
            // Check input parameters and transform them to required format before sending request to templeton.
            string content = string.Empty;
            content += !string.IsNullOrEmpty(this.UserName) ? string.Format("user.name={0}", this.UserName) : string.Empty;
            content += !string.IsNullOrEmpty(this.Query) ? string.Format("&execute={0}", this.Query) : string.Empty;
            content += !string.IsNullOrEmpty(this.File) ? string.Format("&file={0}", this.File) : string.Empty;
            content += ModelHelper.ConvertListToString(this.Arguments, "&arg=", "&arg=");
            content += ModelHelper.ConvertListToString(this.Files, "&files=", ",");
            content += ModelHelper.ConvertDictionaryToString(this.Defines, "&define=");
            content += ModelHelper.GetStatusDirectory(this.StatusDir);

            return content;
        }
    }
}
