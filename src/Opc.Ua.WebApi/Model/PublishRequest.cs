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
    /// PublishRequest
    /// </summary>
    [DataContract(Name = "PublishRequest")]
    public partial class PublishRequest : IEquatable<PublishRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="subscriptionAcknowledgements">subscriptionAcknowledgements.</param>
        public PublishRequest(RequestHeader requestHeader = default(RequestHeader), List<SubscriptionAcknowledgement> subscriptionAcknowledgements = default(List<SubscriptionAcknowledgement>))
        {
            this.RequestHeader = requestHeader;
            this.SubscriptionAcknowledgements = subscriptionAcknowledgements;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionAcknowledgements
        /// </summary>
        [DataMember(Name = "SubscriptionAcknowledgements", EmitDefaultValue = false)]
        public List<SubscriptionAcknowledgement> SubscriptionAcknowledgements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublishRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  SubscriptionAcknowledgements: ").Append(SubscriptionAcknowledgements).Append("\n");
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
            return this.Equals(input as PublishRequest);
        }

        /// <summary>
        /// Returns true if PublishRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PublishRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishRequest input)
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
                    this.SubscriptionAcknowledgements == input.SubscriptionAcknowledgements ||
                    this.SubscriptionAcknowledgements != null &&
                    input.SubscriptionAcknowledgements != null &&
                    this.SubscriptionAcknowledgements.SequenceEqual(input.SubscriptionAcknowledgements)
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
                if (this.SubscriptionAcknowledgements != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionAcknowledgements.GetHashCode();
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
