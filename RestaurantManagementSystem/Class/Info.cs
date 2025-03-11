using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Info
    {
        private string sex;
        private string id;
        private string phone;
        private string address;
        private DateTime birthDay;
        public Info(string sex, string id, string phone, string address, DateTime birthDay)
        {
            this.Sex = sex;
            this.Id = id;
            this.Phone = phone;
            this.Address = address;
            this.BirthDay = birthDay;
        }

        public string Sex { get => sex; set => sex = value; }
        public string Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }

        public override string ToString() { 
            return $"SEX: {this.Sex} -  ID: {this.Id} - PHONE: {this.Phone} - ADDRESS: {this.Address} - DOB: {this.BirthDay}";
        }
    }
}