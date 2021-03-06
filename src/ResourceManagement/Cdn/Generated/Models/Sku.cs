// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The pricing tier (defines a CDN provider, feature list and rate) of the
    /// CDN profile.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of the pricing tier. Possible values
        /// include: 'Standard_Verizon', 'Premium_Verizon', 'Custom_Verizon',
        /// 'Standard_Akamai', 'Standard_ChinaCdn'</param>
        public Sku(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the pricing tier. Possible values include:
        /// 'Standard_Verizon', 'Premium_Verizon', 'Custom_Verizon',
        /// 'Standard_Akamai', 'Standard_ChinaCdn'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
