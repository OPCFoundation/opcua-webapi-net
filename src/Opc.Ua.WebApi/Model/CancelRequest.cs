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
    /// CancelRequest
    /// </summary>
    [DataContract(Name = "CancelRequest")]
    public partial class CancelRequest : IEquatable<CancelRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="requestHandle">requestHandle.</param>
        public CancelRequest(RequestHeader requestHeader = default(RequestHeader), long requestHandle = default(long))
        {
            this.RequestHeader = requestHeader;
            this.RequestHandle = requestHandle;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets RequestHandle
        /// </summary>
        [DataMember(Name = "RequestHandle", EmitDefaultValue = false)]
        public long RequestHandle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  RequestHandle: ").Append(RequestHandle).Append("\n");
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
            return this.Equals(input as CancelRequest);
        }

        /// <summary>
        /// Returns true if CancelRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestHeader == input.RequestHeader ||
                    (this.RequestHeader != null &&
                    this.RequestHeader.Equals(input.RequestHeader))
                ) && 
                (
                    this.RequestHandle == input.RequestHandle ||
                    this.RequestHandle.Equals(input.RequestHandle)
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
                if (this.RequestHeader != null)
                {
                    hashCode = (hashCode * 59) + this.RequestHeader.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestHandle.GetHashCode();
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
            // RequestHandle (long) maximum
            if (this.RequestHandle > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestHandle, must be a value less than or equal to 4294967295.", new [] { "RequestHandle" });
            }

            // RequestHandle (long) minimum
            if (this.RequestHandle < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestHandle, must be a value greater than or equal to 0.", new [] { "RequestHandle" });
            }

            yield break;
        }
    }

}
