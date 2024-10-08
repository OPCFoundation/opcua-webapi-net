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
    /// ReadAtTimeDetails
    /// </summary>
    [DataContract(Name = "ReadAtTimeDetails")]
    public partial class ReadAtTimeDetails : IEquatable<ReadAtTimeDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadAtTimeDetails" /> class.
        /// </summary>
        /// <param name="reqTimes">reqTimes.</param>
        /// <param name="useSimpleBounds">useSimpleBounds.</param>
        public ReadAtTimeDetails(List<DateTime> reqTimes = default(List<DateTime>), bool useSimpleBounds = default(bool))
        {
            this.ReqTimes = reqTimes;
            this.UseSimpleBounds = useSimpleBounds;
        }

        /// <summary>
        /// Gets or Sets ReqTimes
        /// </summary>
        [DataMember(Name = "ReqTimes", EmitDefaultValue = false)]
        public List<DateTime> ReqTimes { get; set; }

        /// <summary>
        /// Gets or Sets UseSimpleBounds
        /// </summary>
        [DataMember(Name = "UseSimpleBounds", EmitDefaultValue = true)]
        public bool UseSimpleBounds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadAtTimeDetails {\n");
            sb.Append("  ReqTimes: ").Append(ReqTimes).Append("\n");
            sb.Append("  UseSimpleBounds: ").Append(UseSimpleBounds).Append("\n");
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
            return this.Equals(input as ReadAtTimeDetails);
        }

        /// <summary>
        /// Returns true if ReadAtTimeDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadAtTimeDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadAtTimeDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReqTimes == input.ReqTimes ||
                    this.ReqTimes != null &&
                    input.ReqTimes != null &&
                    this.ReqTimes.SequenceEqual(input.ReqTimes)
                ) && 
                (
                    this.UseSimpleBounds == input.UseSimpleBounds ||
                    this.UseSimpleBounds.Equals(input.UseSimpleBounds)
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
                if (this.ReqTimes != null)
                {
                    hashCode = (hashCode * 59) + this.ReqTimes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseSimpleBounds.GetHashCode();
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
