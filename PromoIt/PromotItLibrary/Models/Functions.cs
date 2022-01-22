using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
