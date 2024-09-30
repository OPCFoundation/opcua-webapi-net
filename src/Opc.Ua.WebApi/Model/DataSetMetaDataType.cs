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
    /// DataSetMetaDataType
    /// </summary>
    [DataContract(Name = "DataSetMetaDataType")]
    public partial class DataSetMetaDataType : IEquatable<DataSetMetaDataType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetMetaDataType" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="fields">fields.</param>
        /// <param name="dataSetClassId">dataSetClassId.</param>
        /// <param name="configurationVersion">configurationVersion.</param>
        /// <param name="namespaces">namespaces.</param>
        /// <param name="structureDataTypes">structureDataTypes.</param>
        /// <param name="enumDataTypes">enumDataTypes.</param>
        /// <param name="simpleDataTypes">simpleDataTypes.</param>
        public DataSetMetaDataType(string name = default(string), LocalizedText description = default(LocalizedText), List<FieldMetaData> fields = default(List<FieldMetaData>), Guid dataSetClassId = default(Guid), ConfigurationVersionDataType configurationVersion = default(ConfigurationVersionDataType), List<string> namespaces = default(List<string>), List<StructureDescription> structureDataTypes = default(List<StructureDescription>), List<EnumDescription> enumDataTypes = default(List<EnumDescription>), List<SimpleTypeDescription> simpleDataTypes = default(List<SimpleTypeDescription>))
        {
            this.Name = name;
            this.Description = description;
            this.Fields = fields;
            this.DataSetClassId = dataSetClassId;
            this.ConfigurationVersion = configurationVersion;
            this.Namespaces = namespaces;
            this.StructureDataTypes = structureDataTypes;
            this.EnumDataTypes = enumDataTypes;
            this.SimpleDataTypes = simpleDataTypes;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public LocalizedText Description { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "Fields", EmitDefaultValue = false)]
        public List<FieldMetaData> Fields { get; set; }

        /// <summary>
        /// Gets or Sets DataSetClassId
        /// </summary>
        [DataMember(Name = "DataSetClassId", EmitDefaultValue = false)]
        public Guid DataSetClassId { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationVersion
        /// </summary>
        [DataMember(Name = "ConfigurationVersion", EmitDefaultValue = false)]
        public ConfigurationVersionDataType ConfigurationVersion { get; set; }

        /// <summary>
        /// Gets or Sets Namespaces
        /// </summary>
        [DataMember(Name = "Namespaces", EmitDefaultValue = false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// Gets or Sets StructureDataTypes
        /// </summary>
        [DataMember(Name = "StructureDataTypes", EmitDefaultValue = false)]
        public List<StructureDescription> StructureDataTypes { get; set; }

        /// <summary>
        /// Gets or Sets EnumDataTypes
        /// </summary>
        [DataMember(Name = "EnumDataTypes", EmitDefaultValue = false)]
        public List<EnumDescription> EnumDataTypes { get; set; }

        /// <summary>
        /// Gets or Sets SimpleDataTypes
        /// </summary>
        [DataMember(Name = "SimpleDataTypes", EmitDefaultValue = false)]
        public List<SimpleTypeDescription> SimpleDataTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSetMetaDataType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  DataSetClassId: ").Append(DataSetClassId).Append("\n");
            sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
            sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("  StructureDataTypes: ").Append(StructureDataTypes).Append("\n");
            sb.Append("  EnumDataTypes: ").Append(EnumDataTypes).Append("\n");
            sb.Append("  SimpleDataTypes: ").Append(SimpleDataTypes).Append("\n");
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
            return this.Equals(input as DataSetMetaDataType);
        }

        /// <summary>
        /// Returns true if DataSetMetaDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSetMetaDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSetMetaDataType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.DataSetClassId == input.DataSetClassId ||
                    (this.DataSetClassId != null &&
                    this.DataSetClassId.Equals(input.DataSetClassId))
                ) && 
                (
                    this.ConfigurationVersion == input.ConfigurationVersion ||
                    (this.ConfigurationVersion != null &&
                    this.ConfigurationVersion.Equals(input.ConfigurationVersion))
                ) && 
                (
                    this.Namespaces == input.Namespaces ||
                    this.Namespaces != null &&
                    input.Namespaces != null &&
                    this.Namespaces.SequenceEqual(input.Namespaces)
                ) && 
                (
                    this.StructureDataTypes == input.StructureDataTypes ||
                    this.StructureDataTypes != null &&
                    input.StructureDataTypes != null &&
                    this.StructureDataTypes.SequenceEqual(input.StructureDataTypes)
                ) && 
                (
                    this.EnumDataTypes == input.EnumDataTypes ||
                    this.EnumDataTypes != null &&
                    input.EnumDataTypes != null &&
                    this.EnumDataTypes.SequenceEqual(input.EnumDataTypes)
                ) && 
                (
                    this.SimpleDataTypes == input.SimpleDataTypes ||
                    this.SimpleDataTypes != null &&
                    input.SimpleDataTypes != null &&
                    this.SimpleDataTypes.SequenceEqual(input.SimpleDataTypes)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.DataSetClassId != null)
                {
                    hashCode = (hashCode * 59) + this.DataSetClassId.GetHashCode();
                }
                if (this.ConfigurationVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationVersion.GetHashCode();
                }
                if (this.Namespaces != null)
                {
                    hashCode = (hashCode * 59) + this.Namespaces.GetHashCode();
                }
                if (this.StructureDataTypes != null)
                {
                    hashCode = (hashCode * 59) + this.StructureDataTypes.GetHashCode();
                }
                if (this.EnumDataTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EnumDataTypes.GetHashCode();
                }
                if (this.SimpleDataTypes != null)
                {
                    hashCode = (hashCode * 59) + this.SimpleDataTypes.GetHashCode();
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
