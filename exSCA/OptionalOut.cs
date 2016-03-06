using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exSCA
{
    public class OptionalOut<T>
    {
        public OptionalOut(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
    }
}
