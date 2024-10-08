/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Opc.Ua.WebApi.Client.OpenAPIDateConverter;

namespace Opc.Ua.WebApi.Model
{
    /// <summary>
    /// FindServersResponse
    /// </summary>
    [DataContract(Name = "FindServersResponse")]
    public partial class FindServersResponse : IEquatable<FindServersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindServersResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="servers">servers.</param>
        public FindServersResponse(ResponseHeader responseHeader = default(ResponseHeader), List<ApplicationDescription> servers = default(List<ApplicationDescription>))
        {
            this.ResponseHeader = responseHeader;
            this.Servers = servers;
        }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [DataMember(Name = "ResponseHeader", EmitDefaultValue = false)]
        public ResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// Gets or Sets Servers
        /// </summary>
        [DataMember(Name = "Servers", EmitDefaultValue = false)]
        public List<ApplicationDescription> Servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FindServersResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FindServersResponse);
        }

        /// <summary>
        /// Returns true if FindServersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FindServersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindServersResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResponseHeader == input.ResponseHeader ||
                    (this.ResponseHeader != null &&
                    this.ResponseHeader.Equals(input.ResponseHeader))
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResponseHeader != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseHeader.GetHashCode();
                }
                if (this.Servers != null)
                {
                    hashCode = (hashCode * 59) + this.Servers.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
