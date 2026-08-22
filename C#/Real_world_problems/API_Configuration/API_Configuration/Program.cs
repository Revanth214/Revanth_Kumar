using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Configuration
{
    class ApiClient
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; private set; }
        public void SetApiKey(string key)
        {
            ApiKey = key;
        }
        public string GetMaskedApiKey()
        {
            return "*****"+ApiKey.Substring(ApiKey.Length-4);
        }
        public void SendRequest()
        {
            Console.WriteLine("Sending request to: "+ BaseUrl);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ApiClient obj = new ApiClient();
            obj.BaseUrl = "http//chatgpt.com.";
            obj.SetApiKey("1234567894");
            Console.WriteLine(obj.GetMaskedApiKey());
            obj.SendRequest();
            Console.ReadLine();
        }
    }
}
