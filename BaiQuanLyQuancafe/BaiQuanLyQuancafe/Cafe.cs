using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiQuanLyQuancafe
{
    public class Cafe
    {
        private string name;
        private int price;
        private string topping;
        private string size;
        private int number;
        private int sum;
        public Cafe()
        {
            name = "NULL";
            price= 0;
        }
        public Cafe(string name,int price,string topping,string size,int number)
        {
            this.name = name;
            this.price = price;
            this.topping = topping;
            this.size = size;
            this.number = number;
        }
        public Cafe(string size,int  price)
        {
            this.size = size;
            this.price = price;
        }
        public string Display()
        {
            return "\n"+" Drink: " + name + ",Price: " + price + ",Topping: " + topping + ",Size: " + size + ",number: " + number+"\n";
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Topping { get => topping; set => topping = value; }
        public string Size { get => size; set => size = value; }
        public int Number { get => number; set => number = value; }
        public int Sum { get => sum; set => sum = value; }
    }
}
