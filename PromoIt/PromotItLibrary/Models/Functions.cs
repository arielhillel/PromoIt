using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PromotItLibrary.Models
{
    public struct Functions
    {
        public static Dictionary<string, string> PostMessageSplit(string requestBody) 
            => requestBody.Split(',').Select(value => value.Split('=')).ToDictionary(pair => pair[0], pair => pair[1]);
        public static string ObjectToJsonString<T>(T data) => Newtonsoft.Json.JsonConvert.SerializeObject(data);
        public static T JsonStringToSingleObject<T>(string mycontent) => JsonConvert.DeserializeObject<T>(mycontent);
        public static List<T> JsonStringToObjectList<T>(string mycontent) => JsonConvert.DeserializeObject<List<T>>(mycontent);
        public static string HttpUrlDecode(string data) => Uri.UnescapeDataString(data);




        public async static Task<bool?> PostSingleDataRequest<T>(string postFolder, T obj)
        {
            string objString = Functions.ObjectToJsonString(obj);

            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("data", objString)
                };


            var mycontent = await PostRequest(postFolder, queries);
            try
            {
                if (mycontent == "ok") return true;
                else if (mycontent == "fail") return false;
                throw new Exception(mycontent);
            }
            catch (Exception ex) { Console.WriteLine(ex); throw new Exception("Fail to add a content: " + ex); }

        }


        public async static Task<string> PostRequest(string postFolder, IEnumerable<KeyValuePair<string, string>> queries) // another check method 
        {

            using HttpContent q = new FormUrlEncodedContent(queries);
            using HttpResponseMessage response = await (Configuration.HttpClient).PostAsync(Configuration.FunctionUrl + postFolder, q);
            using HttpContent content = response.Content;
            //Response
            string mycontent = await content.ReadAsStringAsync();
            return mycontent;
        }



        public async static Task<T> GetSingleDataRequest<T>(string getFolder, T obj)
        {
            string objString = Functions.ObjectToJsonString(obj);
            string getRequest = "?data=" + objString;
            //Response
            string mycontent = await GetRequest(getFolder, getRequest);
            try
            {
                T t = Functions.JsonStringToSingleObject<T>(mycontent);
                return t;
            }
            catch { Console.WriteLine(mycontent); throw new Exception(mycontent); }
        }

        public async static Task<string> GetRequest(string getFolder, string getRequest)
        {
            Configuration.HttpClient = new HttpClient();
            using HttpResponseMessage response = await (Configuration.HttpClient).GetAsync(Configuration.FunctionUrl + getFolder + getRequest);
            using HttpContent content = response.Content;
            //Response
            string mycontent = await content.ReadAsStringAsync();
            return mycontent;
        }

    }
}
