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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePresignedNotebookInstanceUrl operation.
    /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
    /// In the Amazon SageMaker console, when you choose <code>Open</code> next to a notebook
    /// instance, Amazon SageMaker opens a new tab showing the Jupyter server home page from
    /// the notebook instance. The console uses this API to get the URL and show the page.
    /// 
    ///  
    /// <para>
    /// You can restrict access to this API and to the URL that it returns to a list of IP
    /// addresses that you specify. To restrict access, attach an IAM policy that denies access
    /// to this API unless the call comes from an IP address in the specified list to every
    /// AWS Identity and Access Management user, group, or role used to access the notebook
    /// instance. Use the <code>NotIpAddress</code> condition operator and the <code>aws:SourceIP</code>
    /// condition context key to specify the list of IP addresses that you want to have access
    /// to the notebook instance. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/nbi-ip-filter.html">Limit
    /// Access to a Notebook Instance by IP Address</a>.
    /// </para>
    /// </summary>
    public partial class CreatePresignedNotebookInstanceUrlRequest : AmazonSageMakerRequest
    {
        private string _notebookInstanceName;
        private int? _sessionExpirationDurationInSeconds;

        /// <summary>
        /// Gets and sets the property NotebookInstanceName. 
        /// <para>
        /// The name of the notebook instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string NotebookInstanceName
        {
            get { return this._notebookInstanceName; }
            set { this._notebookInstanceName = value; }
        }

        // Check to see if NotebookInstanceName property is set
        internal bool IsSetNotebookInstanceName()
        {
            return this._notebookInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionExpirationDurationInSeconds. 
        /// <para>
        /// The duration of the session, in seconds. The default is 12 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1800, Max=43200)]
        public int SessionExpirationDurationInSeconds
        {
            get { return this._sessionExpirationDurationInSeconds.GetValueOrDefault(); }
            set { this._sessionExpirationDurationInSeconds = value; }
        }

        // Check to see if SessionExpirationDurationInSeconds property is set
        internal bool IsSetSessionExpirationDurationInSeconds()
        {
            return this._sessionExpirationDurationInSeconds.HasValue; 
        }

    }
}