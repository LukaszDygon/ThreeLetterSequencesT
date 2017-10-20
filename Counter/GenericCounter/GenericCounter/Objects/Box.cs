using System.Collections.Generic;
using System.Linq;

namespace GenericCounter.Objects
{
    public class Box<T> : List<T>, ICountable
    {
        public new int Count()
        {
            var countList = this.Select(x => x is ICountable ? ((ICountable)x).Count() : 1);
            return countList.Aggregate((current, next) => current + next);
        }
    }
}
