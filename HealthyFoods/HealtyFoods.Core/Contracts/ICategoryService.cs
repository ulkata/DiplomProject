using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthyFoods.Infrastructure.Data.Domain;

namespace HealtyFoods.Core.Contracts
{
    public interface ICategoryService
    {
        bool Create(string categoryName);
        List<Category> GetCategories();
        Category GetCategoryById(int categoryId);
        List<Product> GetProductsByCategory(int categoryId);
    }
}
