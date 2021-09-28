using DecoratorExample.Ingredients.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Pizzas.Abstract
{
    public abstract class Pizza
    {
        protected Pizza(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public double Price { get; set; }
        public string Name { get; set; }
        public abstract void getName();
    }
}
