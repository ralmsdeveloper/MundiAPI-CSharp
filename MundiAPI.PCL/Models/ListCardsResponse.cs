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
    public class ListCardsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.GetCreditCardResponse> data;
        private Models.PagingResponse paging;

        /// <summary>
        /// The card objects
        /// </summary>
        [JsonProperty("data")]
        public List<Models.GetCreditCardResponse> Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Paging object
        /// </summary>
        [JsonProperty("paging")]
        public Models.PagingResponse Paging 
        { 
            get 
            {
                return this.paging; 
            } 
            set 
            {
                this.paging = value;
                onPropertyChanged("Paging");
            }
        }
    }
} 