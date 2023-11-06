using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Calculator<T>
    {
        public Func<T, T, T> Add { get; set; }
        public Func<T, T, T> Subtract { get; set; }
        public Func<T, T, T> Multiply { get; set; }
        public Func<T, T, T> Divide { get; set; }

        public Calculator()
        {
            
            Add = (a, b) => (dynamic)a + b;
            Subtract = (a, b) => (dynamic)a - b;
            Multiply = (a, b) => (dynamic)a * b;
            Divide = (a, b) => (dynamic)a / b;
        }

        public T PerformOperation(T a, T b, Func<T, T, T> operation)
        {
            return operation(a, b);
        }
    }
}
