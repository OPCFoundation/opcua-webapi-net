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
    /// HistoryModifiedData
    /// </summary>
    [DataContract(Name = "HistoryModifiedData")]
    public partial class HistoryModifiedData : IEquatable<HistoryModifiedData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryModifiedData" /> class.
        /// </summary>
        /// <param name="modificationInfos">modificationInfos.</param>
        /// <param name="dataValues">dataValues.</param>
        public HistoryModifiedData(List<ModificationInfo> modificationInfos = default(List<ModificationInfo>), List<DataValue> dataValues = default(List<DataValue>))
        {
            this.ModificationInfos = modificationInfos;
            this.DataValues = dataValues;
        }

        /// <summary>
        /// Gets or Sets ModificationInfos
        /// </summary>
        [DataMember(Name = "ModificationInfos", EmitDefaultValue = false)]
        public List<ModificationInfo> ModificationInfos { get; set; }

        /// <summary>
        /// Gets or Sets DataValues
        /// </summary>
        [DataMember(Name = "DataValues", EmitDefaultValue = false)]
        public List<DataValue> DataValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoryModifiedData {\n");
            sb.Append("  ModificationInfos: ").Append(ModificationInfos).Append("\n");
            sb.Append("  DataValues: ").Append(DataValues).Append("\n");
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
            return this.Equals(input as HistoryModifiedData);
        }

        /// <summary>
        /// Returns true if HistoryModifiedData instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryModifiedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryModifiedData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModificationInfos == input.ModificationInfos ||
                    this.ModificationInfos != null &&
                    input.ModificationInfos != null &&
                    this.ModificationInfos.SequenceEqual(input.ModificationInfos)
                ) && 
                (
                    this.DataValues == input.DataValues ||
                    this.DataValues != null &&
                    input.DataValues != null &&
                    this.DataValues.SequenceEqual(input.DataValues)
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
                if (this.ModificationInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationInfos.GetHashCode();
                }
                if (this.DataValues != null)
                {
                    hashCode = (hashCode * 59) + this.DataValues.GetHashCode();
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
