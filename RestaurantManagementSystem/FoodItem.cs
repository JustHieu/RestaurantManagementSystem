using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    internal class FoodItem
    {
        public int Id { get; set; }          // ID của món ăn
        public string Name { get; set; }     // Tên của món ăn
        public string Description { get; set; } // Mô tả của món ăn
        public decimal Price { get; set; }   // Giá của món ăn
        public string PicturePath { get; set; } // Đường dẫn đến hình ảnh món ăn
        public string Type { get; set; }     // Loại món ăn (Main Dish, Starter, Beverage, ...)
    }
}
