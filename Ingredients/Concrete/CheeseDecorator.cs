using DecoratorExample.Ingredients.Abstract;
using DecoratorExample.Pizzas.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Ingredients.Concrete
{
    public class CheeseDecorator:Ingredient
    {
        public CheeseDecorator(Pizza pizza):base(pizza.Price+=1,pizza.Name+"with chesse",pizza)
        {

        }

        public override void getName()
        {
            Console.WriteLine("Here is your pizza +" + Name);
            Console.WriteLine("Price: " + Price);
        }
    }
}
