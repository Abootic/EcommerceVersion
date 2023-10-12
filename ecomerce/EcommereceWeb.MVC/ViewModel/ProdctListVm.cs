namespace EcommereceWeb.MVC.ViewModel
{
	public class ProdctListVm
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public String image { get; set; }
		public string description { get; set; }
		public decimal? discount { get; set; }
	}
}
