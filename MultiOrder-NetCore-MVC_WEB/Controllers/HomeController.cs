using DAL.Repositories.Interfaces.Concrete;
using EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MultiOrder_NetCore_MVC_WEB.Models;
using MultiOrder_NetCore_MVC_WEB.Models.DTOs;
using System.Diagnostics;

namespace MultiOrder_NetCore_MVC_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public HomeController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult OrderList()
        {
            List<Order> orders = _orderRepository.GetDefaults(a=>a.Statu!=false).OrderBy(a=>a.CompanyName).ToList();
            return View(orders);
        }

        public IActionResult Create()
        {
            CreateOrderDTO model = new CreateOrderDTO();
            ViewBag.DateTimeNow = DateTime.Now;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateOrderDTO dto)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in dto.Orders)
                {
                    Order order = new Order()
                    {
                        CompanyName = dto.CompanyName,
                        OrderDate = dto.OrderDate,
                        ProductionName = item.ProductionName,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                    };
                    _orderRepository.Create(order);
                }
                return RedirectToAction("OrderList");
            }
            else
            { return View(dto);}

        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Delete(int id)
        {
            Order deletedOrder = _orderRepository.GetDefault(a => a.ID == id);
            _orderRepository.Delete(deletedOrder);
            return RedirectToAction("OrderList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}