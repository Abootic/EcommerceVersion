
using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class TaxConfigurationViewDto
    {
  
        public int Id { get; set; }
        public string TaxNumber { get; set; }
        public string Value { get; set; }
        public string? type { get; set; }

    } 
     public class TaxConfigurationDto
    {
        [Required]
        public int Id { get; set; }
        public string TaxNumber { get; set; }
        public string Value { get; set; }
        public string? type { get; set; }

    } 

}
