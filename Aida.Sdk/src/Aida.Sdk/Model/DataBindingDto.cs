/*
 * aida
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
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
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// DataBindingDto
    /// </summary>
    [DataContract(Name = "DataBindingDto")]
    public partial class DataBindingDto : IEquatable<DataBindingDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBindingDto" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="name">name.</param>
        /// <param name="columnName">columnName.</param>
        /// <param name="type">type.</param>
        /// <param name="cardSide">cardSide.</param>
        /// <param name="valueType">valueType.</param>
        /// <param name="operation">operation.</param>
        public DataBindingDto(int index = default(int), string name = default(string), string columnName = default(string), string type = default(string), string cardSide = default(string), string valueType = default(string), string operation = default(string))
        {
            this.Index = index;
            this.Name = name;
            this.ColumnName = columnName;
            this.Type = type;
            this.CardSide = cardSide;
            this.ValueType = valueType;
            this.Operation = operation;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ColumnName
        /// </summary>
        [DataMember(Name = "columnName", EmitDefaultValue = true)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets CardSide
        /// </summary>
        [DataMember(Name = "cardSide", EmitDefaultValue = true)]
        public string CardSide { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = true)]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataBindingDto {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CardSide: ").Append(CardSide).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
            return this.Equals(input as DataBindingDto);
        }

        /// <summary>
        /// Returns true if DataBindingDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DataBindingDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataBindingDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ColumnName == input.ColumnName ||
                    (this.ColumnName != null &&
                    this.ColumnName.Equals(input.ColumnName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CardSide == input.CardSide ||
                    (this.CardSide != null &&
                    this.CardSide.Equals(input.CardSide))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ColumnName != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnName.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.CardSide != null)
                {
                    hashCode = (hashCode * 59) + this.CardSide.GetHashCode();
                }
                if (this.ValueType != null)
                {
                    hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                }
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}