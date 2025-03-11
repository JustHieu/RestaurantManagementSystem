using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Chef : Person
    {
        public Chef(string name, Info info, double salaryCoefficient, string position)
            : base(name, info, salaryCoefficient, position)
        {
            // Gán hệ số lương từ RestaurantConfig hoặc từ giá trị mặc định
            if (RestaurantConfig.SalaryCoefficients.TryGetValue(name, out double coefficient))
            {
                this.salaryCoefficient = coefficient;
            }
            else
            {
                this.salaryCoefficient = 0; // Nếu không tìm thấy 0
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}