using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace P4_Lab4_cz2
{
    public class Website
    {
        public Website(string domain,string path, Method method=Method.GET)
        {
            _restClient = new RestClient(domain);
            _restRequest = new RestRequest(path, method);
        }

        private RestClient _restClient;
        private RestRequest _restRequest;

        public async Task<string> Download()
        {
            var respone = await _restClient.ExecuteAsync(_restRequest);
            return respone.Content;
        }
    }
}
