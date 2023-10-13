using BaiTest.Data;
using BaiTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTest.Controllers
{
    public class OrderController : Controller
    {
        OrderDataAccessLayer orderDataAccessLayer = null;
        public OrderController()
        {
            orderDataAccessLayer = new OrderDataAccessLayer();
        }
        // GET: OrderController
        public ActionResult Index()
        {
            IEnumerable<Order> orders = orderDataAccessLayer.GetAllOrder();
            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            Order order = orderDataAccessLayer.GetOrder(id);
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            try
            {
                orderDataAccessLayer.AddOrder(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            Order order = orderDataAccessLayer.GetOrder(id);
            return View(order);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {
            try
            {
                orderDataAccessLayer.UpdateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = orderDataAccessLayer.GetOrder(id);
            return View(order);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order order)
        {
            try
            {
                orderDataAccessLayer.DeleteOrder(order.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult SearchOrder(string id)
        {
            //int idd = orderDataAccessLayer.SearchOrder(id).Id;
            
            var model = orderDataAccessLayer.SearchOrder(id);
    return Json(model);
        }
    }
}
