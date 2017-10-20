using System.Collections.Generic;
using System.Linq;

namespace GenericCounter.Objects
{
    public class Cart : ICountable
    {
        private readonly List<Box<object>> _boxes;

        public Cart(List<Box<object>> boxes)
        {
            _boxes = boxes;
        }

        public void AddBox(Box<object> box)
        {
            _boxes.Add(box);
        }

        public int Count()
        {
            var countList = _boxes.Select(x => x.Count());
            return countList.Aggregate((current, next) => current + next);
        }
    }
}
