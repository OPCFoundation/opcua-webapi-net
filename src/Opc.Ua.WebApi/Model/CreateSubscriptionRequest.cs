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
    /// CreateSubscriptionRequest
    /// </summary>
    [DataContract(Name = "CreateSubscriptionRequest")]
    public partial class CreateSubscriptionRequest : IEquatable<CreateSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="requestedPublishingInterval">requestedPublishingInterval.</param>
        /// <param name="requestedLifetimeCount">requestedLifetimeCount.</param>
        /// <param name="requestedMaxKeepAliveCount">requestedMaxKeepAliveCount.</param>
        /// <param name="maxNotificationsPerPublish">maxNotificationsPerPublish.</param>
        /// <param name="publishingEnabled">publishingEnabled.</param>
        /// <param name="priority">priority.</param>
        public CreateSubscriptionRequest(RequestHeader requestHeader = default(RequestHeader), double requestedPublishingInterval = default(double), long requestedLifetimeCount = default(long), long requestedMaxKeepAliveCount = default(long), long maxNotificationsPerPublish = default(long), bool publishingEnabled = default(bool), int priority = default(int))
        {
            this.RequestHeader = requestHeader;
            this.RequestedPublishingInterval = requestedPublishingInterval;
            this.RequestedLifetimeCount = requestedLifetimeCount;
            this.RequestedMaxKeepAliveCount = requestedMaxKeepAliveCount;
            this.MaxNotificationsPerPublish = maxNotificationsPerPublish;
            this.PublishingEnabled = publishingEnabled;
            this.Priority = priority;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets RequestedPublishingInterval
        /// </summary>
        [DataMember(Name = "RequestedPublishingInterval", EmitDefaultValue = false)]
        public double RequestedPublishingInterval { get; set; }

        /// <summary>
        /// Gets or Sets RequestedLifetimeCount
        /// </summary>
        [DataMember(Name = "RequestedLifetimeCount", EmitDefaultValue = false)]
        public long RequestedLifetimeCount { get; set; }

        /// <summary>
        /// Gets or Sets RequestedMaxKeepAliveCount
        /// </summary>
        [DataMember(Name = "RequestedMaxKeepAliveCount", EmitDefaultValue = false)]
        public long RequestedMaxKeepAliveCount { get; set; }

        /// <summary>
        /// Gets or Sets MaxNotificationsPerPublish
        /// </summary>
        [DataMember(Name = "MaxNotificationsPerPublish", EmitDefaultValue = false)]
        public long MaxNotificationsPerPublish { get; set; }

        /// <summary>
        /// Gets or Sets PublishingEnabled
        /// </summary>
        [DataMember(Name = "PublishingEnabled", EmitDefaultValue = true)]
        public bool PublishingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "Priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  RequestedPublishingInterval: ").Append(RequestedPublishingInterval).Append("\n");
            sb.Append("  RequestedLifetimeCount: ").Append(RequestedLifetimeCount).Append("\n");
            sb.Append("  RequestedMaxKeepAliveCount: ").Append(RequestedMaxKeepAliveCount).Append("\n");
            sb.Append("  MaxNotificationsPerPublish: ").Append(MaxNotificationsPerPublish).Append("\n");
            sb.Append("  PublishingEnabled: ").Append(PublishingEnabled).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequest input)
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
                    this.RequestedPublishingInterval == input.RequestedPublishingInterval ||
                    this.RequestedPublishingInterval.Equals(input.RequestedPublishingInterval)
                ) && 
                (
                    this.RequestedLifetimeCount == input.RequestedLifetimeCount ||
                    this.RequestedLifetimeCount.Equals(input.RequestedLifetimeCount)
                ) && 
                (
                    this.RequestedMaxKeepAliveCount == input.RequestedMaxKeepAliveCount ||
                    this.RequestedMaxKeepAliveCount.Equals(input.RequestedMaxKeepAliveCount)
                ) && 
                (
                    this.MaxNotificationsPerPublish == input.MaxNotificationsPerPublish ||
                    this.MaxNotificationsPerPublish.Equals(input.MaxNotificationsPerPublish)
                ) && 
                (
                    this.PublishingEnabled == input.PublishingEnabled ||
                    this.PublishingEnabled.Equals(input.PublishingEnabled)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
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
                hashCode = (hashCode * 59) + this.RequestedPublishingInterval.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestedLifetimeCount.GetHashCode();
                hashCode = (hashCode * 59) + this.RequestedMaxKeepAliveCount.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxNotificationsPerPublish.GetHashCode();
                hashCode = (hashCode * 59) + this.PublishingEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
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
            // RequestedLifetimeCount (long) maximum
            if (this.RequestedLifetimeCount > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestedLifetimeCount, must be a value less than or equal to 4294967295.", new [] { "RequestedLifetimeCount" });
            }

            // RequestedLifetimeCount (long) minimum
            if (this.RequestedLifetimeCount < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestedLifetimeCount, must be a value greater than or equal to 0.", new [] { "RequestedLifetimeCount" });
            }

            // RequestedMaxKeepAliveCount (long) maximum
            if (this.RequestedMaxKeepAliveCount > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestedMaxKeepAliveCount, must be a value less than or equal to 4294967295.", new [] { "RequestedMaxKeepAliveCount" });
            }

            // RequestedMaxKeepAliveCount (long) minimum
            if (this.RequestedMaxKeepAliveCount < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestedMaxKeepAliveCount, must be a value greater than or equal to 0.", new [] { "RequestedMaxKeepAliveCount" });
            }

            // MaxNotificationsPerPublish (long) maximum
            if (this.MaxNotificationsPerPublish > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxNotificationsPerPublish, must be a value less than or equal to 4294967295.", new [] { "MaxNotificationsPerPublish" });
            }

            // MaxNotificationsPerPublish (long) minimum
            if (this.MaxNotificationsPerPublish < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxNotificationsPerPublish, must be a value greater than or equal to 0.", new [] { "MaxNotificationsPerPublish" });
            }

            // Priority (int) maximum
            if (this.Priority > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value less than or equal to 255.", new [] { "Priority" });
            }

            // Priority (int) minimum
            if (this.Priority < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value greater than or equal to 0.", new [] { "Priority" });
            }

            yield break;
        }
    }

}
