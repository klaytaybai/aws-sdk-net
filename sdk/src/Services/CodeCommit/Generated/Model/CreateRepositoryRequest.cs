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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRepository operation.
    /// Creates a new, empty repository.
    /// </summary>
    public partial class CreateRepositoryRequest : AmazonCodeCommitRequest
    {
        private string _repositoryDescription;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property RepositoryDescription. 
        /// <para>
        /// A comment or description about the new repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string RepositoryDescription
        {
            get { return this._repositoryDescription; }
            set { this._repositoryDescription = value; }
        }

        // Check to see if RepositoryDescription property is set
        internal bool IsSetRepositoryDescription()
        {
            return this._repositoryDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the new repository to be created.
        /// </para>
        ///  <note> 
        /// <para>
        /// The repository name must be unique across the calling AWS account. In addition, repository
        /// names are limited to 100 alphanumeric, dash, and underscore characters, and cannot
        /// include certain characters. For a full description of the limits on repository names,
        /// see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Limits</a>
        /// in the AWS CodeCommit User Guide. The suffix ".git" is prohibited.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}