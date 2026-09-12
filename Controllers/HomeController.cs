using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TH02_FirstWeb.Models;

namespace TH02_FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NameList()
        {
            //tạo danh sách chuỗi
            List<string> danhsachTen = new List<string>
            {
                "Nguyễn Tiến Dũng",
                "Nguyễn Thị Thanh Hằng",
                "Trần Bình An",
                "Trần Trường An",
                "Lệ Phi Vũ",
            };

            //Truyền danh sách làm Model cho view
            return View(danhsachTen);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
