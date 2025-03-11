using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public abstract class Person
    {
        private string name;
        private Info info;
        protected double salaryCoefficient; // Hệ số lương
        private string position;
        public Person(string name, Info info, double salaryCoefficient, string position)
        {
            this.Name = name;
            this.Info = info;
            this.SalaryCoefficient = salaryCoefficient;
            this.Position = position;
        }

        public string Name { get => name; set => name = value; }
        public Info Info { get => info; set => info = value; }
        public double SalaryCoefficient { get => salaryCoefficient; set => salaryCoefficient = value; }
        protected string Position { get => position; set => position = value; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Info: {this.Info}, Salary Coefficient: {this.SalaryCoefficient}, Position: {this.Position}";
        }

    }
}