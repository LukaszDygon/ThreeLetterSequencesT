using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCounter.Objects
{
    public class Apple : ICountable
    {
        private readonly double _price;
        public Apple(float price)
        {
            _price = price;
        }

        public int Count()
        {
            return 1;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
