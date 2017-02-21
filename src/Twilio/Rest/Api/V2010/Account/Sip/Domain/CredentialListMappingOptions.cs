using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain 
{

    /// <summary>
    /// CreateCredentialListMappingOptions
    /// </summary>
    public class CreateCredentialListMappingOptions : IOptions<CredentialListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string CredentialListSid { get; }
    
        /// <summary>
        /// Construct a new CreateCredentialListMappingOptions
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="credentialListSid"> The credential_list_sid </param>
        public CreateCredentialListMappingOptions(string pathDomainSid, string credentialListSid)
        {
            PathDomainSid = pathDomainSid;
            CredentialListSid = credentialListSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CredentialListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CredentialListSid", CredentialListSid.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// ReadCredentialListMappingOptions
    /// </summary>
    public class ReadCredentialListMappingOptions : ReadOptions<CredentialListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
    
        /// <summary>
        /// Construct a new ReadCredentialListMappingOptions
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        public ReadCredentialListMappingOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// FetchCredentialListMappingOptions
    /// </summary>
    public class FetchCredentialListMappingOptions : IOptions<CredentialListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchCredentialListMappingOptions
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchCredentialListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteCredentialListMappingOptions
    /// </summary>
    public class DeleteCredentialListMappingOptions : IOptions<CredentialListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteCredentialListMappingOptions
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteCredentialListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}