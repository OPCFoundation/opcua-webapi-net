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
    /// CreateSessionRequest
    /// </summary>
    [DataContract(Name = "CreateSessionRequest")]
    public partial class CreateSessionRequest : IEquatable<CreateSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="clientDescription">clientDescription.</param>
        /// <param name="serverUri">serverUri.</param>
        /// <param name="endpointUrl">endpointUrl.</param>
        /// <param name="sessionName">sessionName.</param>
        /// <param name="clientNonce">clientNonce.</param>
        /// <param name="clientCertificate">clientCertificate.</param>
        /// <param name="requestedSessionTimeout">requestedSessionTimeout.</param>
        /// <param name="maxResponseMessageSize">maxResponseMessageSize.</param>
        public CreateSessionRequest(RequestHeader requestHeader = default(RequestHeader), ApplicationDescription clientDescription = default(ApplicationDescription), string serverUri = default(string), string endpointUrl = default(string), string sessionName = default(string), byte[] clientNonce = default(byte[]), byte[] clientCertificate = default(byte[]), double requestedSessionTimeout = default(double), long maxResponseMessageSize = default(long))
        {
            this.RequestHeader = requestHeader;
            this.ClientDescription = clientDescription;
            this.ServerUri = serverUri;
            this.EndpointUrl = endpointUrl;
            this.SessionName = sessionName;
            this.ClientNonce = clientNonce;
            this.ClientCertificate = clientCertificate;
            this.RequestedSessionTimeout = requestedSessionTimeout;
            this.MaxResponseMessageSize = maxResponseMessageSize;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets ClientDescription
        /// </summary>
        [DataMember(Name = "ClientDescription", EmitDefaultValue = false)]
        public ApplicationDescription ClientDescription { get; set; }

        /// <summary>
        /// Gets or Sets ServerUri
        /// </summary>
        [DataMember(Name = "ServerUri", EmitDefaultValue = false)]
        public string ServerUri { get; set; }

        /// <summary>
        /// Gets or Sets EndpointUrl
        /// </summary>
        [DataMember(Name = "EndpointUrl", EmitDefaultValue = false)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets or Sets SessionName
        /// </summary>
        [DataMember(Name = "SessionName", EmitDefaultValue = false)]
        public string SessionName { get; set; }

        /// <summary>
        /// Gets or Sets ClientNonce
        /// </summary>
        [DataMember(Name = "ClientNonce", EmitDefaultValue = false)]
        public byte[] ClientNonce { get; set; }

        /// <summary>
        /// Gets or Sets ClientCertificate
        /// </summary>
        [DataMember(Name = "ClientCertificate", EmitDefaultValue = false)]
        public byte[] ClientCertificate { get; set; }

        /// <summary>
        /// Gets or Sets RequestedSessionTimeout
        /// </summary>
        [DataMember(Name = "RequestedSessionTimeout", EmitDefaultValue = false)]
        public double RequestedSessionTimeout { get; set; }

        /// <summary>
        /// Gets or Sets MaxResponseMessageSize
        /// </summary>
        [DataMember(Name = "MaxResponseMessageSize", EmitDefaultValue = false)]
        public long MaxResponseMessageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSessionRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  ClientDescription: ").Append(ClientDescription).Append("\n");
            sb.Append("  ServerUri: ").Append(ServerUri).Append("\n");
            sb.Append("  EndpointUrl: ").Append(EndpointUrl).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  ClientNonce: ").Append(ClientNonce).Append("\n");
            sb.Append("  ClientCertificate: ").Append(ClientCertificate).Append("\n");
            sb.Append("  RequestedSessionTimeout: ").Append(RequestedSessionTimeout).Append("\n");
            sb.Append("  MaxResponseMessageSize: ").Append(MaxResponseMessageSize).Append("\n");
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
            return this.Equals(input as CreateSessionRequest);
        }

        /// <summary>
        /// Returns true if CreateSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSessionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestHeader == input.RequestHeader ||
                    (this.RequestHeader != null &&
                    this.RequestHeader.Equals(input.RequestHeader))
                ) && 
                (
                    this.ClientDescription == input.ClientDescription ||
                    (this.ClientDescription != null &&
                    this.ClientDescription.Equals(input.ClientDescription))
                ) && 
                (
                    this.ServerUri == input.ServerUri ||
                    (this.ServerUri != null &&
                    this.ServerUri.Equals(input.ServerUri))
                ) && 
                (
                    this.EndpointUrl == input.EndpointUrl ||
                    (this.EndpointUrl != null &&
                    this.EndpointUrl.Equals(input.EndpointUrl))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.ClientNonce == input.ClientNonce ||
                    (this.ClientNonce != null &&
                    this.ClientNonce.Equals(input.ClientNonce))
                ) && 
                (
                    this.ClientCertificate == input.ClientCertificate ||
                    (this.ClientCertificate != null &&
                    this.ClientCertificate.Equals(input.ClientCertificate))
                ) && 
                (
                    this.RequestedSessionTimeout == input.RequestedSessionTimeout ||
                    this.RequestedSessionTimeout.Equals(input.RequestedSessionTimeout)
                ) && 
                (
                    this.MaxResponseMessageSize == input.MaxResponseMessageSize ||
                    this.MaxResponseMessageSize.Equals(input.MaxResponseMessageSize)
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
                if (this.RequestHeader != null)
                {
                    hashCode = (hashCode * 59) + this.RequestHeader.GetHashCode();
                }
                if (this.ClientDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ClientDescription.GetHashCode();
                }
                if (this.ServerUri != null)
                {
                    hashCode = (hashCode * 59) + this.ServerUri.GetHashCode();
                }
                if (this.EndpointUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EndpointUrl.GetHashCode();
                }
                if (this.SessionName != null)
                {
                    hashCode = (hashCode * 59) + this.SessionName.GetHashCode();
                }
                if (this.ClientNonce != null)
                {
                    hashCode = (hashCode * 59) + this.ClientNonce.GetHashCode();
                }
                if (this.ClientCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.ClientCertificate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestedSessionTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxResponseMessageSize.GetHashCode();
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
            // MaxResponseMessageSize (long) maximum
            if (this.MaxResponseMessageSize > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxResponseMessageSize, must be a value less than or equal to 4294967295.", new [] { "MaxResponseMessageSize" });
            }

            // MaxResponseMessageSize (long) minimum
            if (this.MaxResponseMessageSize < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxResponseMessageSize, must be a value greater than or equal to 0.", new [] { "MaxResponseMessageSize" });
            }

            yield break;
        }
    }

}
