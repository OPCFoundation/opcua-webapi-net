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
    /// MonitoredItemModifyRequest
    /// </summary>
    [DataContract(Name = "MonitoredItemModifyRequest")]
    public partial class MonitoredItemModifyRequest : IEquatable<MonitoredItemModifyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoredItemModifyRequest" /> class.
        /// </summary>
        /// <param name="monitoredItemId">monitoredItemId.</param>
        /// <param name="requestedParameters">requestedParameters.</param>
        public MonitoredItemModifyRequest(long monitoredItemId = default(long), MonitoringParameters requestedParameters = default(MonitoringParameters))
        {
            this.MonitoredItemId = monitoredItemId;
            this.RequestedParameters = requestedParameters;
        }

        /// <summary>
        /// Gets or Sets MonitoredItemId
        /// </summary>
        [DataMember(Name = "MonitoredItemId", EmitDefaultValue = false)]
        public long MonitoredItemId { get; set; }

        /// <summary>
        /// Gets or Sets RequestedParameters
        /// </summary>
        [DataMember(Name = "RequestedParameters", EmitDefaultValue = false)]
        public MonitoringParameters RequestedParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonitoredItemModifyRequest {\n");
            sb.Append("  MonitoredItemId: ").Append(MonitoredItemId).Append("\n");
            sb.Append("  RequestedParameters: ").Append(RequestedParameters).Append("\n");
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
            return this.Equals(input as MonitoredItemModifyRequest);
        }

        /// <summary>
        /// Returns true if MonitoredItemModifyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MonitoredItemModifyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonitoredItemModifyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MonitoredItemId == input.MonitoredItemId ||
                    this.MonitoredItemId.Equals(input.MonitoredItemId)
                ) && 
                (
                    this.RequestedParameters == input.RequestedParameters ||
                    (this.RequestedParameters != null &&
                    this.RequestedParameters.Equals(input.RequestedParameters))
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
                hashCode = (hashCode * 59) + this.MonitoredItemId.GetHashCode();
                if (this.RequestedParameters != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedParameters.GetHashCode();
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
            // MonitoredItemId (long) maximum
            if (this.MonitoredItemId > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MonitoredItemId, must be a value less than or equal to 4294967295.", new [] { "MonitoredItemId" });
            }

            // MonitoredItemId (long) minimum
            if (this.MonitoredItemId < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MonitoredItemId, must be a value greater than or equal to 0.", new [] { "MonitoredItemId" });
            }

            yield break;
        }
    }

}
