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
    /// Describes the networking features of the instance type.
    /// </summary>
    public partial class NetworkInfo
    {
        private EnaSupport _enaSupport;
        private int? _ipv4AddressesPerInterface;
        private int? _ipv6AddressesPerInterface;
        private bool? _ipv6Supported;
        private int? _maximumNetworkInterfaces;
        private string _networkPerformance;

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Indicates whether Elastic Network Adapter (ENA) is supported.
        /// </para>
        /// </summary>
        public EnaSupport EnaSupport
        {
            get { return this._enaSupport; }
            set { this._enaSupport = value; }
        }

        // Check to see if EnaSupport property is set
        internal bool IsSetEnaSupport()
        {
            return this._enaSupport != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4AddressesPerInterface. 
        /// <para>
        /// The maximum number of IPv4 addresses per network interface.
        /// </para>
        /// </summary>
        public int Ipv4AddressesPerInterface
        {
            get { return this._ipv4AddressesPerInterface.GetValueOrDefault(); }
            set { this._ipv4AddressesPerInterface = value; }
        }

        // Check to see if Ipv4AddressesPerInterface property is set
        internal bool IsSetIpv4AddressesPerInterface()
        {
            return this._ipv4AddressesPerInterface.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6AddressesPerInterface. 
        /// <para>
        /// The maximum number of IPv6 addresses per network interface.
        /// </para>
        /// </summary>
        public int Ipv6AddressesPerInterface
        {
            get { return this._ipv6AddressesPerInterface.GetValueOrDefault(); }
            set { this._ipv6AddressesPerInterface = value; }
        }

        // Check to see if Ipv6AddressesPerInterface property is set
        internal bool IsSetIpv6AddressesPerInterface()
        {
            return this._ipv6AddressesPerInterface.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Supported. 
        /// <para>
        /// Indicates whether IPv6 is supported.
        /// </para>
        /// </summary>
        public bool Ipv6Supported
        {
            get { return this._ipv6Supported.GetValueOrDefault(); }
            set { this._ipv6Supported = value; }
        }

        // Check to see if Ipv6Supported property is set
        internal bool IsSetIpv6Supported()
        {
            return this._ipv6Supported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumNetworkInterfaces. 
        /// <para>
        /// The maximum number of network interfaces for the instance type.
        /// </para>
        /// </summary>
        public int MaximumNetworkInterfaces
        {
            get { return this._maximumNetworkInterfaces.GetValueOrDefault(); }
            set { this._maximumNetworkInterfaces = value; }
        }

        // Check to see if MaximumNetworkInterfaces property is set
        internal bool IsSetMaximumNetworkInterfaces()
        {
            return this._maximumNetworkInterfaces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// Describes the network performance.
        /// </para>
        /// </summary>
        public string NetworkPerformance
        {
            get { return this._networkPerformance; }
            set { this._networkPerformance = value; }
        }

        // Check to see if NetworkPerformance property is set
        internal bool IsSetNetworkPerformance()
        {
            return this._networkPerformance != null;
        }

    }
}