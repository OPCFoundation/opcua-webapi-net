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
    /// Decimal
    /// </summary>
    [DataContract(Name = "Decimal")]
    public partial class Decimal : IEquatable<Decimal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Decimal" /> class.
        /// </summary>
        /// <param name="scale">scale.</param>
        /// <param name="value">value.</param>
        public Decimal(int scale = default(int), string value = default(string))
        {
            this.Scale = scale;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name = "Scale", EmitDefaultValue = false)]
        public int Scale { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Decimal {\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
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
            return this.Equals(input as Decimal);
        }

        /// <summary>
        /// Returns true if Decimal instances are equal
        /// </summary>
        /// <param name="input">Instance of Decimal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Decimal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scale == input.Scale ||
                    this.Scale.Equals(input.Scale)
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
                hashCode = (hashCode * 59) + this.Scale.GetHashCode();
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
            // Scale (int) maximum
            if (this.Scale > (int)32767)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scale, must be a value less than or equal to 32767.", new [] { "Scale" });
            }

            // Scale (int) minimum
            if (this.Scale < (int)-32768)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scale, must be a value greater than or equal to -32768.", new [] { "Scale" });
            }

            yield break;
        }
    }

}
