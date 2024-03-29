﻿using FoodDeliveryDAL.Data;
using FoodDeliveryDAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryDAL.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly FoodDbContext _context;

        public OrderDetailRepository(FoodDbContext context)
        {
            _context = context;
        }

        public void CreateOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public OrderDetail GetOrderDetailById(int orderDetailId)
        {
            return _context.OrderDetails.Find(orderDetailId);
        }

       
        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }

}
