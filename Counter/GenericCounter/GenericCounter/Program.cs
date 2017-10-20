using System;
using System.Collections.Generic;
using GenericCounter.Objects;

namespace GenericCounter
{
    internal class Program
    {
        private static void Main()
        {
            var apples = new List<Apple>()
            {
                new Apple(699),
                new Apple(79),
                new Apple(1099)

            };
            var box = new Box<object>()
            {
                "",
                1,
                10,
                40,
                new Apple(899),
                new Box<Apple>()
                {
                    new Apple(99),
                    new Apple(199),
                    new Apple(2999)
                },
                apples
            };
            var anotherBox = new Box<object>()
            {
                box,
                new Box<int> {1,2,3,4,5}
            };

            var cart = new Cart(new List<Box<object>>());
            cart.AddBox(box);
            cart.AddBox(anotherBox);

            Console.WriteLine("Count of an apple: " + apples[0].Count().ToString());
            Console.WriteLine("Count of a box: " + box.Count().ToString());
            Console.WriteLine("Count of another box: " + anotherBox.Count().ToString());
            Console.WriteLine("Count of things in a box cart: " + cart.Count().ToString());
            Console.ReadKey();
        }
    }
}
