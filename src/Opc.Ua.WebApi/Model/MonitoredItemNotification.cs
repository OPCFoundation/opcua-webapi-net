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
    /// MonitoredItemNotification
    /// </summary>
    [DataContract(Name = "MonitoredItemNotification")]
    public partial class MonitoredItemNotification : IEquatable<MonitoredItemNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoredItemNotification" /> class.
        /// </summary>
        /// <param name="clientHandle">clientHandle.</param>
        /// <param name="value">value.</param>
        public MonitoredItemNotification(long clientHandle = default(long), DataValue value = default(DataValue))
        {
            this.ClientHandle = clientHandle;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets ClientHandle
        /// </summary>
        [DataMember(Name = "ClientHandle", EmitDefaultValue = false)]
        public long ClientHandle { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public DataValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonitoredItemNotification {\n");
            sb.Append("  ClientHandle: ").Append(ClientHandle).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as MonitoredItemNotification);
        }

        /// <summary>
        /// Returns true if MonitoredItemNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of MonitoredItemNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonitoredItemNotification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientHandle == input.ClientHandle ||
                    this.ClientHandle.Equals(input.ClientHandle)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.ClientHandle.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
            // ClientHandle (long) maximum
            if (this.ClientHandle > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientHandle, must be a value less than or equal to 4294967295.", new [] { "ClientHandle" });
            }

            // ClientHandle (long) minimum
            if (this.ClientHandle < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientHandle, must be a value greater than or equal to 0.", new [] { "ClientHandle" });
            }

            yield break;
        }
    }

}
