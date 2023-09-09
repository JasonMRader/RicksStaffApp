using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library.FilterAndSortClasses
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _spec1;
        private readonly ISpecification<T> _spec2;

        public AndSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
        {
            _spec1 = spec1;
            _spec2 = spec2;
        }

        public bool IsSatisfiedBy(T item)
        {
            return _spec1.IsSatisfiedBy(item) && _spec2.IsSatisfiedBy(item);
        }
    }

}
