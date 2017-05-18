using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ormico.WebApi406.WebSvcTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait for WebSite to start.");
            Console.WriteLine("Press any key to begin Test>");
            Console.ReadKey();
            RunTest();
            Console.WriteLine("Press any key to close>");
            Console.ReadKey();
        }

        static void RunTest()
        {
            try
            {
                HttpClient client = new HttpClient();
                var appSettings = ConfigurationManager.AppSettings;
                string url = appSettings["url"];
                Uri fullUrl = new Uri(url + "/api/example");

                Console.WriteLine($"full url: {fullUrl}");

                var responseTask = client.PostAsync(fullUrl, new StringContent("<?xml version=\"1.0\"?>\n<blah>a</blah>"));
                responseTask.Wait();
                var response = responseTask.Result;

                Console.WriteLine($"Response Status Code: {(int)response.StatusCode} {response.StatusCode}");
                var responseContentTask = response.Content.ReadAsStringAsync();
                responseContentTask.Wait();
                string responseString = responseContentTask.Result;

                Console.WriteLine("Response Text:");
                Console.WriteLine(responseString);
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine($"WebException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
