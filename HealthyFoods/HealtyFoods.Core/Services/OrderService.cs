using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HealthyFoods.Infrastructure.Data;
using HealthyFoods.Infrastructure.Data.Domain;

using HealtyFoods.Core.Contracts;

namespace HealtyFoods.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(int productId, string userId, int quantity, string adressDelivery)
        {
            
            var product = this._context.Products.SingleOrDefault(x => x.Id == productId);

            
            if (product == null)
            {
                return false;
            }

            
            Order item = new Order
            {
                DateOrder = DateTime.Now,
                ProductId = productId,
                UserId = userId,
                CountOfProducts = quantity,
                Price = product.Price,
                Discount = product.Discount,
                AddressDelivery=adressDelivery
            };

            
            product.Quantity -= quantity;

           
            this._context.Products.Update(product);
            this._context.Orders.Add(item);

           
            return _context.SaveChanges() != 0;
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.OrderByDescending(x => x.DateOrder).ToList();
        }

        public List<Order> GetOrdersByUser(string userId)
        {
            return _context.Orders.Where(x => x.UserId == userId)
                .OrderByDescending(x => x.DateOrder)
                .ToList();
        }

        public bool RemoveById(int orderId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int orderId, int productId, string userId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
