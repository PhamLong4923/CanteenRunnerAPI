using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CanteenRunnerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("foods")]
        public IActionResult GetFoods()
        {
            // Dữ liệu mẫu giả lập của bảng Foods
            var foods = new List<object>
            {
                new
                {
                    FoodID = "F001",
                    Name = "Burger",
                    Description = "Delicious beef burger",
                    Price = 5.99m,
                    CategoryID = "C001",
                    CanteenID = "CT001",
                    ImageURL = "https://th.bing.com/th/id/OIP.F6VyuMUgr0Rx8wTNPJ8mBAHaIu?rs=1&pid=ImgDetMain",
                    Update = "2024-12-04T12:00:00"
                },
                new
                {
                    FoodID = "F002",
                    Name = "Pizza",
                    Description = "Cheese and tomato pizza",
                    Price = 7.99m,
                    CategoryID = "C002",
                    CanteenID = "CT002",
                    ImageURL = "https://www.engelvoelkers.com/wp-content/uploads/2014/07/pizza-stock.jpg",
                    Update = "2024-12-04T14:00:00"
                }
            };

            return Ok(foods); // Trả về HTTP 200 với dữ liệu mẫu
        }
    }
}
