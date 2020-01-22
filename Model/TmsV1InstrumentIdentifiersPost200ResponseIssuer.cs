/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// TmsV1InstrumentIdentifiersPost200ResponseIssuer
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentIdentifiersPost200ResponseIssuer :  IEquatable<TmsV1InstrumentIdentifiersPost200ResponseIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentIdentifiersPost200ResponseIssuer" /> class.
        /// </summary>
        /// <param name="PaymentAccountReference">Unique identifier associated with a specific cardholder PAN.</param>
        public TmsV1InstrumentIdentifiersPost200ResponseIssuer(string PaymentAccountReference = default(string))
        {
            this.PaymentAccountReference = PaymentAccountReference;
        }
        
        /// <summary>
        /// Unique identifier associated with a specific cardholder PAN
        /// </summary>
        /// <value>Unique identifier associated with a specific cardholder PAN</value>
        [DataMember(Name="paymentAccountReference", EmitDefaultValue=false)]
        public string PaymentAccountReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentIdentifiersPost200ResponseIssuer {\n");
            sb.Append("  PaymentAccountReference: ").Append(PaymentAccountReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TmsV1InstrumentIdentifiersPost200ResponseIssuer);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentIdentifiersPost200ResponseIssuer instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentIdentifiersPost200ResponseIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentIdentifiersPost200ResponseIssuer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentAccountReference == other.PaymentAccountReference ||
                    this.PaymentAccountReference != null &&
                    this.PaymentAccountReference.Equals(other.PaymentAccountReference)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PaymentAccountReference != null)
                    hash = hash * 59 + this.PaymentAccountReference.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PaymentAccountReference (string) maxLength
            if(this.PaymentAccountReference != null && this.PaymentAccountReference.Length >= 29)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentAccountReference, length must be less than or equal to 29.", new [] { "PaymentAccountReference" });
            }

            // PaymentAccountReference (string) minLength
            if(this.PaymentAccountReference != null && this.PaymentAccountReference.Length <= 29)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentAccountReference, length must be greater than or equal to 29.", new [] { "PaymentAccountReference" });
            }

            yield break;
        }
    }

}