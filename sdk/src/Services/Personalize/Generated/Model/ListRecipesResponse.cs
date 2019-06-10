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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// This is the response object from the ListRecipes operation.
    /// </summary>
    public partial class ListRecipesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecipeSummary> _recipes = new List<RecipeSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token for getting the next set of recipes.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1300)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Recipes. 
        /// <para>
        /// The list of available recipes.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<RecipeSummary> Recipes
        {
            get { return this._recipes; }
            set { this._recipes = value; }
        }

        // Check to see if Recipes property is set
        internal bool IsSetRecipes()
        {
            return this._recipes != null && this._recipes.Count > 0; 
        }

    }
}