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
    /// RequestHeader
    /// </summary>
    [DataContract(Name = "RequestHeader")]
    public partial class RequestHeader : IEquatable<RequestHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestHeader" /> class.
        /// </summary>
        /// <param name="authenticationToken">authenticationToken.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="requestHandle">requestHandle.</param>
        /// <param name="returnDiagnostics">returnDiagnostics.</param>
        /// <param name="auditEntryId">auditEntryId.</param>
        /// <param name="timeoutHint">timeoutHint.</param>
        /// <param name="additionalHeader">additionalHeader.</param>
        public RequestHeader(string authenticationToken = default(string), DateTime timestamp = default(DateTime), long requestHandle = default(long), long returnDiagnostics = default(long), string auditEntryId = default(string), long timeoutHint = default(long), ExtensionObject additionalHeader = default(ExtensionObject))
        {
            this.AuthenticationToken = authenticationToken;
            this.Timestamp = timestamp;
            this.RequestHandle = requestHandle;
            this.ReturnDiagnostics = returnDiagnostics;
            this.AuditEntryId = auditEntryId;
            this.TimeoutHint = timeoutHint;
            this.AdditionalHeader = additionalHeader;
        }

        /// <summary>
        /// Gets or Sets AuthenticationToken
        /// </summary>
        [DataMember(Name = "AuthenticationToken", EmitDefaultValue = false)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets RequestHandle
        /// </summary>
        [DataMember(Name = "RequestHandle", EmitDefaultValue = false)]
        public long RequestHandle { get; set; }

        /// <summary>
        /// Gets or Sets ReturnDiagnostics
        /// </summary>
        [DataMember(Name = "ReturnDiagnostics", EmitDefaultValue = false)]
        public long ReturnDiagnostics { get; set; }

        /// <summary>
        /// Gets or Sets AuditEntryId
        /// </summary>
        [DataMember(Name = "AuditEntryId", EmitDefaultValue = false)]
        public string AuditEntryId { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutHint
        /// </summary>
        [DataMember(Name = "TimeoutHint", EmitDefaultValue = false)]
        public long TimeoutHint { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalHeader
        /// </summary>
        [DataMember(Name = "AdditionalHeader", EmitDefaultValue = false)]
        public ExtensionObject AdditionalHeader { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestHeader {\n");
            sb.Append("  AuthenticationToken: ").Append(AuthenticationToken).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  RequestHandle: ").Append(RequestHandle).Append("\n");
            sb.Append("  ReturnDiagnostics: ").Append(ReturnDiagnostics).Append("\n");
            sb.Append("  AuditEntryId: ").Append(AuditEntryId).Append("\n");
            sb.Append("  TimeoutHint: ").Append(TimeoutHint).Append("\n");
            sb.Append("  AdditionalHeader: ").Append(AdditionalHeader).Append("\n");
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
            return this.Equals(input as RequestHeader);
        }

        /// <summary>
        /// Returns true if RequestHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestHeader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationToken == input.AuthenticationToken ||
                    (this.AuthenticationToken != null &&
                    this.AuthenticationToken.Equals(input.AuthenticationToken))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.RequestHandle == input.RequestHandle ||
                    this.RequestHandle.Equals(input.RequestHandle)
                ) && 
                (
                    this.ReturnDiagnostics == input.ReturnDiagnostics ||
                    this.ReturnDiagnostics.Equals(input.ReturnDiagnostics)
                ) && 
                (
                    this.AuditEntryId == input.AuditEntryId ||
                    (this.AuditEntryId != null &&
                    this.AuditEntryId.Equals(input.AuditEntryId))
                ) && 
                (
                    this.TimeoutHint == input.TimeoutHint ||
                    this.TimeoutHint.Equals(input.TimeoutHint)
                ) && 
                (
                    this.AdditionalHeader == input.AdditionalHeader ||
                    (this.AdditionalHeader != null &&
                    this.AdditionalHeader.Equals(input.AdditionalHeader))
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
                if (this.AuthenticationToken != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationToken.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestHandle.GetHashCode();
                hashCode = (hashCode * 59) + this.ReturnDiagnostics.GetHashCode();
                if (this.AuditEntryId != null)
                {
                    hashCode = (hashCode * 59) + this.AuditEntryId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TimeoutHint.GetHashCode();
                if (this.AdditionalHeader != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalHeader.GetHashCode();
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
            // RequestHandle (long) maximum
            if (this.RequestHandle > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestHandle, must be a value less than or equal to 4294967295.", new [] { "RequestHandle" });
            }

            // RequestHandle (long) minimum
            if (this.RequestHandle < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestHandle, must be a value greater than or equal to 0.", new [] { "RequestHandle" });
            }

            // ReturnDiagnostics (long) maximum
            if (this.ReturnDiagnostics > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReturnDiagnostics, must be a value less than or equal to 4294967295.", new [] { "ReturnDiagnostics" });
            }

            // ReturnDiagnostics (long) minimum
            if (this.ReturnDiagnostics < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReturnDiagnostics, must be a value greater than or equal to 0.", new [] { "ReturnDiagnostics" });
            }

            // TimeoutHint (long) maximum
            if (this.TimeoutHint > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeoutHint, must be a value less than or equal to 4294967295.", new [] { "TimeoutHint" });
            }

            // TimeoutHint (long) minimum
            if (this.TimeoutHint < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeoutHint, must be a value greater than or equal to 0.", new [] { "TimeoutHint" });
            }

            yield break;
        }
    }

}
