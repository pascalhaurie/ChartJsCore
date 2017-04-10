using Newtonsoft.Json;
using System.Reflection;
using Newtonsoft.Json.Serialization;
using jamiewest.ChartJs.Options;

namespace jamiewest.ChartJs.ContractResolvers
{
    public class ShouldSerializeContractResolver : DefaultContractResolver
    {
        public new static readonly ShouldSerializeContractResolver Instance = new ShouldSerializeContractResolver();

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "tooltip")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Tooltip);
                        
                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "title")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Title);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "legend")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Legend);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "layout")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Layout);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "hover")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Hover);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "animation")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Animation);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ElementOptions) && property.PropertyName == "arc")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ElementOptions e = (ElementOptions)instance;

                        var result = JsonResult(e.Arc);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ElementOptions) && property.PropertyName == "lines")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ElementOptions e = (ElementOptions)instance;

                        var result = JsonResult(e.Lines);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if(property.DeclaringType == typeof(ElementOptions) && property.PropertyName == "points")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ElementOptions e = (ElementOptions)instance;

                        var result = JsonResult(e.Points);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ElementOptions) && property.PropertyName == "rectangles")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ElementOptions e = (ElementOptions)instance;

                        var result = JsonResult(e.Rectangles);

                        if (result == "{}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            if (property.DeclaringType == typeof(ChartOptions) && property.PropertyName == "elements")
            {
                property.ShouldSerialize =
                    instance =>
                    {
                        ChartOptions e = (ChartOptions)instance;

                        var result = JsonResult(e.Elements);

                        if (result == "{\"arc\":{},\"lines\":{},\"points\":{},\"rectangles\":{}}")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    };
            }

            return property;
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
