/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// The public key in JSON Web Key (JWK) format. This format is useful for client side encryption in JavaScript based implementations.
    /// </summary>
    [DataContract]
    public partial class JsonWebKey :  IEquatable<JsonWebKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWebKey" /> class.
        /// </summary>
        /// <param name="Kty">Algorithm used to encrypt the public key..</param>
        /// <param name="Use">Defines whether to use the key for encryption (enc) or verifying a signature (sig). Always returned as enc..</param>
        /// <param name="Kid">The key ID in JWK format..</param>
        /// <param name="N">JWK RSA Modulus.</param>
        /// <param name="E">JWK RSA Exponent.</param>
        public JsonWebKey(string Kty = default(string), string Use = default(string), string Kid = default(string), string N = default(string), string E = default(string))
        {
            this.Kty = Kty;
            this.Use = Use;
            this.Kid = Kid;
            this.N = N;
            this.E = E;
        }
        
        /// <summary>
        /// Algorithm used to encrypt the public key.
        /// </summary>
        /// <value>Algorithm used to encrypt the public key.</value>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public string Kty { get; set; }

        /// <summary>
        /// Defines whether to use the key for encryption (enc) or verifying a signature (sig). Always returned as enc.
        /// </summary>
        /// <value>Defines whether to use the key for encryption (enc) or verifying a signature (sig). Always returned as enc.</value>
        [DataMember(Name="use", EmitDefaultValue=false)]
        public string Use { get; set; }

        /// <summary>
        /// The key ID in JWK format.
        /// </summary>
        /// <value>The key ID in JWK format.</value>
        [DataMember(Name="kid", EmitDefaultValue=false)]
        public string Kid { get; set; }

        /// <summary>
        /// JWK RSA Modulus
        /// </summary>
        /// <value>JWK RSA Modulus</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public string N { get; set; }

        /// <summary>
        /// JWK RSA Exponent
        /// </summary>
        /// <value>JWK RSA Exponent</value>
        [DataMember(Name="e", EmitDefaultValue=false)]
        public string E { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonWebKey {\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
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
            return this.Equals(obj as JsonWebKey);
        }

        /// <summary>
        /// Returns true if JsonWebKey instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonWebKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonWebKey other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Kty == other.Kty ||
                    this.Kty != null &&
                    this.Kty.Equals(other.Kty)
                ) && 
                (
                    this.Use == other.Use ||
                    this.Use != null &&
                    this.Use.Equals(other.Use)
                ) && 
                (
                    this.Kid == other.Kid ||
                    this.Kid != null &&
                    this.Kid.Equals(other.Kid)
                ) && 
                (
                    this.N == other.N ||
                    this.N != null &&
                    this.N.Equals(other.N)
                ) && 
                (
                    this.E == other.E ||
                    this.E != null &&
                    this.E.Equals(other.E)
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
                if (this.Kty != null)
                    hash = hash * 59 + this.Kty.GetHashCode();
                if (this.Use != null)
                    hash = hash * 59 + this.Use.GetHashCode();
                if (this.Kid != null)
                    hash = hash * 59 + this.Kid.GetHashCode();
                if (this.N != null)
                    hash = hash * 59 + this.N.GetHashCode();
                if (this.E != null)
                    hash = hash * 59 + this.E.GetHashCode();
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
            yield break;
        }
    }

}
