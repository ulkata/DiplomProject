using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthyFoods.Infrastructure.Data;

using HealtyFoods.Core.Contracts;

namespace HealtyFoods.Core.Services
{
    public class StatisticService : IStatisticService

    {
        private readonly ApplicationDbContext _context;

        public StatisticService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int CountClients()
        {
            return _context.Users.Count() - 1;
        }

        public int CountOrders()
        {
            return _context.Orders.Count();
        }

        public int CountProducts()
        {
            return _context.Products.Count();
        }

        public decimal SumOrders()
        {
            var suma = _context.Orders.Sum(x => x.CountOfProducts * x.Price - x.CountOfProducts * x.Price * x.Discount / 100);
            return suma;
        }
    }
}
