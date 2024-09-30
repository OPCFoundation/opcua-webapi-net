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
    /// HistoryReadValueId
    /// </summary>
    [DataContract(Name = "HistoryReadValueId")]
    public partial class HistoryReadValueId : IEquatable<HistoryReadValueId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryReadValueId" /> class.
        /// </summary>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="indexRange">indexRange.</param>
        /// <param name="dataEncoding">dataEncoding.</param>
        /// <param name="continuationPoint">continuationPoint.</param>
        public HistoryReadValueId(string nodeId = default(string), string indexRange = default(string), string dataEncoding = default(string), byte[] continuationPoint = default(byte[]))
        {
            this.NodeId = nodeId;
            this.IndexRange = indexRange;
            this.DataEncoding = dataEncoding;
            this.ContinuationPoint = continuationPoint;
        }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "NodeId", EmitDefaultValue = false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets IndexRange
        /// </summary>
        [DataMember(Name = "IndexRange", EmitDefaultValue = false)]
        public string IndexRange { get; set; }

        /// <summary>
        /// Gets or Sets DataEncoding
        /// </summary>
        [DataMember(Name = "DataEncoding", EmitDefaultValue = false)]
        public string DataEncoding { get; set; }

        /// <summary>
        /// Gets or Sets ContinuationPoint
        /// </summary>
        [DataMember(Name = "ContinuationPoint", EmitDefaultValue = false)]
        public byte[] ContinuationPoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoryReadValueId {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  IndexRange: ").Append(IndexRange).Append("\n");
            sb.Append("  DataEncoding: ").Append(DataEncoding).Append("\n");
            sb.Append("  ContinuationPoint: ").Append(ContinuationPoint).Append("\n");
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
            return this.Equals(input as HistoryReadValueId);
        }

        /// <summary>
        /// Returns true if HistoryReadValueId instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryReadValueId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryReadValueId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.IndexRange == input.IndexRange ||
                    (this.IndexRange != null &&
                    this.IndexRange.Equals(input.IndexRange))
                ) && 
                (
                    this.DataEncoding == input.DataEncoding ||
                    (this.DataEncoding != null &&
                    this.DataEncoding.Equals(input.DataEncoding))
                ) && 
                (
                    this.ContinuationPoint == input.ContinuationPoint ||
                    (this.ContinuationPoint != null &&
                    this.ContinuationPoint.Equals(input.ContinuationPoint))
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
                if (this.NodeId != null)
                {
                    hashCode = (hashCode * 59) + this.NodeId.GetHashCode();
                }
                if (this.IndexRange != null)
                {
                    hashCode = (hashCode * 59) + this.IndexRange.GetHashCode();
                }
                if (this.DataEncoding != null)
                {
                    hashCode = (hashCode * 59) + this.DataEncoding.GetHashCode();
                }
                if (this.ContinuationPoint != null)
                {
                    hashCode = (hashCode * 59) + this.ContinuationPoint.GetHashCode();
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
