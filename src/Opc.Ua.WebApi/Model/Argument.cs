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
    /// Argument
    /// </summary>
    [DataContract(Name = "Argument")]
    public partial class Argument : IEquatable<Argument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Argument" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="valueRank">valueRank.</param>
        /// <param name="arrayDimensions">arrayDimensions.</param>
        /// <param name="description">description.</param>
        public Argument(string name = default(string), string dataType = default(string), int valueRank = default(int), List<long> arrayDimensions = default(List<long>), LocalizedText description = default(LocalizedText))
        {
            this.Name = name;
            this.DataType = dataType;
            this.ValueRank = valueRank;
            this.ArrayDimensions = arrayDimensions;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "DataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets ValueRank
        /// </summary>
        [DataMember(Name = "ValueRank", EmitDefaultValue = false)]
        public int ValueRank { get; set; }

        /// <summary>
        /// Gets or Sets ArrayDimensions
        /// </summary>
        [DataMember(Name = "ArrayDimensions", EmitDefaultValue = false)]
        public List<long> ArrayDimensions { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public LocalizedText Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Argument {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ValueRank: ").Append(ValueRank).Append("\n");
            sb.Append("  ArrayDimensions: ").Append(ArrayDimensions).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as Argument);
        }

        /// <summary>
        /// Returns true if Argument instances are equal
        /// </summary>
        /// <param name="input">Instance of Argument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Argument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.ValueRank == input.ValueRank ||
                    this.ValueRank.Equals(input.ValueRank)
                ) && 
                (
                    this.ArrayDimensions == input.ArrayDimensions ||
                    this.ArrayDimensions != null &&
                    input.ArrayDimensions != null &&
                    this.ArrayDimensions.SequenceEqual(input.ArrayDimensions)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueRank.GetHashCode();
                if (this.ArrayDimensions != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayDimensions.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
