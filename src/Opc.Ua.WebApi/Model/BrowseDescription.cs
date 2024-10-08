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
    /// BrowseDescription
    /// </summary>
    [DataContract(Name = "BrowseDescription")]
    public partial class BrowseDescription : IEquatable<BrowseDescription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseDescription" /> class.
        /// </summary>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="browseDirection">browseDirection.</param>
        /// <param name="referenceTypeId">referenceTypeId.</param>
        /// <param name="includeSubtypes">includeSubtypes.</param>
        /// <param name="nodeClassMask">nodeClassMask.</param>
        /// <param name="resultMask">resultMask.</param>
        public BrowseDescription(string nodeId = default(string), int browseDirection = default(int), string referenceTypeId = default(string), bool includeSubtypes = default(bool), long nodeClassMask = default(long), long resultMask = default(long))
        {
            this.NodeId = nodeId;
            this.BrowseDirection = browseDirection;
            this.ReferenceTypeId = referenceTypeId;
            this.IncludeSubtypes = includeSubtypes;
            this.NodeClassMask = nodeClassMask;
            this.ResultMask = resultMask;
        }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "NodeId", EmitDefaultValue = false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets BrowseDirection
        /// </summary>
        [DataMember(Name = "BrowseDirection", EmitDefaultValue = false)]
        public int BrowseDirection { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceTypeId
        /// </summary>
        [DataMember(Name = "ReferenceTypeId", EmitDefaultValue = false)]
        public string ReferenceTypeId { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSubtypes
        /// </summary>
        [DataMember(Name = "IncludeSubtypes", EmitDefaultValue = true)]
        public bool IncludeSubtypes { get; set; }

        /// <summary>
        /// Gets or Sets NodeClassMask
        /// </summary>
        [DataMember(Name = "NodeClassMask", EmitDefaultValue = false)]
        public long NodeClassMask { get; set; }

        /// <summary>
        /// Gets or Sets ResultMask
        /// </summary>
        [DataMember(Name = "ResultMask", EmitDefaultValue = false)]
        public long ResultMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrowseDescription {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  BrowseDirection: ").Append(BrowseDirection).Append("\n");
            sb.Append("  ReferenceTypeId: ").Append(ReferenceTypeId).Append("\n");
            sb.Append("  IncludeSubtypes: ").Append(IncludeSubtypes).Append("\n");
            sb.Append("  NodeClassMask: ").Append(NodeClassMask).Append("\n");
            sb.Append("  ResultMask: ").Append(ResultMask).Append("\n");
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
            return this.Equals(input as BrowseDescription);
        }

        /// <summary>
        /// Returns true if BrowseDescription instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowseDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowseDescription input)
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
                    this.BrowseDirection == input.BrowseDirection ||
                    this.BrowseDirection.Equals(input.BrowseDirection)
                ) && 
                (
                    this.ReferenceTypeId == input.ReferenceTypeId ||
                    (this.ReferenceTypeId != null &&
                    this.ReferenceTypeId.Equals(input.ReferenceTypeId))
                ) && 
                (
                    this.IncludeSubtypes == input.IncludeSubtypes ||
                    this.IncludeSubtypes.Equals(input.IncludeSubtypes)
                ) && 
                (
                    this.NodeClassMask == input.NodeClassMask ||
                    this.NodeClassMask.Equals(input.NodeClassMask)
                ) && 
                (
                    this.ResultMask == input.ResultMask ||
                    this.ResultMask.Equals(input.ResultMask)
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
                hashCode = (hashCode * 59) + this.BrowseDirection.GetHashCode();
                if (this.ReferenceTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceTypeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludeSubtypes.GetHashCode();
                hashCode = (hashCode * 59) + this.NodeClassMask.GetHashCode();
                hashCode = (hashCode * 59) + this.ResultMask.GetHashCode();
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
            // NodeClassMask (long) maximum
            if (this.NodeClassMask > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NodeClassMask, must be a value less than or equal to 4294967295.", new [] { "NodeClassMask" });
            }

            // NodeClassMask (long) minimum
            if (this.NodeClassMask < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NodeClassMask, must be a value greater than or equal to 0.", new [] { "NodeClassMask" });
            }

            // ResultMask (long) maximum
            if (this.ResultMask > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultMask, must be a value less than or equal to 4294967295.", new [] { "ResultMask" });
            }

            // ResultMask (long) minimum
            if (this.ResultMask < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultMask, must be a value greater than or equal to 0.", new [] { "ResultMask" });
            }

            yield break;
        }
    }

}
