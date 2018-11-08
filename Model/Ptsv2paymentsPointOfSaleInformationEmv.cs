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
    /// Ptsv2paymentsPointOfSaleInformationEmv
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPointOfSaleInformationEmv :  IEquatable<Ptsv2paymentsPointOfSaleInformationEmv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPointOfSaleInformationEmv" /> class.
        /// </summary>
        /// <param name="Tags">EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  &#x60;Important&#x60; The following tags contain sensitive information and **must not** be included in this field:   - **56**: Track 1 equivalent data  - **57**: Track 2 equivalent data  - **5A**: Application PAN  - **5F20**: Cardholder name  - **5F24**: Application expiration date (This sensitivity has been relaxed for cmcic, amexdirect, fdiglobal, opdfde, six)  - **99**: Transaction PIN  - **9F0B**: Cardholder name (extended)  - **9F1F**: Track 1 discretionary data  - **9F20**: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  &#x60;Important&#x60; For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - **95**: Terminal verification results  - **9F10**: Issuer application data  - **9F26**: Application cryptogram .</param>
        /// <param name="CardholderVerificationMethod">Method that was used to verify the cardholder&#39;s identity. Possible values:   - **0**: No verification  - **1**: Signature  This field is supported only on **American Express Direct**. .</param>
        /// <param name="CardSequenceNumber">Number assigned to a specific card when two or more cards are associated with the same primary account number. This value enables issuers to distinguish among multiple cards that are linked to the same account. This value can also act as a tracking tool when reissuing cards. When this value is available, it is provided by the chip reader. When the chip reader does not provide this value, do not include this field in your request. .</param>
        /// <param name="Fallback">Indicates whether a fallback method was used to enter credit card information into the POS terminal. When a technical problem prevents a successful exchange of information between a chip card and a chip-capable terminal:   1. Swipe the card or key the credit card information into the POS terminal.  2. Use the pos_entry_mode field to indicate whether the information was swiped or keyed.  This field is supported only on **Chase Paymentech Solutions** and **GPN**.  (default to false).</param>
        /// <param name="FallbackCondition">Reason for the EMV fallback transaction. An EMV fallback transaction occurs when an EMV transaction fails for one of these reasons:   - Technical failure: the EMV terminal or EMV card cannot read and process chip data.  - Empty candidate list failure: the EMV terminal does not have any applications in common with the EMV card.    EMV terminals are coded to determine whether the terminal and EMV card have any applications in common.    EMV terminals provide this information to you.  Possible values:   - **1**: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the       EMV terminal either used information from a successful chip read or it was not a chip transaction.  - **2**: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the       EMV terminal was an EMV fallback transaction because the attempted chip read was unsuccessful.  This field is supported only on **GPN**. .</param>
        public Ptsv2paymentsPointOfSaleInformationEmv(string Tags = default(string), decimal? CardholderVerificationMethod = default(decimal?), string CardSequenceNumber = default(string), bool? Fallback = false, decimal? FallbackCondition = default(decimal?))
        {
            this.Tags = Tags;
            this.CardholderVerificationMethod = CardholderVerificationMethod;
            this.CardSequenceNumber = CardSequenceNumber;
            // use default value if no "Fallback" provided
            if (Fallback == null)
            {
                this.Fallback = false;
            }
            else
            {
                this.Fallback = Fallback;
            }
            this.FallbackCondition = FallbackCondition;
        }
        
        /// <summary>
        /// EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  &#x60;Important&#x60; The following tags contain sensitive information and **must not** be included in this field:   - **56**: Track 1 equivalent data  - **57**: Track 2 equivalent data  - **5A**: Application PAN  - **5F20**: Cardholder name  - **5F24**: Application expiration date (This sensitivity has been relaxed for cmcic, amexdirect, fdiglobal, opdfde, six)  - **99**: Transaction PIN  - **9F0B**: Cardholder name (extended)  - **9F1F**: Track 1 discretionary data  - **9F20**: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  &#x60;Important&#x60; For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - **95**: Terminal verification results  - **9F10**: Issuer application data  - **9F26**: Application cryptogram 
        /// </summary>
        /// <value>EMV data that is transmitted from the chip card to the issuer, and from the issuer to the chip card. The EMV data is in the tag-length-value format and includes chip card tags, terminal tags, and transaction detail tags.  &#x60;Important&#x60; The following tags contain sensitive information and **must not** be included in this field:   - **56**: Track 1 equivalent data  - **57**: Track 2 equivalent data  - **5A**: Application PAN  - **5F20**: Cardholder name  - **5F24**: Application expiration date (This sensitivity has been relaxed for cmcic, amexdirect, fdiglobal, opdfde, six)  - **99**: Transaction PIN  - **9F0B**: Cardholder name (extended)  - **9F1F**: Track 1 discretionary data  - **9F20**: Track 2 discretionary data  For captures, this field is required for contact EMV transactions. Otherwise, it is optional.  For credits, this field is required for contact EMV stand-alone credits and contactless EMV stand-alone credits. Otherwise, it is optional.  &#x60;Important&#x60; For contact EMV captures, contact EMV stand-alone credits, and contactless EMV stand-alone credits, you must include the following tags in this field. For all other types of EMV transactions, the following tags are optional.   - **95**: Terminal verification results  - **9F10**: Issuer application data  - **9F26**: Application cryptogram </value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Method that was used to verify the cardholder&#39;s identity. Possible values:   - **0**: No verification  - **1**: Signature  This field is supported only on **American Express Direct**. 
        /// </summary>
        /// <value>Method that was used to verify the cardholder&#39;s identity. Possible values:   - **0**: No verification  - **1**: Signature  This field is supported only on **American Express Direct**. </value>
        [DataMember(Name="cardholderVerificationMethod", EmitDefaultValue=false)]
        public decimal? CardholderVerificationMethod { get; set; }

        /// <summary>
        /// Number assigned to a specific card when two or more cards are associated with the same primary account number. This value enables issuers to distinguish among multiple cards that are linked to the same account. This value can also act as a tracking tool when reissuing cards. When this value is available, it is provided by the chip reader. When the chip reader does not provide this value, do not include this field in your request. 
        /// </summary>
        /// <value>Number assigned to a specific card when two or more cards are associated with the same primary account number. This value enables issuers to distinguish among multiple cards that are linked to the same account. This value can also act as a tracking tool when reissuing cards. When this value is available, it is provided by the chip reader. When the chip reader does not provide this value, do not include this field in your request. </value>
        [DataMember(Name="cardSequenceNumber", EmitDefaultValue=false)]
        public string CardSequenceNumber { get; set; }

        /// <summary>
        /// Indicates whether a fallback method was used to enter credit card information into the POS terminal. When a technical problem prevents a successful exchange of information between a chip card and a chip-capable terminal:   1. Swipe the card or key the credit card information into the POS terminal.  2. Use the pos_entry_mode field to indicate whether the information was swiped or keyed.  This field is supported only on **Chase Paymentech Solutions** and **GPN**. 
        /// </summary>
        /// <value>Indicates whether a fallback method was used to enter credit card information into the POS terminal. When a technical problem prevents a successful exchange of information between a chip card and a chip-capable terminal:   1. Swipe the card or key the credit card information into the POS terminal.  2. Use the pos_entry_mode field to indicate whether the information was swiped or keyed.  This field is supported only on **Chase Paymentech Solutions** and **GPN**. </value>
        [DataMember(Name="fallback", EmitDefaultValue=false)]
        public bool? Fallback { get; set; }

        /// <summary>
        /// Reason for the EMV fallback transaction. An EMV fallback transaction occurs when an EMV transaction fails for one of these reasons:   - Technical failure: the EMV terminal or EMV card cannot read and process chip data.  - Empty candidate list failure: the EMV terminal does not have any applications in common with the EMV card.    EMV terminals are coded to determine whether the terminal and EMV card have any applications in common.    EMV terminals provide this information to you.  Possible values:   - **1**: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the       EMV terminal either used information from a successful chip read or it was not a chip transaction.  - **2**: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the       EMV terminal was an EMV fallback transaction because the attempted chip read was unsuccessful.  This field is supported only on **GPN**. 
        /// </summary>
        /// <value>Reason for the EMV fallback transaction. An EMV fallback transaction occurs when an EMV transaction fails for one of these reasons:   - Technical failure: the EMV terminal or EMV card cannot read and process chip data.  - Empty candidate list failure: the EMV terminal does not have any applications in common with the EMV card.    EMV terminals are coded to determine whether the terminal and EMV card have any applications in common.    EMV terminals provide this information to you.  Possible values:   - **1**: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the       EMV terminal either used information from a successful chip read or it was not a chip transaction.  - **2**: Transaction was initiated with information from a magnetic stripe, and the previous transaction at the       EMV terminal was an EMV fallback transaction because the attempted chip read was unsuccessful.  This field is supported only on **GPN**. </value>
        [DataMember(Name="fallbackCondition", EmitDefaultValue=false)]
        public decimal? FallbackCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPointOfSaleInformationEmv {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CardholderVerificationMethod: ").Append(CardholderVerificationMethod).Append("\n");
            sb.Append("  CardSequenceNumber: ").Append(CardSequenceNumber).Append("\n");
            sb.Append("  Fallback: ").Append(Fallback).Append("\n");
            sb.Append("  FallbackCondition: ").Append(FallbackCondition).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPointOfSaleInformationEmv);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPointOfSaleInformationEmv instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPointOfSaleInformationEmv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPointOfSaleInformationEmv other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.CardholderVerificationMethod == other.CardholderVerificationMethod ||
                    this.CardholderVerificationMethod != null &&
                    this.CardholderVerificationMethod.Equals(other.CardholderVerificationMethod)
                ) && 
                (
                    this.CardSequenceNumber == other.CardSequenceNumber ||
                    this.CardSequenceNumber != null &&
                    this.CardSequenceNumber.Equals(other.CardSequenceNumber)
                ) && 
                (
                    this.Fallback == other.Fallback ||
                    this.Fallback != null &&
                    this.Fallback.Equals(other.Fallback)
                ) && 
                (
                    this.FallbackCondition == other.FallbackCondition ||
                    this.FallbackCondition != null &&
                    this.FallbackCondition.Equals(other.FallbackCondition)
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
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.CardholderVerificationMethod != null)
                    hash = hash * 59 + this.CardholderVerificationMethod.GetHashCode();
                if (this.CardSequenceNumber != null)
                    hash = hash * 59 + this.CardSequenceNumber.GetHashCode();
                if (this.Fallback != null)
                    hash = hash * 59 + this.Fallback.GetHashCode();
                if (this.FallbackCondition != null)
                    hash = hash * 59 + this.FallbackCondition.GetHashCode();
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
            // Tags (string) maxLength
            if(this.Tags != null && this.Tags.Length > 1998)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tags, length must be less than 1998.", new [] { "Tags" });
            }

            // CardSequenceNumber (string) maxLength
            if(this.CardSequenceNumber != null && this.CardSequenceNumber.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardSequenceNumber, length must be less than 3.", new [] { "CardSequenceNumber" });
            }

            yield break;
        }
    }

}
