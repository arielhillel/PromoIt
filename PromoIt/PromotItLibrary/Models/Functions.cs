using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using Tweetinvi;
using Tweetinvi.Parameters;
using System.Threading;
using PromotItLibrary.Classes;

namespace PromotItLibrary.Models
{
    public struct Functions
    {
        public static Dictionary<string, string> PostMessageSplit(string requestBody) 
            => requestBody.Split('&').Select(value => value.Split('=')).ToDictionary(pair => pair[0], pair => pair[1]);
        public static string ObjectToJsonString<T>(T data) => Newtonsoft.Json.JsonConvert.SerializeObject(data);
        public static T JsonStringToSingleObject<T>(string mycontent) => JsonConvert.DeserializeObject<T>(mycontent);
        public static List<T> JsonStringToObjectList<T>(string mycontent) => JsonConvert.DeserializeObject<List<T>>(mycontent);
        public static string HttpUrlDecode(string data) => HttpUtility.UrlDecode(data);

        private static TwitterClient twitterUserClient = Configuration.TwitterUserClient;


        //Twitter Message
        public static async Task SetTwitterMessage_SetBuyAnItemAsync(string message)
            => await twitterUserClient.Tweets.PublishTweetAsync( new PublishTweetParameters { Text = message, } );


        //Post
        public async static Task<bool?> PostSingleDataInsert<T>(string postUrl, T obj, string type = "")
        {
            string objString = ObjectToJsonString(obj);
            string mycontent = await PostStringRequest(postUrl, objString, type);
            try
            {
                if (mycontent == "ok") return true;
                else if (mycontent == "fail") return false;
                throw new Exception(mycontent);
            }
            catch { Loggings.ErrorLog($"PostSingleDataInsert Fail"); throw new Exception("Fail to post a content: \n" + mycontent); }
        }
        public async static Task<T> PostSingleDataRequest<T>(string postUrl, T obj, string type = "")
        {
            string objString = ObjectToJsonString(obj);
            string mycontent = await PostStringRequest(postUrl, objString, type);
            try { return JsonStringToSingleObject<T>(mycontent);}
            catch { Loggings.ErrorLog($"PostSingleDataRequest Fail"); throw new Exception("Fail to add a content: \n" + mycontent); }
        }
        //public async static Task<string> PostStringRequest<T>(string postUrl, T obj, string type = "")
        //{
        //    string objString = ObjectToJsonString(obj);
        //    return await PostStringRequest(postUrl, objString, type);
        //}
        public async static Task<string> PostStringRequest(string postUrl, string objString, string type = "")
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("type", type),
                new KeyValuePair<string, string>("data", objString)
            };
            return await PostRequest(postUrl, queries);
        }
        public async static Task<string> PostRequest(string postUrl, IEnumerable<KeyValuePair<string, string>> queries) // another check method 
        {
            using HttpContent q = new FormUrlEncodedContent(queries);
            using HttpResponseMessage response = await (Configuration.HttpClient).PostAsync(postUrl, q);
            using HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();   //Response
            return mycontent;
        }
        //Get
        public async static Task<List<T>> GetMultipleDataRequest<T>(string getUrl, T obj, string type = "")
        {
            string objString = ObjectToJsonString(obj);
            string mycontent = await GetStringRequest(getUrl, objString, type); //Response
            try { return JsonStringToSingleObject<List<T>>(mycontent); }
            catch { Loggings.ErrorLog($"GetMultipleDataRequest Fail"); throw new Exception("Fail to get a content: \n" + mycontent);  }
        }
        public async static Task<T> GetSingleDataRequest<T>(string getUrl, T obj, string type = "")
        {
            string objString = ObjectToJsonString(obj);
            string mycontent = await GetStringRequest(getUrl, objString, type);
            try { return JsonStringToSingleObject<T>(mycontent); }
            catch { Loggings.ErrorLog($"GetMultipleDataRequest Fail");  throw new Exception("Fail to get a content: \n" + mycontent); }
        }
        //public async static Task<string> GetStringRequest<T>(string getUrl, T obj, string type = "")
        //{
        //    string objString = ObjectToJsonString(obj);
        //    return await GetStringRequest(getUrl, objString, type); //Response
        //}
        public async static Task<string> GetStringRequest(string getUrl, string objString, string type = "")
        {
            string getRequest = "type=" + type + "&data=" + objString;
            if (Configuration.LocalMode == Modes.Local) getRequest = "?" + getRequest;
            else if (Configuration.LocalMode == Modes.NotLocal) getRequest = "&" + getRequest;
            else throw new Exception("Single Get Reguest wrong, Local Mode not set");
            return await GetRequest(getUrl, getRequest); //Response
        }
        public async static Task<string> GetRequest(string getUrl, string getRequest)
        {
            Configuration.HttpClient = new HttpClient();
            using HttpResponseMessage response = await (Configuration.HttpClient).GetAsync(getUrl + getRequest);
            using HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();   //Response
            return mycontent;
        }

    }
}
