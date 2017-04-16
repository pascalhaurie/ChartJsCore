using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace jamiewest.ChartJs.Utilities
{
    public class SingleOrArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IList<T>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            /// In C# 2.0 and later, single-dimensional arrays that have a lower bound of zero
            /// automatically implement IList<T>.
            IList<T> list = (IList<T>)value;
            if (list.Count == 1)
            {
                
                value = list[0];
            }
            serializer.Serialize(writer, value);
        }


    }
}
