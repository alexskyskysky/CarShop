﻿using System;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository {
    public class OrdersRepository : IAllOrders {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart) {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order) {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            var items = shopCart.listShopItems;
            foreach (var el in items) {
                var orderDetail = new OrderDetail {
                    carID = el.car.id,
                    orderID = order.id,
                    price = el.car.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}