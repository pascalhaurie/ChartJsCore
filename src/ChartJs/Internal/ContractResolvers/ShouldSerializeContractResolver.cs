using System;
using Newtonsoft.Json;
using System.Reflection;
using Newtonsoft.Json.Serialization;
using jamiewest.ChartJs.Options;
using jamiewest.ChartJs.Internal.Extensions;
using System.Linq;
using System.Collections.Generic;

namespace jamiewest.ChartJs.Internal.ContractResolvers
{
    public class ShouldSerializeContractResolver : DefaultContractResolver
    {
        public new static readonly ShouldSerializeContractResolver Instance = new ShouldSerializeContractResolver();

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            
            property.ShouldSerialize =
                instance =>
                {
                    if (property.GetType().GetTypeName() == "object")
                    {
                        dynamic e = (dynamic)instance;
                        var prop = e.GetType().GetProperty(property.UnderlyingName).GetValue(e, null);

                        if (HasNonEmptyNode(prop, instance) == false)
                        {
                            return false;
                        }
                    }

                    return true;
                };

            return property;
        }

        private bool HasNonEmptyNode(object Object, object instance)
        {
            Type objectType = Object.GetType();
            PropertyInfo[] properties = objectType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetType().GetTypeName() == "object")
                {
                    dynamic b = (dynamic)instance;
                    var prop = b.GetType().GetProperty(property.GetType()).GetValue(b, null);

                    if (IsEmptyNode(prop))
                    {
                        return true;
                    }

                    HasNonEmptyNode(property, instance);
                }
            }

            return false;
        }

        private bool IsEmptyNode(dynamic Object)
        {
            var result = JsonResult(Object);

            if (result == "{}")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string JsonResult(object Object)
        {
            var settings = new JsonSerializerSettings();

            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            
            return JsonConvert.SerializeObject(Object, settings);
        }
    }
}
