using DecoratorExample.Ingredients.Abstract;
using DecoratorExample.Ingredients.Concrete;
using DecoratorExample.Pizzas.Abstract;
using DecoratorExample.Pizzas.Concrete;
using System;
using System.Collections.Generic;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new ItalianPizza(10, "Italian pizza ");
            pizza = new CheeseDecorator(pizza);
            pizza.getName();
        }
    }
}
