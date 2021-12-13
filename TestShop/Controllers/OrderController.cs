using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Controllers {
    public class OrderController : Controller {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart) {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order) {
            shopCart.listShopItems = shopCart.GetShopItems();
            if (shopCart.listShopItems.Count == 0)
                ModelState.AddModelError("no_items_in_cart", "У вас должны быть товары!");
            if (ModelState.IsValid) {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete() {
            ViewBag.Message = "Заказ успешно обработан!";
            return View();
        }
    }
}