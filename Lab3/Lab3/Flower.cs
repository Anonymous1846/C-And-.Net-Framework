using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Flower
    {
        private String flower_name;
        private double price_per_kg,stock_avail;
        public void __init__()
        {
            flower_name = null;
            price_per_kg = 0.0;
            stock_avail=0.0;
        }
       public void setStock(double stocks)
        {
            stock_avail = stocks;
        }
        public void setFlowerName(String flowerName)
        {
            flower_name = flowerName;
        }
        public void setPrice(double flowerPrice)
        {
            price_per_kg = flowerPrice;
        }
        public double getStock()
        {
            return stock_avail;
        }
        public String getFlowerName()
        {
            return flower_name;
        }
        public double getPrice()
        {
            return price_per_kg;
        }
        public void sell_flower(double required)
        {
            if (validate_flower())
            {
                if (validate_stock(required))
                {
                    stock_avail -= required;
                    double price = price_per_kg * required;
                    Console.WriteLine("The Stock is Avaialable for Sale Net price: {0}",price);
                    Console.WriteLine("Current Stock {0}",stock_avail);
                }
                else
                {
                    Console.WriteLine("Sorry The Required Quantity Is Unavailable !");
                }
            }
            else
            {
                Console.WriteLine("Sorry Invalid Flower Name !");
            }

        }

        public Boolean validate_flower()
        {
            if (string.Equals(flower_name, "Orchid", StringComparison.OrdinalIgnoreCase) || string.Equals(flower_name, "Rose", StringComparison.OrdinalIgnoreCase)|| string.Equals(flower_name, "Jasmine", StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
        public Boolean validate_stock(double stock_entered)
        {
                if((stock_entered<=stock_avail)&& check_level())
                return true;
            return false;
        }
        public Boolean check_level()
        {
            Flower flower = new Flower();
            if (this.getStock() >= flower.getStock())
                return true;
            return false;
        }
    }
}
