using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLibrary.Models;
using EntityLibrary.Repositories.Interfaces;
using System.Data.Entity;
using EntityLibrary.EF;

namespace EntityLibrary.Repositories.Implementations
{
    class OrderRepository : IOrderRepository
    {
        private DataManager _dataManager = new DataManager();
        public void AddOrder(Order addedOrder)
        {
            _dataManager.Orders.Add(addedOrder);

            _dataManager.SaveChanges();
        }

        public void ChangeOrder(Order changedOrder)
        {
            _dataManager.Orders.Attach(changedOrder);
            _dataManager.Entry(changedOrder).State = EntityState.Modified;
            _dataManager.SaveChanges();
        }

        public IEnumerable<Order> GetAllOders()
        {
            return _dataManager.Orders.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _dataManager.Orders.Find(orderId);
        }

        public IEnumerable<Order> GetOrderByStatusId(int statusId)
        {
            return _dataManager.ReadynessStatuses.Find(statusId).Orders.ToList();
        }

        public IEnumerable<Order> GetOrdersByEmployeeId(int employeeId)
        {
            return _dataManager.Accounts.Find(employeeId).EmployeeAccountOrders.ToList();
        }

        public IEnumerable<Order> GetOrdersByOwnerId(int ownerId)
        {
            return _dataManager.Accounts.Find(ownerId).OwnerAccountOrders.ToList();
        }

        public void RemoveOrder(int deletedOrderId)
        {
            var foundedOrder = _dataManager.Orders.Find(deletedOrderId);
            _dataManager.Orders.Remove(foundedOrder);

            _dataManager.SaveChanges();
        }
    }
}
