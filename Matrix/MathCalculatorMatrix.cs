using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MathCalculatorMatrix<T> : IMathCalculator<MatrixGeneric<T>>
    {
        public MatrixGeneric<T> Add(MatrixGeneric<T> n1, MatrixGeneric<T> n2)
        {
            return n1 + n2;
        }

        public MatrixGeneric<T> Div(MatrixGeneric<T> n1, MatrixGeneric<T> n2)
        {
            return n1 - n2;
        }

        public MatrixGeneric<T> Mul(MatrixGeneric<T> n1, MatrixGeneric<T> n2)
        {
            return n1 * n2;
        }

        public MatrixGeneric<T> Sub(MatrixGeneric<T> n1, MatrixGeneric<T> n2)
        {
            return n1 / n2;
        }
    }
}
