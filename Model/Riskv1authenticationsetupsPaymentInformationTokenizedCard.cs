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
    /// Riskv1authenticationsetupsPaymentInformationTokenizedCard
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsetupsPaymentInformationTokenizedCard :  IEquatable<Riskv1authenticationsetupsPaymentInformationTokenizedCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsetupsPaymentInformationTokenizedCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Riskv1authenticationsetupsPaymentInformationTokenizedCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsetupsPaymentInformationTokenizedCard" /> class.
        /// </summary>
        /// <param name="TransactionType">Type of transaction that provided the token data. This value does not specify the token service provider; it specifies the entity that provided you with information about the token.  Possible value: - &#x60;2&#x60;: Near-field communication (NFC) transaction. The customer’s mobile device provided the token data for a contactless EMV transaction. For recurring transactions, use this value if the original transaction was a contactless EMV transaction.  **NOTE** No CyberSource through VisaNet acquirers support EMV at this time.  Required field for PIN debit credit or PIN debit purchase transactions that use payment network tokens; otherwise, not used.  (required).</param>
        /// <param name="Type">Three-digit value that indicates the card type.  **IMPORTANT** It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values: - &#x60;001&#x60;: Visa. For card-present transactions on all processors except SIX, the Visa Electron card type is processed the same way that the Visa debit card is processed. Use card type value &#x60;001&#x60; for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. - &#x60;003&#x60;: American Express - &#x60;004&#x60;: Discover - &#x60;005&#x60;: Diners Club - &#x60;006&#x60;: Carte Blanche[^1] - &#x60;007&#x60;: JCB[^1] - &#x60;014&#x60;: Enroute[^1] - &#x60;021&#x60;: JAL[^1] - &#x60;024&#x60;: Maestro (UK Domestic)[^1] - &#x60;031&#x60;: Delta[^1]: Use this value only for Ingenico ePayments. For other processors, use &#x60;001&#x60; for all Visa card types. - &#x60;033&#x60;: Visa Electron[^1]. Use this value only for Ingenico ePayments and SIX. For other processors, use &#x60;001&#x60; for all Visa card types. - &#x60;034&#x60;: Dankort[^1] - &#x60;036&#x60;: Cartes Bancaires[^1] - &#x60;037&#x60;: Carta Si[^1] - &#x60;039&#x60;: Encoded account number[^1] - &#x60;040&#x60;: UATP[^1] - &#x60;042&#x60;: Maestro (International)[^1] - &#x60;050&#x60;: Hipercard[^2,3] - &#x60;051&#x60;: Aura - &#x60;054&#x60;: Elo[^3] - &#x60;062&#x60;: China UnionPay  [^1]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in your request for an authorization or a stand-alone credit. [^2]: For this card type on Cielo 3.0, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5. [^3]: For this card type on Getnet and Rede, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit.  #### Used by **Authorization** Required for Carte Blanche and JCB. Optional for all other card types.  #### Card Present reply This field is included in the reply message when the client software that is installed on the POS terminal uses the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to have your account enabled to receive these fields in the credit reply message.  Returned by the Credit service.  This reply field is only supported by the following processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International  (required).</param>
        /// <param name="ExpirationMonth">One of two possible meanings: - The two-digit month in which a token expires. - The two-digit month in which a card expires. Format: &#x60;MM&#x60; Possible values: &#x60;01&#x60; through &#x60;12&#x60;  **NOTE** The meaning of this field is dependent on the payment processor that is returning the value in an authorization reply. Please see the processor-specific details below.  #### Barclays and Streamline For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (&#x60;01&#x60; through &#x60;12&#x60;) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  #### Encoded Account Numbers For encoded account numbers (&#x60;card_type&#x3D;039&#x60;), if there is no expiration date on the card, use &#x60;12&#x60;.\\ **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  #### Samsung Pay and Apple Pay Month in which the token expires. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  For processor-specific information, see the &#x60;customer_cc_expmo&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  (required).</param>
        /// <param name="ExpirationYear">One of two possible meanings: - The four-digit year in which a token expires. - The four-digit year in which a card expires. Format: &#x60;YYYY&#x60; Possible values: &#x60;1900&#x60; through &#x60;3000&#x60; Data type: Non-negative integer  **NOTE** The meaning of this field is dependent on the payment processor that is returning the value in an authorization reply. Please see the processor-specific details below.  #### Barclays and Streamline For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  #### Encoded Account Numbers For encoded account numbers (&#x60;card_ type&#x3D;039&#x60;), if there is no expiration date on the card, use &#x60;2021&#x60;.  #### FDC Nashville Global and FDMS South You can send in 2 digits or 4 digits. When you send in 2 digits, they must be the last 2 digits of the year.  #### Samsung Pay and Apple Pay Year in which the token expires. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  For processor-specific information, see the &#x60;customer_cc_expyr&#x60; or &#x60;token_expiration_year&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  (required).</param>
        /// <param name="Number">Customer’s payment network token value.  (required).</param>
        public Riskv1authenticationsetupsPaymentInformationTokenizedCard(string TransactionType = default(string), string Type = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string), string Number = default(string))
        {
            // to ensure "TransactionType" is required (not null)
            if (TransactionType == null)
            {
                throw new InvalidDataException("TransactionType is a required property for Riskv1authenticationsetupsPaymentInformationTokenizedCard and cannot be null");
            }
            else
            {
                this.TransactionType = TransactionType;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Riskv1authenticationsetupsPaymentInformationTokenizedCard and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "ExpirationMonth" is required (not null)
            if (ExpirationMonth == null)
            {
                throw new InvalidDataException("ExpirationMonth is a required property for Riskv1authenticationsetupsPaymentInformationTokenizedCard and cannot be null");
            }
            else
            {
                this.ExpirationMonth = ExpirationMonth;
            }
            // to ensure "ExpirationYear" is required (not null)
            if (ExpirationYear == null)
            {
                throw new InvalidDataException("ExpirationYear is a required property for Riskv1authenticationsetupsPaymentInformationTokenizedCard and cannot be null");
            }
            else
            {
                this.ExpirationYear = ExpirationYear;
            }
            // to ensure "Number" is required (not null)
            if (Number == null)
            {
                throw new InvalidDataException("Number is a required property for Riskv1authenticationsetupsPaymentInformationTokenizedCard and cannot be null");
            }
            else
            {
                this.Number = Number;
            }
        }
        
        /// <summary>
        /// Type of transaction that provided the token data. This value does not specify the token service provider; it specifies the entity that provided you with information about the token.  Possible value: - &#x60;2&#x60;: Near-field communication (NFC) transaction. The customer’s mobile device provided the token data for a contactless EMV transaction. For recurring transactions, use this value if the original transaction was a contactless EMV transaction.  **NOTE** No CyberSource through VisaNet acquirers support EMV at this time.  Required field for PIN debit credit or PIN debit purchase transactions that use payment network tokens; otherwise, not used. 
        /// </summary>
        /// <value>Type of transaction that provided the token data. This value does not specify the token service provider; it specifies the entity that provided you with information about the token.  Possible value: - &#x60;2&#x60;: Near-field communication (NFC) transaction. The customer’s mobile device provided the token data for a contactless EMV transaction. For recurring transactions, use this value if the original transaction was a contactless EMV transaction.  **NOTE** No CyberSource through VisaNet acquirers support EMV at this time.  Required field for PIN debit credit or PIN debit purchase transactions that use payment network tokens; otherwise, not used. </value>
        [DataMember(Name="transactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Three-digit value that indicates the card type.  **IMPORTANT** It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values: - &#x60;001&#x60;: Visa. For card-present transactions on all processors except SIX, the Visa Electron card type is processed the same way that the Visa debit card is processed. Use card type value &#x60;001&#x60; for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. - &#x60;003&#x60;: American Express - &#x60;004&#x60;: Discover - &#x60;005&#x60;: Diners Club - &#x60;006&#x60;: Carte Blanche[^1] - &#x60;007&#x60;: JCB[^1] - &#x60;014&#x60;: Enroute[^1] - &#x60;021&#x60;: JAL[^1] - &#x60;024&#x60;: Maestro (UK Domestic)[^1] - &#x60;031&#x60;: Delta[^1]: Use this value only for Ingenico ePayments. For other processors, use &#x60;001&#x60; for all Visa card types. - &#x60;033&#x60;: Visa Electron[^1]. Use this value only for Ingenico ePayments and SIX. For other processors, use &#x60;001&#x60; for all Visa card types. - &#x60;034&#x60;: Dankort[^1] - &#x60;036&#x60;: Cartes Bancaires[^1] - &#x60;037&#x60;: Carta Si[^1] - &#x60;039&#x60;: Encoded account number[^1] - &#x60;040&#x60;: UATP[^1] - &#x60;042&#x60;: Maestro (International)[^1] - &#x60;050&#x60;: Hipercard[^2,3] - &#x60;051&#x60;: Aura - &#x60;054&#x60;: Elo[^3] - &#x60;062&#x60;: China UnionPay  [^1]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in your request for an authorization or a stand-alone credit. [^2]: For this card type on Cielo 3.0, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5. [^3]: For this card type on Getnet and Rede, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit.  #### Used by **Authorization** Required for Carte Blanche and JCB. Optional for all other card types.  #### Card Present reply This field is included in the reply message when the client software that is installed on the POS terminal uses the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to have your account enabled to receive these fields in the credit reply message.  Returned by the Credit service.  This reply field is only supported by the following processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International 
        /// </summary>
        /// <value>Three-digit value that indicates the card type.  **IMPORTANT** It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values: - &#x60;001&#x60;: Visa. For card-present transactions on all processors except SIX, the Visa Electron card type is processed the same way that the Visa debit card is processed. Use card type value &#x60;001&#x60; for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. - &#x60;003&#x60;: American Express - &#x60;004&#x60;: Discover - &#x60;005&#x60;: Diners Club - &#x60;006&#x60;: Carte Blanche[^1] - &#x60;007&#x60;: JCB[^1] - &#x60;014&#x60;: Enroute[^1] - &#x60;021&#x60;: JAL[^1] - &#x60;024&#x60;: Maestro (UK Domestic)[^1] - &#x60;031&#x60;: Delta[^1]: Use this value only for Ingenico ePayments. For other processors, use &#x60;001&#x60; for all Visa card types. - &#x60;033&#x60;: Visa Electron[^1]. Use this value only for Ingenico ePayments and SIX. For other processors, use &#x60;001&#x60; for all Visa card types. - &#x60;034&#x60;: Dankort[^1] - &#x60;036&#x60;: Cartes Bancaires[^1] - &#x60;037&#x60;: Carta Si[^1] - &#x60;039&#x60;: Encoded account number[^1] - &#x60;040&#x60;: UATP[^1] - &#x60;042&#x60;: Maestro (International)[^1] - &#x60;050&#x60;: Hipercard[^2,3] - &#x60;051&#x60;: Aura - &#x60;054&#x60;: Elo[^3] - &#x60;062&#x60;: China UnionPay  [^1]: For this card type, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in your request for an authorization or a stand-alone credit. [^2]: For this card type on Cielo 3.0, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit. This card type is not supported on Cielo 1.5. [^3]: For this card type on Getnet and Rede, you must include the &#x60;paymentInformation.card.type&#x60; or &#x60;paymentInformation.tokenizedCard.type&#x60; field in a request for an authorization or a stand-alone credit.  #### Used by **Authorization** Required for Carte Blanche and JCB. Optional for all other card types.  #### Card Present reply This field is included in the reply message when the client software that is installed on the POS terminal uses the token management service (TMS) to retrieve tokenized payment details. You must contact customer support to have your account enabled to receive these fields in the credit reply message.  Returned by the Credit service.  This reply field is only supported by the following processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX  #### GPX This field only supports transactions from the following card types: - Visa - Mastercard - AMEX - Discover - Diners - JCB - Union Pay International </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// One of two possible meanings: - The two-digit month in which a token expires. - The two-digit month in which a card expires. Format: &#x60;MM&#x60; Possible values: &#x60;01&#x60; through &#x60;12&#x60;  **NOTE** The meaning of this field is dependent on the payment processor that is returning the value in an authorization reply. Please see the processor-specific details below.  #### Barclays and Streamline For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (&#x60;01&#x60; through &#x60;12&#x60;) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  #### Encoded Account Numbers For encoded account numbers (&#x60;card_type&#x3D;039&#x60;), if there is no expiration date on the card, use &#x60;12&#x60;.\\ **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  #### Samsung Pay and Apple Pay Month in which the token expires. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  For processor-specific information, see the &#x60;customer_cc_expmo&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>One of two possible meanings: - The two-digit month in which a token expires. - The two-digit month in which a card expires. Format: &#x60;MM&#x60; Possible values: &#x60;01&#x60; through &#x60;12&#x60;  **NOTE** The meaning of this field is dependent on the payment processor that is returning the value in an authorization reply. Please see the processor-specific details below.  #### Barclays and Streamline For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (&#x60;01&#x60; through &#x60;12&#x60;) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  #### Encoded Account Numbers For encoded account numbers (&#x60;card_type&#x3D;039&#x60;), if there is no expiration date on the card, use &#x60;12&#x60;.\\ **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  #### Samsung Pay and Apple Pay Month in which the token expires. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  For processor-specific information, see the &#x60;customer_cc_expmo&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// One of two possible meanings: - The four-digit year in which a token expires. - The four-digit year in which a card expires. Format: &#x60;YYYY&#x60; Possible values: &#x60;1900&#x60; through &#x60;3000&#x60; Data type: Non-negative integer  **NOTE** The meaning of this field is dependent on the payment processor that is returning the value in an authorization reply. Please see the processor-specific details below.  #### Barclays and Streamline For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  #### Encoded Account Numbers For encoded account numbers (&#x60;card_ type&#x3D;039&#x60;), if there is no expiration date on the card, use &#x60;2021&#x60;.  #### FDC Nashville Global and FDMS South You can send in 2 digits or 4 digits. When you send in 2 digits, they must be the last 2 digits of the year.  #### Samsung Pay and Apple Pay Year in which the token expires. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  For processor-specific information, see the &#x60;customer_cc_expyr&#x60; or &#x60;token_expiration_year&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>One of two possible meanings: - The four-digit year in which a token expires. - The four-digit year in which a card expires. Format: &#x60;YYYY&#x60; Possible values: &#x60;1900&#x60; through &#x60;3000&#x60; Data type: Non-negative integer  **NOTE** The meaning of this field is dependent on the payment processor that is returning the value in an authorization reply. Please see the processor-specific details below.  #### Barclays and Streamline For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  #### Encoded Account Numbers For encoded account numbers (&#x60;card_ type&#x3D;039&#x60;), if there is no expiration date on the card, use &#x60;2021&#x60;.  #### FDC Nashville Global and FDMS South You can send in 2 digits or 4 digits. When you send in 2 digits, they must be the last 2 digits of the year.  #### Samsung Pay and Apple Pay Year in which the token expires. CyberSource includes this field in the reply message when it decrypts the payment blob for the tokenized transaction.  **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  For processor-specific information, see the &#x60;customer_cc_expyr&#x60; or &#x60;token_expiration_year&#x60; field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Customer’s payment network token value. 
        /// </summary>
        /// <value>Customer’s payment network token value. </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsetupsPaymentInformationTokenizedCard {\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsetupsPaymentInformationTokenizedCard);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsetupsPaymentInformationTokenizedCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsetupsPaymentInformationTokenizedCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsetupsPaymentInformationTokenizedCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionType == other.TransactionType ||
                    this.TransactionType != null &&
                    this.TransactionType.Equals(other.TransactionType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
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
                if (this.TransactionType != null)
                    hash = hash * 59 + this.TransactionType.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
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
            // TransactionType (string) maxLength
            if(this.TransactionType != null && this.TransactionType.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be less than or equal to 1.", new [] { "TransactionType" });
            }

            // ExpirationMonth (string) maxLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be less than or equal to 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationYear (string) maxLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length >= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be less than or equal to 4.", new [] { "ExpirationYear" });
            }

            // Number (string) maxLength
            if(this.Number != null && this.Number.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be less than or equal to 20.", new [] { "Number" });
            }

            yield break;
        }
    }

}
