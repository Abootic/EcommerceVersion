using EcommereceWeb.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Common
{
    public class CustomConventer: ICustomConventer
    {
        public string EncodeJson(object obj)
        {

            return JsonSerializer.Serialize(obj);
        }

        public T DecodeJson<T>(string json) where T : class
        {


            return JsonSerializer.Deserialize<T>(json); ;
        }
    }
}
