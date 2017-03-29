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
    public class UpdateSubscriptionCreditCardRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.CreateCreditCardRequest creditCard;
        private string creditCardId;
        private string creditCardGatewayId;

        /// <summary>
        /// Credit card data
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCreditCardRequest CreditCard 
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
        /// Credit card id
        /// </summary>
        [JsonProperty("credit_card_id")]
        public string CreditCardId 
        { 
            get 
            {
                return this.creditCardId; 
            } 
            set 
            {
                this.creditCardId = value;
                onPropertyChanged("CreditCardId");
            }
        }

        /// <summary>
        /// Credit card gateway id
        /// </summary>
        [JsonProperty("credit_card_gateway_id")]
        public string CreditCardGatewayId 
        { 
            get 
            {
                return this.creditCardGatewayId; 
            } 
            set 
            {
                this.creditCardGatewayId = value;
                onPropertyChanged("CreditCardGatewayId");
            }
        }
    }
} 