using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthyFoods.Infrastructure.Data.Domain;

namespace HealtyFoods.Core.Contracts
{
    public interface IProductService
    {
        bool Create(string name, int categoryId ,string ingredients, string description, string picture, int quantity, decimal price, decimal discount);

        bool Update(int productId, string name, int categoryId, string ingredients, string description, string picture, int quantity, decimal price, decimal discount);

        List<Product> GetProducts();

        Product GetProductById(int productId);

        bool RemoveById(int productId);

        List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandName);
    }
}
