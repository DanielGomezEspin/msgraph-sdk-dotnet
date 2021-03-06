// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsImSubRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsImSubRequestBody
    {
    
        /// <summary>
        /// Gets or sets Inumber1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inumber1", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Inumber1 { get; set; }
    
        /// <summary>
        /// Gets or sets Inumber2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inumber2", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Inumber2 { get; set; }
    
    }
}
