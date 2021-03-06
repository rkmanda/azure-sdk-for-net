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

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// This class represent the individual bandwidth schedule within a
    /// bandwidth policy
    /// </summary>
    public partial class BandwidthSchedule
    {
        private IList<int> _days;
        
        /// <summary>
        /// Required. Gets or sets the Days of week for which given schedule
        /// should be applied.
        /// </summary>
        public IList<int> Days
        {
            get { return this._days; }
            set { this._days = value; }
        }
        
        private int _rate;
        
        /// <summary>
        /// Required. Gets or sets the bandwidth rate in b/sec for the given
        /// schedule.
        /// </summary>
        public int Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }
        
        private string _start;
        
        /// <summary>
        /// Required. Gets or sets the start time from which the given schedule
        /// should be applied.
        /// </summary>
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }
        
        private string _stop;
        
        /// <summary>
        /// Required. Gets or sets the stop time till which the given schedule
        /// should be applied.
        /// </summary>
        public string Stop
        {
            get { return this._stop; }
            set { this._stop = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BandwidthSchedule class.
        /// </summary>
        public BandwidthSchedule()
        {
            this.Days = new List<int>();
        }
    }
}
