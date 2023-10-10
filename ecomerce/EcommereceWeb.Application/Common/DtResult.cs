using System.Text.Json.Serialization;

namespace EcommereceWeb.Application.Common
{
    public class DtResult
    {
      
        public int drew { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        [JsonPropertyName("searchValue")]
        public string searchValue { get; set; }
    }
}
