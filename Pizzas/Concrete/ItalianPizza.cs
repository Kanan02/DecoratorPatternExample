using DecoratorExample.Ingredients.Abstract;
using DecoratorExample.Pizzas.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Pizzas.Concrete
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza(double price, string name) :base(price,name)
        {
            
        }
        public override void getName()
        {
            Console.WriteLine("Here is your Italian pizza +"+Name);
            Console.WriteLine("Price: "+ Price);
        }
    }
}
