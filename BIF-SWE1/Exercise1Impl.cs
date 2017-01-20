using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        String format(int i);
    }

    public class Exercise1Impl : IExercise1
    {
        class Calculator : ICalculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public string format(int i)
            {
                throw new ArgumentNullException();
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }
        }

        public interface IMyInterface
        {
            int Add(int a, int b);
        }

        public class MyInterface : IMyInterface
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        public object Method1(int i, string str, object obj)
        {
            return new Calculator();
        }

        public object Method2(int i, string str, object obj)
        {

            return new MyInterface();
        }

        public object Method3(int i, string str, object obj)
        {
            return true;
        }

        public object Method4(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }

        public object Method5(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
