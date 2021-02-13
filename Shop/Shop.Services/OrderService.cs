using Shop.Core.Contracts;
using Shop.Core.Models;
using Shop.Core.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    public class OrderService : IOrderService
    {
        public IRepository<Order> orderContext;
        
        public OrderService(IRepository<Order> orderContext)
        {
            this.orderContext = orderContext;
        }

        public void CreateOrder(Order baseOrder, List<BasketItemViewModel> basketItems)
        {
            foreach(var items in basketItems)
            {
                baseOrder.OrderItems.Add(new OrderItem {
                    ProductId = items.Id,
                    Image = items.Image,
                    ProductName = items.ProductName,
                    Price = items.Price,
                    Quantity = items.Quantity
                });

                orderContext.Insert(baseOrder);
                orderContext.Commit();
            }
        }
    }
}
