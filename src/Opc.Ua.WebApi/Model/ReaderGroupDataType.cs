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
    /// ReaderGroupDataType
    /// </summary>
    [DataContract(Name = "ReaderGroupDataType")]
    public partial class ReaderGroupDataType : IEquatable<ReaderGroupDataType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderGroupDataType" /> class.
        /// </summary>
        /// <param name="transportSettings">transportSettings.</param>
        /// <param name="messageSettings">messageSettings.</param>
        /// <param name="dataSetReaders">dataSetReaders.</param>
        /// <param name="name">name.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="securityMode">securityMode.</param>
        /// <param name="securityGroupId">securityGroupId.</param>
        /// <param name="securityKeyServices">securityKeyServices.</param>
        /// <param name="maxNetworkMessageSize">maxNetworkMessageSize.</param>
        /// <param name="groupProperties">groupProperties.</param>
        public ReaderGroupDataType(ExtensionObject transportSettings = default(ExtensionObject), ExtensionObject messageSettings = default(ExtensionObject), List<DataSetReaderDataType> dataSetReaders = default(List<DataSetReaderDataType>), string name = default(string), bool enabled = default(bool), int securityMode = default(int), string securityGroupId = default(string), List<EndpointDescription> securityKeyServices = default(List<EndpointDescription>), long maxNetworkMessageSize = default(long), List<KeyValuePair> groupProperties = default(List<KeyValuePair>))
        {
            this.TransportSettings = transportSettings;
            this.MessageSettings = messageSettings;
            this.DataSetReaders = dataSetReaders;
            this.Name = name;
            this.Enabled = enabled;
            this.SecurityMode = securityMode;
            this.SecurityGroupId = securityGroupId;
            this.SecurityKeyServices = securityKeyServices;
            this.MaxNetworkMessageSize = maxNetworkMessageSize;
            this.GroupProperties = groupProperties;
        }

        /// <summary>
        /// Gets or Sets TransportSettings
        /// </summary>
        [DataMember(Name = "TransportSettings", EmitDefaultValue = false)]
        public ExtensionObject TransportSettings { get; set; }

        /// <summary>
        /// Gets or Sets MessageSettings
        /// </summary>
        [DataMember(Name = "MessageSettings", EmitDefaultValue = false)]
        public ExtensionObject MessageSettings { get; set; }

        /// <summary>
        /// Gets or Sets DataSetReaders
        /// </summary>
        [DataMember(Name = "DataSetReaders", EmitDefaultValue = false)]
        public List<DataSetReaderDataType> DataSetReaders { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "Enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets SecurityMode
        /// </summary>
        [DataMember(Name = "SecurityMode", EmitDefaultValue = false)]
        public int SecurityMode { get; set; }

        /// <summary>
        /// Gets or Sets SecurityGroupId
        /// </summary>
        [DataMember(Name = "SecurityGroupId", EmitDefaultValue = false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// Gets or Sets SecurityKeyServices
        /// </summary>
        [DataMember(Name = "SecurityKeyServices", EmitDefaultValue = false)]
        public List<EndpointDescription> SecurityKeyServices { get; set; }

        /// <summary>
        /// Gets or Sets MaxNetworkMessageSize
        /// </summary>
        [DataMember(Name = "MaxNetworkMessageSize", EmitDefaultValue = false)]
        public long MaxNetworkMessageSize { get; set; }

        /// <summary>
        /// Gets or Sets GroupProperties
        /// </summary>
        [DataMember(Name = "GroupProperties", EmitDefaultValue = false)]
        public List<KeyValuePair> GroupProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReaderGroupDataType {\n");
            sb.Append("  TransportSettings: ").Append(TransportSettings).Append("\n");
            sb.Append("  MessageSettings: ").Append(MessageSettings).Append("\n");
            sb.Append("  DataSetReaders: ").Append(DataSetReaders).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SecurityMode: ").Append(SecurityMode).Append("\n");
            sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  SecurityKeyServices: ").Append(SecurityKeyServices).Append("\n");
            sb.Append("  MaxNetworkMessageSize: ").Append(MaxNetworkMessageSize).Append("\n");
            sb.Append("  GroupProperties: ").Append(GroupProperties).Append("\n");
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
            return this.Equals(input as ReaderGroupDataType);
        }

        /// <summary>
        /// Returns true if ReaderGroupDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of ReaderGroupDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReaderGroupDataType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransportSettings == input.TransportSettings ||
                    (this.TransportSettings != null &&
                    this.TransportSettings.Equals(input.TransportSettings))
                ) && 
                (
                    this.MessageSettings == input.MessageSettings ||
                    (this.MessageSettings != null &&
                    this.MessageSettings.Equals(input.MessageSettings))
                ) && 
                (
                    this.DataSetReaders == input.DataSetReaders ||
                    this.DataSetReaders != null &&
                    input.DataSetReaders != null &&
                    this.DataSetReaders.SequenceEqual(input.DataSetReaders)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.SecurityMode == input.SecurityMode ||
                    this.SecurityMode.Equals(input.SecurityMode)
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.SecurityKeyServices == input.SecurityKeyServices ||
                    this.SecurityKeyServices != null &&
                    input.SecurityKeyServices != null &&
                    this.SecurityKeyServices.SequenceEqual(input.SecurityKeyServices)
                ) && 
                (
                    this.MaxNetworkMessageSize == input.MaxNetworkMessageSize ||
                    this.MaxNetworkMessageSize.Equals(input.MaxNetworkMessageSize)
                ) && 
                (
                    this.GroupProperties == input.GroupProperties ||
                    this.GroupProperties != null &&
                    input.GroupProperties != null &&
                    this.GroupProperties.SequenceEqual(input.GroupProperties)
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
                if (this.TransportSettings != null)
                {
                    hashCode = (hashCode * 59) + this.TransportSettings.GetHashCode();
                }
                if (this.MessageSettings != null)
                {
                    hashCode = (hashCode * 59) + this.MessageSettings.GetHashCode();
                }
                if (this.DataSetReaders != null)
                {
                    hashCode = (hashCode * 59) + this.DataSetReaders.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.SecurityMode.GetHashCode();
                if (this.SecurityGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityGroupId.GetHashCode();
                }
                if (this.SecurityKeyServices != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityKeyServices.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxNetworkMessageSize.GetHashCode();
                if (this.GroupProperties != null)
                {
                    hashCode = (hashCode * 59) + this.GroupProperties.GetHashCode();
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
            // MaxNetworkMessageSize (long) maximum
            if (this.MaxNetworkMessageSize > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxNetworkMessageSize, must be a value less than or equal to 4294967295.", new [] { "MaxNetworkMessageSize" });
            }

            // MaxNetworkMessageSize (long) minimum
            if (this.MaxNetworkMessageSize < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxNetworkMessageSize, must be a value greater than or equal to 0.", new [] { "MaxNetworkMessageSize" });
            }

            yield break;
        }
    }

}
