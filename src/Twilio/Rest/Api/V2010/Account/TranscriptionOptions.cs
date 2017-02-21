using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// Fetch and instance of a Transcription
    /// </summary>
    public class FetchTranscriptionOptions : IOptions<TranscriptionResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique transcription Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchTranscriptionOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique transcription Sid </param>
        public FetchTranscriptionOptions(string pathSid)
        {
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
    /// Delete a transcription from the account used to make the request
    /// </summary>
    public class DeleteTranscriptionOptions : IOptions<TranscriptionResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Delete by unique transcription Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteTranscriptionOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Delete by unique transcription Sid </param>
        public DeleteTranscriptionOptions(string pathSid)
        {
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
    /// Retrieve a list of transcriptions belonging to the account used to make the request
    /// </summary>
    public class ReadTranscriptionOptions : ReadOptions<TranscriptionResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
    
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

}