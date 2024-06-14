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
    /// PersonalizationSessionEventDto
    /// </summary>
    [DataContract(Name = "PersonalizationSessionEventDto")]
    public partial class PersonalizationSessionEventDto : IEquatable<PersonalizationSessionEventDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizationSessionEventDto" /> class.
        /// </summary>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="message">message.</param>
        /// <param name="recordId">recordId.</param>
        /// <param name="success">success.</param>
        public PersonalizationSessionEventDto(DateTime timestamp = default(DateTime), string message = default(string), int recordId = default(int), bool? success = default(bool?))
        {
            this.Timestamp = timestamp;
            this.Message = message;
            this.RecordId = recordId;
            this.Success = success;
        }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name = "recordId", EmitDefaultValue = false)]
        public int RecordId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonalizationSessionEventDto {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as PersonalizationSessionEventDto);
        }

        /// <summary>
        /// Returns true if PersonalizationSessionEventDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonalizationSessionEventDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalizationSessionEventDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RecordId == input.RecordId ||
                    this.RecordId.Equals(input.RecordId)
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
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
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecordId.GetHashCode();
                if (this.Success != null)
                {
                    hashCode = (hashCode * 59) + this.Success.GetHashCode();
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