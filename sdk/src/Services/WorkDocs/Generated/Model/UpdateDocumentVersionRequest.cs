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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDocumentVersion operation.
    /// Changes the status of the document version to ACTIVE. 
    /// 
    ///  
    /// <para>
    /// Amazon WorkDocs also sets its document container to ACTIVE. This is the last step
    /// in a document upload, after the client uploads the document to an S3-presigned URL
    /// returned by <a>InitiateDocumentVersionUpload</a>. 
    /// </para>
    /// </summary>
    public partial class UpdateDocumentVersionRequest : AmazonWorkDocsRequest
    {
        private string _documentId;
        private string _versionId;
        private DocumentVersionStatus _versionStatus;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The ID of the document.
        /// </para>
        /// </summary>
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID of the document.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// The status of the version.
        /// </para>
        /// </summary>
        public DocumentVersionStatus VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }

        // Check to see if VersionStatus property is set
        internal bool IsSetVersionStatus()
        {
            return this._versionStatus != null;
        }

    }
}