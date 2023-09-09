using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Performance_Class_Library
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item); 
    }
}
