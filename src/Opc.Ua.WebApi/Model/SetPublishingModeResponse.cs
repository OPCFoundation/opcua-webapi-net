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
    /// SetPublishingModeResponse
    /// </summary>
    [DataContract(Name = "SetPublishingModeResponse")]
    public partial class SetPublishingModeResponse : IEquatable<SetPublishingModeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPublishingModeResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="results">results.</param>
        /// <param name="diagnosticInfos">diagnosticInfos.</param>
        public SetPublishingModeResponse(ResponseHeader responseHeader = default(ResponseHeader), List<long> results = default(List<long>), List<DiagnosticInfo> diagnosticInfos = default(List<DiagnosticInfo>))
        {
            this.ResponseHeader = responseHeader;
            this.Results = results;
            this.DiagnosticInfos = diagnosticInfos;
        }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [DataMember(Name = "ResponseHeader", EmitDefaultValue = false)]
        public ResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "Results", EmitDefaultValue = false)]
        public List<long> Results { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticInfos
        /// </summary>
        [DataMember(Name = "DiagnosticInfos", EmitDefaultValue = false)]
        public List<DiagnosticInfo> DiagnosticInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetPublishingModeResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  DiagnosticInfos: ").Append(DiagnosticInfos).Append("\n");
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
            return this.Equals(input as SetPublishingModeResponse);
        }

        /// <summary>
        /// Returns true if SetPublishingModeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPublishingModeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPublishingModeResponse input)
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
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.DiagnosticInfos == input.DiagnosticInfos ||
                    this.DiagnosticInfos != null &&
                    input.DiagnosticInfos != null &&
                    this.DiagnosticInfos.SequenceEqual(input.DiagnosticInfos)
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
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                if (this.DiagnosticInfos != null)
                {
                    hashCode = (hashCode * 59) + this.DiagnosticInfos.GetHashCode();
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
