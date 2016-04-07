using FoodGuard.DAL.Entities;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FoodGuard.Business
{
    public class ProductBusiness
    {
        BaseDapperRepository<Product> ProductRepository = DependencyServiceInjection.Resolve<BaseDapperRepository<Product>>();


        public IEnumerable<Product> GetAllProducts()
        {
            return ProductRepository.GetAll();
        }

        public List<Product> GetProductsByTypeId(int typeId)
        {
            List<Product> products = ProductRepository.ExecuteQuery<Product>(Constants.GetProductsByType,
                           new
                           {
                               typeId = typeId
                           },
                           CommandType.StoredProcedure).ToList();

            return products;
        }
    }
}
