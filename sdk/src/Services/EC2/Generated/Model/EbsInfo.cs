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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the Amazon EBS features supported by the instance type.
    /// </summary>
    public partial class EbsInfo
    {
        private EbsOptimizedSupport _ebsOptimizedSupport;
        private EbsEncryptionSupport _encryptionSupport;

        /// <summary>
        /// Gets and sets the property EbsOptimizedSupport. 
        /// <para>
        /// Indicates that the instance type is Amazon EBS-optimized. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSOptimized.html">Amazon
        /// EBS-Optimized Instances</a> in <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        public EbsOptimizedSupport EbsOptimizedSupport
        {
            get { return this._ebsOptimizedSupport; }
            set { this._ebsOptimizedSupport = value; }
        }

        // Check to see if EbsOptimizedSupport property is set
        internal bool IsSetEbsOptimizedSupport()
        {
            return this._ebsOptimizedSupport != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionSupport. 
        /// <para>
        /// Indicates whether Amazon EBS encryption is supported.
        /// </para>
        /// </summary>
        public EbsEncryptionSupport EncryptionSupport
        {
            get { return this._encryptionSupport; }
            set { this._encryptionSupport = value; }
        }

        // Check to see if EncryptionSupport property is set
        internal bool IsSetEncryptionSupport()
        {
            return this._encryptionSupport != null;
        }

    }
}