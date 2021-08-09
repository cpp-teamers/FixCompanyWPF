using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;

namespace EntityLibrary.Repositories.Interfaces
{
    interface IOrderRepository
    {
        IEnumerable<Order> GetAllOders();
        IEnumerable<Order> GetOrdersByOwnerId(int ownerId);
        IEnumerable<Order> GetOrdersByEmployeeId(int employeeId);
        IEnumerable<Order> GetOrderByStatusId(int statusId);
        Order GetOrderById(int orderId);
        void AddOrder(Order addedOrder);
        void ChangeOrder(Order changedOrder);
        void RemoveOrder(int deletedOrderId);
    }
}
