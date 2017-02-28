﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class MatrixGeneric<T>
    {
        private int _width;
        private int _height;
        private T[,] _matrix;
        //private IMathCalculator<T> _mathCalculator;

        public MatrixGeneric(T[,] array)
        {
            Matrix = array;
            Width = array.GetLength(1);
            Height = array.GetLength(0);
        }

        static MatrixGeneric<T> FromArray(T[,] array)
        {
            //MatrixGeneric<T> m = new MatrixGeneric<T>(array);
            return new MatrixGeneric<T>(array);// m;
        }

        int Width
        {
            get { return _width; }
            set { _width = value; }
        }  

        int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        T[,] Matrix
        {
            get { return _matrix; }
            set { _matrix = value; }
        }

        T this[int hIndex, int wIndex]// TODO make exceptions and try-catch
        {
            get
            {
                return Matrix[hIndex, wIndex];
            }
            set
            {
                Matrix[hIndex, wIndex] = value;
            }
        }

        //IMathCalculator<T> MathCalculator
        //{
        //    get { return _mathCalculator; }
        //    set { _mathCalculator = value; }
        //}

        static MatrixGeneric<T> operator +(MatrixGeneric<T> m1, MatrixGeneric<T> m2)
        { }

        static MatrixGeneric<T> operator -(MatrixGeneric<T> m1, MatrixGeneric<T> m2)
        { }

        static MatrixGeneric<T> operator *(MatrixGeneric<T> m1, MatrixGeneric<T> m2)
        { }

        static MatrixGeneric<T> operator /(MatrixGeneric<T> m1, MatrixGeneric<T> m2)
        { }
    }
}
