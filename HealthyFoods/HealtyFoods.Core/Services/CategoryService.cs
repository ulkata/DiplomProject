﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthyFoods.Infrastructure.Data;
using HealthyFoods.Infrastructure.Data.Domain;

using HealtyFoods.Core.Contracts;

namespace HealtyFoods.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products
                  .Where(x => x.CategoryId == categoryId)
              .ToList();
        }
        public bool Create(string categoryName)
        {
            Category item = new Category()
            {
                CategoryName = categoryName

            };
            _context.Categories.Add(item);
            return _context.SaveChanges() != 0;
        }
    }
}
