using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;

namespace ECharts
{
    /// <summary>
    /// Json Tools
    /// </summary>
    public class JsonTools
    {
 

        /// <summary>
        /// Generate Json string from the object
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Json String</returns>
        public static string ObjectToJson(object obj)
        {
            //System.Runtime.Serialization.Json.DataContractJsonSerializer;

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream stream = new MemoryStream();
            serializer.WriteObject(stream, obj);
            byte[] dataBytes = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(dataBytes, 0, (int)stream.Length);
            String dataString = Encoding.UTF8.GetString(dataBytes);
            return dataString;
        }

        /// <summary>
        /// Generate a object from Json string
        /// </summary>
        /// <param name="jsonString">Json string</param>
        /// <param name="obj">Object</param>
        /// <returns>Object</returns>
        public static object JsonToObject(string jsonString, object obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            obj = serializer.ReadObject(mStream);
            return obj;
        }

        /// <summary>
        /// Generate a object from Json string
        /// </summary>
        /// <param name="jsonString">Json string</param>
        /// <param name="obj">Object</param>
        /// <returns>Object</returns>
        public static T JsonToObject<T>(string jsonString)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                return (T)serializer.ReadObject(mStream);
            }
        }

        /// <summary>
        /// 序列化数据为Json数据格式.
        /// </summary>
        /// <param name="value">被序列化的对象</param>
        /// <returns></returns>
        public static string ObjectToJson2(object value)
        {
            return ObjectToJson2(value, false);
        }

        /// <summary>
        /// 序列化数据为Json数据格式.
        /// </summary>
        /// <param name="value">被序列化的对象</param>
        /// <param name="clearLastZero">是否清除小数位后的0</param>
        /// <returns></returns>
        public static string ObjectToJson2(object value, bool clearLastZero)
        {
            Type type = value.GetType();
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();
            //json.NullValueHandling = NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;           
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            
            json.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());           
            json.Formatting = Formatting.Indented;
            json.NullValueHandling = NullValueHandling.Ignore;
            if (clearLastZero)
                json.Converters.Add(new MinifiedNumArrayConverter());
            StringWriter sw = new StringWriter();
            Newtonsoft.Json.JsonTextWriter writer = new JsonTextWriter(sw);
            writer.Formatting = Formatting.None;
            writer.QuoteChar = '"';
            json.Serialize(writer, value);

            string output = sw.ToString();
            writer.Close();
            sw.Close();

            return output;
        }
        /// <summary>
        /// 将Json数据转为对象
        /// </summary>
        /// <typeparam name="T">目标对象</typeparam>
        /// <param name="jsonText">json数据字符串</param>
        /// <returns></returns>
        public static T JsonToObject2<T>(string jsonText)
        {
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();

            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            StringReader sr = new StringReader(jsonText);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            T result = default(T);
            try
            {
                result = (T)json.Deserialize(reader, typeof(T));
            }
            catch
            {
            }
            finally
            {
                reader.Close();
            }
            return result;
        }

        /// <summary>
        /// 普通集合转换Json
        /// </summary>
        /// <param name="array">集合对象</param>
        /// <returns>Json字符串</returns>
        public static string ListToJson(IEnumerable array)
        {

            string jsonString = "[";

            foreach (object item in array)
            {
                jsonString += ObjectToJson(item) + ",";
            }
            int t = jsonString.LastIndexOf(',');
            string strTmp = jsonString.Substring(0, t);
            return strTmp + "]";

        }


        /// <summary>   
        /// DataTable to json   
        /// </summary>   
        /// <param name="jsonName">返回json的名称</param>   
        /// <param name="dt">转换成json的表</param>   
        /// <returns></returns>   
        public string DataTableToJson(string jsonName, System.Data.DataTable dt, string strTotal = "")
        {
            StringBuilder Json = new StringBuilder();
            Json.Append("[{\"TotalCount\":\"" + strTotal + "\",\"Head\":[");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                Json.Append("{\"ColumnHead\":\"" + dt + dt.Columns[i].ColumnName + "\"}");

                if (i < dt.Columns.Count - 1)
                {
                    Json.Append(",");
                }
            }
            Json.Append("],");

            Json.Append("\"" + jsonName + "\":[");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Json.Append("{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Json.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":\"" + dt.Rows[i][j].ToString() + "\"");
                        if (j < dt.Columns.Count - 1)
                        {
                            Json.Append(",");
                        }
                    }
                    Json.Append("}");
                    if (i < dt.Rows.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("]}]");
            return Json.ToString();
        }


        public class MinifiedNumArrayConverter : JsonConverter
        {
            private void dumpNumArray<T>(JsonWriter writer, T[] array)
            {
                foreach (T n in array)
                {
                    var s = n.ToString();
                    //此處可考慮改用string.format("{0:#0.####}")[小數後方#數目依最大小數位數決定]
                    //感謝網友vencin提供建議
                    if (s.EndsWith(".0"))
                        writer.WriteRawValue(s.Substring(0, s.Length - 2));
                    else if (s.Contains("."))
                        writer.WriteRawValue(s.TrimEnd('0'));
                    else
                        writer.WriteRawValue(s);
                }
            }

            private void dumpNum<T>(JsonWriter writer, T value)
            {
                var s = value.ToString();
                //此處可考慮改用string.format("{0:#0.####}")[小數後方#數目依最大小數位數決定]
                //感謝網友vencin提供建議
                if (s.EndsWith(".0"))
                    writer.WriteRawValue(s.Substring(0, s.Length - 2));
                else if (s.Contains("."))
                    writer.WriteRawValue(s.TrimEnd('0'));
                else
                    writer.WriteRawValue(s);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                Type t = value.GetType();
                if (t == dblArrayType)
                {
                    writer.WriteStartArray();
                    dumpNumArray<double>(writer, (double[])value);
                    writer.WriteEndArray();
                }
                else if (t == decArrayType)
                {
                    writer.WriteStartArray();
                    dumpNumArray<decimal>(writer, (decimal[])value);
                    writer.WriteEndArray();
                }
                else if (t == decType || t == decNullType)
                {
                    dumpNum<decimal>(writer, (decimal)value);
                }
                else
                    throw new NotImplementedException();
            }

            private Type dblArrayType = typeof(double[]);
            private Type decArrayType = typeof(decimal[]);
            private Type decType = typeof(decimal);
            private Type decNullType = typeof(decimal?);

            public override bool CanConvert(Type objectType)
            {
                if (objectType == dblArrayType || objectType == decArrayType || objectType == decType || objectType == decNullType)
                    return true;
                return false;
            }

            public override bool CanRead
            {
                get { return false; }
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }

}