using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class RestaurantConfig
    {
        public static double VAT = 0.1f; // 10% VAT
        public static double serviceFee = 0.05f; // 5% phí dịch vụ
        public static int maxSeats =15; // Số bàn tối đa
        public const int StockThreshold = 3; // Ngưỡng tồn kho cảnh báo
                                             
        public static readonly Dictionary<string, double> SalaryCoefficients = new Dictionary<string, double>
    {
        { "Staff", 1.0 },
        { "Chef", 1.2 },
        { "Manager", 1.5 }
    };// Hằng số hệ số lương cho nhân viên


    }
}