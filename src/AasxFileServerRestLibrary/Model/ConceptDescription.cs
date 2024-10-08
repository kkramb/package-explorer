/* 
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: Final-Draft
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ConceptDescription
    /// </summary>
    [DataContract]
    public partial class ConceptDescription : Identifiable, IEquatable<ConceptDescription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConceptDescription" /> class.
        /// </summary>
        /// <param name="embeddedDataSpecifications">embeddedDataSpecifications.</param>
        /// <param name="isCaseOf">isCaseOf.</param>
        public ConceptDescription(List<EmbeddedDataSpecification> embeddedDataSpecifications = default(List<EmbeddedDataSpecification>), List<Reference> isCaseOf = default(List<Reference>), List<EmbeddedDataSpecification> embeddedDataSpecifications2 = default(List<EmbeddedDataSpecification>), AdministrativeInformation administration = default(AdministrativeInformation), string identification = default(string)) : base(administration, identification)
        {
            this.EmbeddedDataSpecifications = embeddedDataSpecifications;
            this.IsCaseOf = isCaseOf;
        }

        /// <summary>
        /// Gets or Sets EmbeddedDataSpecifications
        /// </summary>
        [DataMember(Name = "embeddedDataSpecifications", EmitDefaultValue = false)]
        public List<EmbeddedDataSpecification> EmbeddedDataSpecifications { get; set; }

        /// <summary>
        /// Gets or Sets IsCaseOf
        /// </summary>
        [DataMember(Name = "isCaseOf", EmitDefaultValue = false)]
        public List<Reference> IsCaseOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConceptDescription {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EmbeddedDataSpecifications: ").Append(EmbeddedDataSpecifications).Append("\n");
            sb.Append("  IsCaseOf: ").Append(IsCaseOf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConceptDescription);
        }

        /// <summary>
        /// Returns true if ConceptDescription instances are equal
        /// </summary>
        /// <param name="input">Instance of ConceptDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConceptDescription input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.EmbeddedDataSpecifications == input.EmbeddedDataSpecifications ||
                    this.EmbeddedDataSpecifications != null &&
                    input.EmbeddedDataSpecifications != null &&
                    this.EmbeddedDataSpecifications.SequenceEqual(input.EmbeddedDataSpecifications)
                ) && base.Equals(input) &&
                (
                    this.IsCaseOf == input.IsCaseOf ||
                    this.IsCaseOf != null &&
                    input.IsCaseOf != null &&
                    this.IsCaseOf.SequenceEqual(input.IsCaseOf)
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
                int hashCode = base.GetHashCode();
                if (this.EmbeddedDataSpecifications != null)
                    hashCode = hashCode * 59 + this.EmbeddedDataSpecifications.GetHashCode();
                if (this.IsCaseOf != null)
                    hashCode = hashCode * 59 + this.IsCaseOf.GetHashCode();
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
