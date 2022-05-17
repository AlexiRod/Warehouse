using System;
using System.Collections.Generic;
using System.Text;

namespace WareHouse
{
    [Serializable]
    public class Ware
    {
        public string Name { get; set; }
        public string Articule { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Text { get; set; }
        public string ImageString { get; set; }

        public Ware() { }
        public Ware(string name, string articule, double price, int count, string text, string image)
        {
            Name = name;
            Articule = articule;
            Price = price;
            Count = count;
            Text = text;
            ImageString = image;
        }
    }
}
