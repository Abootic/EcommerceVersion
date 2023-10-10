using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface ICustomConventer
    {
        public string EncodeJson(object obj);
        public T DecodeJson<T>(string json) where T : class;
    }
}
