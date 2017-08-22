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
    public class CreateSubscriptionRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.CreateCustomerRequest customer;
        private Models.CreateCardRequest card;
        private string code;
        private string paymentMethod;
        private string billingType;
        private string statementDescriptor;
        private string description;
        private string currency;
        private string interval;
        private int intervalCount;
        private Models.CreatePricingSchemeRequest pricingScheme;
        private List<Models.CreateSubscriptionItemRequest> items;
        private Models.CreateShippingRequest shipping;
        private List<Models.CreateDiscountRequest> discounts;
        private Dictionary<string, string> metadata;
        private Models.CreateSetupRequest setup;
        private string planId;
        private string customerId;
        private string cardId;
        private int? billingDay;
        private int? installments;
        private DateTime? startAt;
        private int? minimumPrice;
        private int? cycles;
        private string cardToken;

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer 
        { 
            get 
            {
                return this.customer; 
            } 
            set 
            {
                this.customer = value;
                onPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// Card
        /// </summary>
        [JsonProperty("card")]
        public Models.CreateCardRequest Card 
        { 
            get 
            {
                return this.card; 
            } 
            set 
            {
                this.card = value;
                onPropertyChanged("Card");
            }
        }

        /// <summary>
        /// Subscription code
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// Payment method
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
        /// Billing type
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType 
        { 
            get 
            {
                return this.billingType; 
            } 
            set 
            {
                this.billingType = value;
                onPropertyChanged("BillingType");
            }
        }

        /// <summary>
        /// Statement descriptor for credit card subscriptions
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Subscription description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty("interval")]
        public string Interval 
        { 
            get 
            {
                return this.interval; 
            } 
            set 
            {
                this.interval = value;
                onPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// Interval count
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount 
        { 
            get 
            {
                return this.intervalCount; 
            } 
            set 
            {
                this.intervalCount = value;
                onPropertyChanged("IntervalCount");
            }
        }

        /// <summary>
        /// Subscription pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme 
        { 
            get 
            {
                return this.pricingScheme; 
            } 
            set 
            {
                this.pricingScheme = value;
                onPropertyChanged("PricingScheme");
            }
        }

        /// <summary>
        /// Subscription items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreateSubscriptionItemRequest> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// Shipping
        /// </summary>
        [JsonProperty("shipping")]
        public Models.CreateShippingRequest Shipping 
        { 
            get 
            {
                return this.shipping; 
            } 
            set 
            {
                this.shipping = value;
                onPropertyChanged("Shipping");
            }
        }

        /// <summary>
        /// Discounts
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.CreateDiscountRequest> Discounts 
        { 
            get 
            {
                return this.discounts; 
            } 
            set 
            {
                this.discounts = value;
                onPropertyChanged("Discounts");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// Setup data
        /// </summary>
        [JsonProperty("setup")]
        public Models.CreateSetupRequest Setup 
        { 
            get 
            {
                return this.setup; 
            } 
            set 
            {
                this.setup = value;
                onPropertyChanged("Setup");
            }
        }

        /// <summary>
        /// Plan id
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId 
        { 
            get 
            {
                return this.planId; 
            } 
            set 
            {
                this.planId = value;
                onPropertyChanged("PlanId");
            }
        }

        /// <summary>
        /// Customer id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId 
        { 
            get 
            {
                return this.customerId; 
            } 
            set 
            {
                this.customerId = value;
                onPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId 
        { 
            get 
            {
                return this.cardId; 
            } 
            set 
            {
                this.cardId = value;
                onPropertyChanged("CardId");
            }
        }

        /// <summary>
        /// Billing day
        /// </summary>
        [JsonProperty("billing_day")]
        public int? BillingDay 
        { 
            get 
            {
                return this.billingDay; 
            } 
            set 
            {
                this.billingDay = value;
                onPropertyChanged("BillingDay");
            }
        }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments")]
        public int? Installments 
        { 
            get 
            {
                return this.installments; 
            } 
            set 
            {
                this.installments = value;
                onPropertyChanged("Installments");
            }
        }

        /// <summary>
        /// Subscription start date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime? StartAt 
        { 
            get 
            {
                return this.startAt; 
            } 
            set 
            {
                this.startAt = value;
                onPropertyChanged("StartAt");
            }
        }

        /// <summary>
        /// Subscription minimum price
        /// </summary>
        [JsonProperty("minimum_price")]
        public int? MinimumPrice 
        { 
            get 
            {
                return this.minimumPrice; 
            } 
            set 
            {
                this.minimumPrice = value;
                onPropertyChanged("MinimumPrice");
            }
        }

        /// <summary>
        /// Number of cycles
        /// </summary>
        [JsonProperty("cycles")]
        public int? Cycles 
        { 
            get 
            {
                return this.cycles; 
            } 
            set 
            {
                this.cycles = value;
                onPropertyChanged("Cycles");
            }
        }

        /// <summary>
        /// Card token
        /// </summary>
        [JsonProperty("card_token")]
        public string CardToken 
        { 
            get 
            {
                return this.cardToken; 
            } 
            set 
            {
                this.cardToken = value;
                onPropertyChanged("CardToken");
            }
        }
    }
} 