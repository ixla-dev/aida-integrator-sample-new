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
    /// PixelMapDto
    /// </summary>
    [DataContract(Name = "PixelMapDto")]
    public partial class PixelMapDto : IEquatable<PixelMapDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PixelMapDto" /> class.
        /// </summary>
        /// <param name="zone01">zone01.</param>
        /// <param name="zone02">zone02.</param>
        /// <param name="zone03">zone03.</param>
        /// <param name="zone04">zone04.</param>
        /// <param name="zone05">zone05.</param>
        /// <param name="zone06">zone06.</param>
        public PixelMapDto(int zone01 = default(int), int zone02 = default(int), int zone03 = default(int), int zone04 = default(int), int zone05 = default(int), int zone06 = default(int))
        {
            this.Zone01 = zone01;
            this.Zone02 = zone02;
            this.Zone03 = zone03;
            this.Zone04 = zone04;
            this.Zone05 = zone05;
            this.Zone06 = zone06;
        }

        /// <summary>
        /// Gets or Sets Zone01
        /// </summary>
        [DataMember(Name = "zone01", EmitDefaultValue = false)]
        public int Zone01 { get; set; }

        /// <summary>
        /// Gets or Sets Zone02
        /// </summary>
        [DataMember(Name = "zone02", EmitDefaultValue = false)]
        public int Zone02 { get; set; }

        /// <summary>
        /// Gets or Sets Zone03
        /// </summary>
        [DataMember(Name = "zone03", EmitDefaultValue = false)]
        public int Zone03 { get; set; }

        /// <summary>
        /// Gets or Sets Zone04
        /// </summary>
        [DataMember(Name = "zone04", EmitDefaultValue = false)]
        public int Zone04 { get; set; }

        /// <summary>
        /// Gets or Sets Zone05
        /// </summary>
        [DataMember(Name = "zone05", EmitDefaultValue = false)]
        public int Zone05 { get; set; }

        /// <summary>
        /// Gets or Sets Zone06
        /// </summary>
        [DataMember(Name = "zone06", EmitDefaultValue = false)]
        public int Zone06 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PixelMapDto {\n");
            sb.Append("  Zone01: ").Append(Zone01).Append("\n");
            sb.Append("  Zone02: ").Append(Zone02).Append("\n");
            sb.Append("  Zone03: ").Append(Zone03).Append("\n");
            sb.Append("  Zone04: ").Append(Zone04).Append("\n");
            sb.Append("  Zone05: ").Append(Zone05).Append("\n");
            sb.Append("  Zone06: ").Append(Zone06).Append("\n");
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
            return this.Equals(input as PixelMapDto);
        }

        /// <summary>
        /// Returns true if PixelMapDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PixelMapDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PixelMapDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Zone01 == input.Zone01 ||
                    this.Zone01.Equals(input.Zone01)
                ) && 
                (
                    this.Zone02 == input.Zone02 ||
                    this.Zone02.Equals(input.Zone02)
                ) && 
                (
                    this.Zone03 == input.Zone03 ||
                    this.Zone03.Equals(input.Zone03)
                ) && 
                (
                    this.Zone04 == input.Zone04 ||
                    this.Zone04.Equals(input.Zone04)
                ) && 
                (
                    this.Zone05 == input.Zone05 ||
                    this.Zone05.Equals(input.Zone05)
                ) && 
                (
                    this.Zone06 == input.Zone06 ||
                    this.Zone06.Equals(input.Zone06)
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
                hashCode = (hashCode * 59) + this.Zone01.GetHashCode();
                hashCode = (hashCode * 59) + this.Zone02.GetHashCode();
                hashCode = (hashCode * 59) + this.Zone03.GetHashCode();
                hashCode = (hashCode * 59) + this.Zone04.GetHashCode();
                hashCode = (hashCode * 59) + this.Zone05.GetHashCode();
                hashCode = (hashCode * 59) + this.Zone06.GetHashCode();
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