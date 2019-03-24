namespace Shop.Web.Data
{
    using Entities;

    public class IProductRepository : GenericRepository<Product>, IProductRepository
    {
        public IProductRepository(DataContext context) : base(context)
        {
        }
    }

}
