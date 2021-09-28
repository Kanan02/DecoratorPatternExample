using DecoratorExample.Pizzas.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Ingredients.Abstract
{
    public abstract class Ingredient:Pizza
    {
        public Ingredient(double price,string name,Pizza pizza):base(price,name)
        {
            Pizza = pizza;
        }
        public Pizza Pizza { get; set; }
    }
}
