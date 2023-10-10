using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Common
{
    public class MessageResult
    {

        public string message { get; set; }
        public int code { get; set; }
        public bool Succeeded { get; set; }
    }
}
