using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Trunking.V1.Trunk 
{

    /// <summary>
    /// OriginationUrlResource
    /// </summary>
    public class OriginationUrlResource : Resource 
    {
        private static Request BuildFetchRequest(FetchOriginationUrlOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathTrunkSid + "/OriginationUrls/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static OriginationUrlResource Fetch(FetchOriginationUrlOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<OriginationUrlResource> FetchAsync(FetchOriginationUrlOptions options, ITwilioRestClient client = null)
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
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static OriginationUrlResource Fetch(string pathTrunkSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchOriginationUrlOptions(pathTrunkSid, pathSid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<OriginationUrlResource> FetchAsync(string pathTrunkSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchOriginationUrlOptions(pathTrunkSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteOriginationUrlOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathTrunkSid + "/OriginationUrls/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static bool Delete(DeleteOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static bool Delete(string pathTrunkSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteOriginationUrlOptions(pathTrunkSid, pathSid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathTrunkSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteOriginationUrlOptions(pathTrunkSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateOriginationUrlOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathTrunkSid + "/OriginationUrls",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static OriginationUrlResource Create(CreateOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<OriginationUrlResource> CreateAsync(CreateOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="weight"> The weight </param>
        /// <param name="priority"> The priority </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="sipUrl"> The sip_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static OriginationUrlResource Create(string pathTrunkSid, int? weight, int? priority, bool? enabled, string friendlyName, Uri sipUrl, ITwilioRestClient client = null)
        {
            var options = new CreateOriginationUrlOptions(pathTrunkSid, weight, priority, enabled, friendlyName, sipUrl);
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="weight"> The weight </param>
        /// <param name="priority"> The priority </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="sipUrl"> The sip_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<OriginationUrlResource> CreateAsync(string pathTrunkSid, int? weight, int? priority, bool? enabled, string friendlyName, Uri sipUrl, ITwilioRestClient client = null)
        {
            var options = new CreateOriginationUrlOptions(pathTrunkSid, weight, priority, enabled, friendlyName, sipUrl);
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadOriginationUrlOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathTrunkSid + "/OriginationUrls",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static ResourceSet<OriginationUrlResource> Read(ReadOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<OriginationUrlResource>.FromJson("origination_urls", response.Content);
            return new ResourceSet<OriginationUrlResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<OriginationUrlResource>> ReadAsync(ReadOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<OriginationUrlResource>.FromJson("origination_urls", response.Content);
            return new ResourceSet<OriginationUrlResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static ResourceSet<OriginationUrlResource> Read(string pathTrunkSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadOriginationUrlOptions(pathTrunkSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<OriginationUrlResource>> ReadAsync(string pathTrunkSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadOriginationUrlOptions(pathTrunkSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<OriginationUrlResource> NextPage(Page<OriginationUrlResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Trunking,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<OriginationUrlResource>.FromJson("origination_urls", response.Content);
        }
    
        private static Request BuildUpdateRequest(UpdateOriginationUrlOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathTrunkSid + "/OriginationUrls/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static OriginationUrlResource Update(UpdateOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update OriginationUrl parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<OriginationUrlResource> UpdateAsync(UpdateOriginationUrlOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="weight"> The weight </param>
        /// <param name="priority"> The priority </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="sipUrl"> The sip_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OriginationUrl </returns> 
        public static OriginationUrlResource Update(string pathTrunkSid, string pathSid, int? weight = null, int? priority = null, bool? enabled = null, string friendlyName = null, Uri sipUrl = null, ITwilioRestClient client = null)
        {
            var options = new UpdateOriginationUrlOptions(pathTrunkSid, pathSid){Weight = weight, Priority = priority, Enabled = enabled, FriendlyName = friendlyName, SipUrl = sipUrl};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="weight"> The weight </param>
        /// <param name="priority"> The priority </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="sipUrl"> The sip_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OriginationUrl </returns> 
        public static async System.Threading.Tasks.Task<OriginationUrlResource> UpdateAsync(string pathTrunkSid, string pathSid, int? weight = null, int? priority = null, bool? enabled = null, string friendlyName = null, Uri sipUrl = null, ITwilioRestClient client = null)
        {
            var options = new UpdateOriginationUrlOptions(pathTrunkSid, pathSid){Weight = weight, Priority = priority, Enabled = enabled, FriendlyName = friendlyName, SipUrl = sipUrl};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a OriginationUrlResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> OriginationUrlResource object represented by the provided JSON </returns> 
        public static OriginationUrlResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<OriginationUrlResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The trunk_sid
        /// </summary>
        [JsonProperty("trunk_sid")]
        public string TrunkSid { get; private set; }
        /// <summary>
        /// The weight
        /// </summary>
        [JsonProperty("weight")]
        public int? Weight { get; private set; }
        /// <summary>
        /// The enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// The sip_url
        /// </summary>
        [JsonProperty("sip_url")]
        public Uri SipUrl { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The priority
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private OriginationUrlResource()
        {
        
        }
    }

}