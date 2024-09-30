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
    /// DataValue
    /// </summary>
    [DataContract(Name = "DataValue")]
    public partial class DataValue : IEquatable<DataValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="sourceTimestamp">sourceTimestamp.</param>
        /// <param name="sourcePicoSeconds">sourcePicoSeconds.</param>
        /// <param name="serverTimestamp">serverTimestamp.</param>
        /// <param name="serverPicoSeconds">serverPicoSeconds.</param>
        public DataValue(Variant value = default(Variant), long statusCode = default(long), DateTime sourceTimestamp = default(DateTime), int sourcePicoSeconds = default(int), DateTime serverTimestamp = default(DateTime), int serverPicoSeconds = default(int))
        {
            this.Value = value;
            this.StatusCode = statusCode;
            this.SourceTimestamp = sourceTimestamp;
            this.SourcePicoSeconds = sourcePicoSeconds;
            this.ServerTimestamp = serverTimestamp;
            this.ServerPicoSeconds = serverPicoSeconds;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public Variant Value { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public long StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets SourceTimestamp
        /// </summary>
        [DataMember(Name = "SourceTimestamp", EmitDefaultValue = false)]
        public DateTime SourceTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets SourcePicoSeconds
        /// </summary>
        [DataMember(Name = "SourcePicoSeconds", EmitDefaultValue = false)]
        public int SourcePicoSeconds { get; set; }

        /// <summary>
        /// Gets or Sets ServerTimestamp
        /// </summary>
        [DataMember(Name = "ServerTimestamp", EmitDefaultValue = false)]
        public DateTime ServerTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets ServerPicoSeconds
        /// </summary>
        [DataMember(Name = "ServerPicoSeconds", EmitDefaultValue = false)]
        public int ServerPicoSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  SourceTimestamp: ").Append(SourceTimestamp).Append("\n");
            sb.Append("  SourcePicoSeconds: ").Append(SourcePicoSeconds).Append("\n");
            sb.Append("  ServerTimestamp: ").Append(ServerTimestamp).Append("\n");
            sb.Append("  ServerPicoSeconds: ").Append(ServerPicoSeconds).Append("\n");
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
            return this.Equals(input as DataValue);
        }

        /// <summary>
        /// Returns true if DataValue instances are equal
        /// </summary>
        /// <param name="input">Instance of DataValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.SourceTimestamp == input.SourceTimestamp ||
                    (this.SourceTimestamp != null &&
                    this.SourceTimestamp.Equals(input.SourceTimestamp))
                ) && 
                (
                    this.SourcePicoSeconds == input.SourcePicoSeconds ||
                    this.SourcePicoSeconds.Equals(input.SourcePicoSeconds)
                ) && 
                (
                    this.ServerTimestamp == input.ServerTimestamp ||
                    (this.ServerTimestamp != null &&
                    this.ServerTimestamp.Equals(input.ServerTimestamp))
                ) && 
                (
                    this.ServerPicoSeconds == input.ServerPicoSeconds ||
                    this.ServerPicoSeconds.Equals(input.ServerPicoSeconds)
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                if (this.SourceTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.SourceTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SourcePicoSeconds.GetHashCode();
                if (this.ServerTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.ServerTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServerPicoSeconds.GetHashCode();
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
            // StatusCode (long) maximum
            if (this.StatusCode > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, must be a value less than or equal to 4294967295.", new [] { "StatusCode" });
            }

            // StatusCode (long) minimum
            if (this.StatusCode < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, must be a value greater than or equal to 0.", new [] { "StatusCode" });
            }

            // SourcePicoSeconds (int) maximum
            if (this.SourcePicoSeconds > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourcePicoSeconds, must be a value less than or equal to 65535.", new [] { "SourcePicoSeconds" });
            }

            // SourcePicoSeconds (int) minimum
            if (this.SourcePicoSeconds < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourcePicoSeconds, must be a value greater than or equal to 0.", new [] { "SourcePicoSeconds" });
            }

            // ServerPicoSeconds (int) maximum
            if (this.ServerPicoSeconds > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ServerPicoSeconds, must be a value less than or equal to 65535.", new [] { "ServerPicoSeconds" });
            }

            // ServerPicoSeconds (int) minimum
            if (this.ServerPicoSeconds < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ServerPicoSeconds, must be a value greater than or equal to 0.", new [] { "ServerPicoSeconds" });
            }

            yield break;
        }
    }

}
