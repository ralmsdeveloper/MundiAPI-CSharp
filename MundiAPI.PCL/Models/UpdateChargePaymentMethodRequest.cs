/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;

namespace MundiAPI.PCL.Models
{
    public class UpdateChargePaymentMethodRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool updateSubscription;
        private string paymentMethod;
        private Models.CreateCreditCardPaymentRequest creditCard;
        private Models.CreateBoletoPaymentRequest boleto;

        /// <summary>
        /// Indicates if the payment method from the subscription must also be updated
        /// </summary>
        [JsonProperty("update_subscription")]
        public bool UpdateSubscription 
        { 
            get 
            {
                return this.updateSubscription; 
            } 
            set 
            {
                this.updateSubscription = value;
                onPropertyChanged("UpdateSubscription");
            }
        }

        /// <summary>
        /// The new payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// Credit card data
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCreditCardPaymentRequest CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// Boleto data
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateBoletoPaymentRequest Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }
    }
} 