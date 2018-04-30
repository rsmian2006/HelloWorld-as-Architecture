using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            string helloWorldTextFromWebApi = ReadFromWebApi();

            string writeToType = ConfigurationSettings.AppSettings.Get("WriteTo");

            IWrite writingTo = WriteToFactory.GetWriteToType(writeToType);

            string write = writingTo.Write(helloWorldTextFromWebApi);
        }

        private static string ReadFromWebApi()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var resp = client.GetAsync("api/HelloWorld/").Result;
            var result =  resp.Content.ReadAsStringAsync().Result;

            return result;
        }
    }

    public static class WriteToFactory
    {
        public static IWrite GetWriteToType(string writeToType)
        {
            IWrite writeType;
            Type type = Type.GetType(writeToType);
            writeType = (IWrite)Activator.CreateInstance(type);

            return writeType;
        }
    }
}
