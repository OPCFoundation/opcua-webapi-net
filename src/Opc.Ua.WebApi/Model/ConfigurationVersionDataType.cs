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
    /// ConfigurationVersionDataType
    /// </summary>
    [DataContract(Name = "ConfigurationVersionDataType")]
    public partial class ConfigurationVersionDataType : IEquatable<ConfigurationVersionDataType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationVersionDataType" /> class.
        /// </summary>
        /// <param name="majorVersion">majorVersion.</param>
        /// <param name="minorVersion">minorVersion.</param>
        public ConfigurationVersionDataType(long majorVersion = default(long), long minorVersion = default(long))
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }

        /// <summary>
        /// Gets or Sets MajorVersion
        /// </summary>
        [DataMember(Name = "MajorVersion", EmitDefaultValue = false)]
        public long MajorVersion { get; set; }

        /// <summary>
        /// Gets or Sets MinorVersion
        /// </summary>
        [DataMember(Name = "MinorVersion", EmitDefaultValue = false)]
        public long MinorVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationVersionDataType {\n");
            sb.Append("  MajorVersion: ").Append(MajorVersion).Append("\n");
            sb.Append("  MinorVersion: ").Append(MinorVersion).Append("\n");
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
            return this.Equals(input as ConfigurationVersionDataType);
        }

        /// <summary>
        /// Returns true if ConfigurationVersionDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationVersionDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationVersionDataType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MajorVersion == input.MajorVersion ||
                    this.MajorVersion.Equals(input.MajorVersion)
                ) && 
                (
                    this.MinorVersion == input.MinorVersion ||
                    this.MinorVersion.Equals(input.MinorVersion)
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
                hashCode = (hashCode * 59) + this.MajorVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.MinorVersion.GetHashCode();
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
            // MajorVersion (long) maximum
            if (this.MajorVersion > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MajorVersion, must be a value less than or equal to 4294967295.", new [] { "MajorVersion" });
            }

            // MajorVersion (long) minimum
            if (this.MajorVersion < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MajorVersion, must be a value greater than or equal to 0.", new [] { "MajorVersion" });
            }

            // MinorVersion (long) maximum
            if (this.MinorVersion > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinorVersion, must be a value less than or equal to 4294967295.", new [] { "MinorVersion" });
            }

            // MinorVersion (long) minimum
            if (this.MinorVersion < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinorVersion, must be a value greater than or equal to 0.", new [] { "MinorVersion" });
            }

            yield break;
        }
    }

}
