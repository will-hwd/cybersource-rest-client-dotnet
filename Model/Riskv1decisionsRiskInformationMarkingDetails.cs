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
    /// Details for marking the transaction as either positive or negative.
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsRiskInformationMarkingDetails :  IEquatable<Riskv1decisionsRiskInformationMarkingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsRiskInformationMarkingDetails" /> class.
        /// </summary>
        /// <param name="Notes">Notes or details that explain the reasons for adding the transaction to either the positive or negative list..</param>
        /// <param name="Reason">Reason for adding the transaction to the negative list. This field can contain one of the following values: - fraud_chargeback: You have received a fraud-related chargeback for the transaction. - non_fraud_chargeback: You have received a non-fraudulent chargeback for the transaction. - suspected: You believe that you will probably receive a chargeback for the transaction. - creditback: You issued a refund to the customer to avoid a chargeback for the transaction. .</param>
        /// <param name="FieldsIncluded">Adds specified transaction information to the negative list. This field can contain one or more of the following values. When you specify more than one value, separate them with commas (,). - account_key_hash - customer_account_id - customer_email - customer_ipaddress - customer_phone - device_fingerprint - ship_address If no value is specified, account_key_hash, customer_email, and ship_address are used by default. Note account_key_hash adds the field that contains the card number (customer_cc_number). .</param>
        /// <param name="ReportCode">Indicates whether to add, clear, or remove order data from the fraud history. This field can contain one of the following values: - ST: Marking reason for suspected fraud transaction; same action as Mark as Suspect link in the Business Center - CB: Marking reason for chargeback; same action as Mark as Suspect link - CM: Clear suspected fraud marking reason; same action as Clear Mark as Suspect link - VT: Remove from history .</param>
        public Riskv1decisionsRiskInformationMarkingDetails(string Notes = default(string), string Reason = default(string), string FieldsIncluded = default(string), string ReportCode = default(string))
        {
            this.Notes = Notes;
            this.Reason = Reason;
            this.FieldsIncluded = FieldsIncluded;
            this.ReportCode = ReportCode;
        }
        
        /// <summary>
        /// Notes or details that explain the reasons for adding the transaction to either the positive or negative list.
        /// </summary>
        /// <value>Notes or details that explain the reasons for adding the transaction to either the positive or negative list.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Reason for adding the transaction to the negative list. This field can contain one of the following values: - fraud_chargeback: You have received a fraud-related chargeback for the transaction. - non_fraud_chargeback: You have received a non-fraudulent chargeback for the transaction. - suspected: You believe that you will probably receive a chargeback for the transaction. - creditback: You issued a refund to the customer to avoid a chargeback for the transaction. 
        /// </summary>
        /// <value>Reason for adding the transaction to the negative list. This field can contain one of the following values: - fraud_chargeback: You have received a fraud-related chargeback for the transaction. - non_fraud_chargeback: You have received a non-fraudulent chargeback for the transaction. - suspected: You believe that you will probably receive a chargeback for the transaction. - creditback: You issued a refund to the customer to avoid a chargeback for the transaction. </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Adds specified transaction information to the negative list. This field can contain one or more of the following values. When you specify more than one value, separate them with commas (,). - account_key_hash - customer_account_id - customer_email - customer_ipaddress - customer_phone - device_fingerprint - ship_address If no value is specified, account_key_hash, customer_email, and ship_address are used by default. Note account_key_hash adds the field that contains the card number (customer_cc_number). 
        /// </summary>
        /// <value>Adds specified transaction information to the negative list. This field can contain one or more of the following values. When you specify more than one value, separate them with commas (,). - account_key_hash - customer_account_id - customer_email - customer_ipaddress - customer_phone - device_fingerprint - ship_address If no value is specified, account_key_hash, customer_email, and ship_address are used by default. Note account_key_hash adds the field that contains the card number (customer_cc_number). </value>
        [DataMember(Name="fieldsIncluded", EmitDefaultValue=false)]
        public string FieldsIncluded { get; set; }

        /// <summary>
        /// Indicates whether to add, clear, or remove order data from the fraud history. This field can contain one of the following values: - ST: Marking reason for suspected fraud transaction; same action as Mark as Suspect link in the Business Center - CB: Marking reason for chargeback; same action as Mark as Suspect link - CM: Clear suspected fraud marking reason; same action as Clear Mark as Suspect link - VT: Remove from history 
        /// </summary>
        /// <value>Indicates whether to add, clear, or remove order data from the fraud history. This field can contain one of the following values: - ST: Marking reason for suspected fraud transaction; same action as Mark as Suspect link in the Business Center - CB: Marking reason for chargeback; same action as Mark as Suspect link - CM: Clear suspected fraud marking reason; same action as Clear Mark as Suspect link - VT: Remove from history </value>
        [DataMember(Name="reportCode", EmitDefaultValue=false)]
        public string ReportCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsRiskInformationMarkingDetails {\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  FieldsIncluded: ").Append(FieldsIncluded).Append("\n");
            sb.Append("  ReportCode: ").Append(ReportCode).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsRiskInformationMarkingDetails);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsRiskInformationMarkingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsRiskInformationMarkingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsRiskInformationMarkingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.FieldsIncluded == other.FieldsIncluded ||
                    this.FieldsIncluded != null &&
                    this.FieldsIncluded.Equals(other.FieldsIncluded)
                ) && 
                (
                    this.ReportCode == other.ReportCode ||
                    this.ReportCode != null &&
                    this.ReportCode.Equals(other.ReportCode)
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
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.FieldsIncluded != null)
                    hash = hash * 59 + this.FieldsIncluded.GetHashCode();
                if (this.ReportCode != null)
                    hash = hash * 59 + this.ReportCode.GetHashCode();
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
            // Notes (string) maxLength
            if(this.Notes != null && this.Notes.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Notes, length must be less than or equal to 255.", new [] { "Notes" });
            }

            // Reason (string) maxLength
            if(this.Reason != null && this.Reason.Length >= 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reason, length must be less than or equal to 25.", new [] { "Reason" });
            }

            // FieldsIncluded (string) maxLength
            if(this.FieldsIncluded != null && this.FieldsIncluded.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FieldsIncluded, length must be less than or equal to 255.", new [] { "FieldsIncluded" });
            }

            // ReportCode (string) maxLength
            if(this.ReportCode != null && this.ReportCode.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportCode, length must be less than or equal to 2.", new [] { "ReportCode" });
            }

            yield break;
        }
    }

}