using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Pricing.V1.Voice 
{

    /// <summary>
    /// NumberResource
    /// </summary>
    public class NumberResource : Resource 
    {
        private static Request BuildFetchRequest(FetchNumberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Pricing,
                "/v1/Voice/Numbers/" + options.PathNumber + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Number parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Number </returns> 
        public static NumberResource Fetch(FetchNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Number parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Number </returns> 
        public static async System.Threading.Tasks.Task<NumberResource> FetchAsync(FetchNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathNumber"> The number </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Number </returns> 
        public static NumberResource Fetch(Types.PhoneNumber pathNumber, ITwilioRestClient client = null)
        {
            var options = new FetchNumberOptions(pathNumber);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathNumber"> The number </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Number </returns> 
        public static async System.Threading.Tasks.Task<NumberResource> FetchAsync(Types.PhoneNumber pathNumber, ITwilioRestClient client = null)
        {
            var options = new FetchNumberOptions(pathNumber);
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NumberResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NumberResource object represented by the provided JSON </returns> 
        public static NumberResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<NumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The number
        /// </summary>
        [JsonProperty("number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber Number { get; private set; }
        /// <summary>
        /// The country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; private set; }
        /// <summary>
        /// The iso_country
        /// </summary>
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }
        /// <summary>
        /// The outbound_call_price
        /// </summary>
        [JsonProperty("outbound_call_price")]
        public OutboundCallPrice OutboundCallPrice { get; private set; }
        /// <summary>
        /// The inbound_call_price
        /// </summary>
        [JsonProperty("inbound_call_price")]
        public InboundCallPrice InboundCallPrice { get; private set; }
        /// <summary>
        /// The price_unit
        /// </summary>
        [JsonProperty("price_unit")]
        public string PriceUnit { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private NumberResource()
        {
        
        }
    }

}