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
    /// Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions :  IEquatable<Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions" /> class.
        /// </summary>
        /// <param name="AuthType">Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="VerbalAuthCode">Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="VerbalAuthTransactionId">Transaction ID (TID)..</param>
        public Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions(string AuthType = default(string), string VerbalAuthCode = default(string), string VerbalAuthTransactionId = default(string))
        {
            this.AuthType = AuthType;
            this.VerbalAuthCode = VerbalAuthCode;
            this.VerbalAuthTransactionId = VerbalAuthTransactionId;
        }
        
        /// <summary>
        /// Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="verbalAuthCode", EmitDefaultValue=false)]
        public string VerbalAuthCode { get; set; }

        /// <summary>
        /// Transaction ID (TID).
        /// </summary>
        /// <value>Transaction ID (TID).</value>
        [DataMember(Name="verbalAuthTransactionId", EmitDefaultValue=false)]
        public string VerbalAuthTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions {\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  VerbalAuthCode: ").Append(VerbalAuthCode).Append("\n");
            sb.Append("  VerbalAuthTransactionId: ").Append(VerbalAuthTransactionId).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesProcessingInformationAuthorizationOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthType == other.AuthType ||
                    this.AuthType != null &&
                    this.AuthType.Equals(other.AuthType)
                ) && 
                (
                    this.VerbalAuthCode == other.VerbalAuthCode ||
                    this.VerbalAuthCode != null &&
                    this.VerbalAuthCode.Equals(other.VerbalAuthCode)
                ) && 
                (
                    this.VerbalAuthTransactionId == other.VerbalAuthTransactionId ||
                    this.VerbalAuthTransactionId != null &&
                    this.VerbalAuthTransactionId.Equals(other.VerbalAuthTransactionId)
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
                if (this.AuthType != null)
                    hash = hash * 59 + this.AuthType.GetHashCode();
                if (this.VerbalAuthCode != null)
                    hash = hash * 59 + this.VerbalAuthCode.GetHashCode();
                if (this.VerbalAuthTransactionId != null)
                    hash = hash * 59 + this.VerbalAuthTransactionId.GetHashCode();
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
            // AuthType (string) maxLength
            if(this.AuthType != null && this.AuthType.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthType, length must be less than 15.", new [] { "AuthType" });
            }

            // VerbalAuthCode (string) maxLength
            if(this.VerbalAuthCode != null && this.VerbalAuthCode.Length > 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VerbalAuthCode, length must be less than 7.", new [] { "VerbalAuthCode" });
            }

            // VerbalAuthTransactionId (string) maxLength
            if(this.VerbalAuthTransactionId != null && this.VerbalAuthTransactionId.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VerbalAuthTransactionId, length must be less than 15.", new [] { "VerbalAuthTransactionId" });
            }

            yield break;
        }
    }

}
