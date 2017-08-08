/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about groups of on-premises instance tags.
    /// </summary>
    public partial class OnPremisesTagSet
    {
        private List<List<TagFilter>> _onPremisesTagSetList = new List<List<TagFilter>>();

        /// <summary>
        /// Gets and sets the property OnPremisesTagSetList. 
        /// <para>
        /// A list containing other lists of on-premises instance tag groups. In order for an
        /// instance to be included in the deployment group, it must be identified by all the
        /// tag groups in the list.
        /// </para>
        /// </summary>
        public List<List<TagFilter>> OnPremisesTagSetList
        {
            get { return this._onPremisesTagSetList; }
            set { this._onPremisesTagSetList = value; }
        }

        // Check to see if OnPremisesTagSetList property is set
        internal bool IsSetOnPremisesTagSetList()
        {
            return this._onPremisesTagSetList != null && this._onPremisesTagSetList.Count > 0; 
        }

    }
}