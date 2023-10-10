using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;


namespace EcommereceWeb.Infrstraction.Repositories
{
    public class ProductAttributeRepository : GenirecRopoistories<ProductAttribute>, IProductAttributeRepository
    {
        public ProductAttributeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
      
        public List<List<ProductAttribute>> GetListVarationData(int productId)
        {  
            var res = _dbContext.ProductAttribute.Where(a => a.ProductId == productId).AsEnumerable().GroupBy(a => a.AttributeId);
            var attributeLists = new List<List<ProductAttribute>>();
            if (res.Any())
            {
                foreach (var i in res)
                {
                    foreach (var item in i)
                    {
                        Console.WriteLine($"fffffffffffffffffffffffffff  {item.Name}");
                    }

                    attributeLists.Add(i.ToList());



                }
            }
            else
            {
                Console.WriteLine($"kiiiiiiiiiiiiiiiiiiiiii");
            }
           
            return attributeLists;
        }
    }

}
