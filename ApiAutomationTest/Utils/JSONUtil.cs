using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SeleniumAutomationTest.Utils
{
    public class JSONUtil
    {
        public static void WriteToJsonFile(string json, string filePath)
        {
            File.WriteAllText(filePath, json);
        }
        public static void WriteObjectToJsonFile(object obj, string filePath)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static T ReadFromJsonFile<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
