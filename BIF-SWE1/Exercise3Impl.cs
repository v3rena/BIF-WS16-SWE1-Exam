using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam
{
    public class Exercise3Impl : IExercise3
    {
        public class Cat : Pet
        {
            public override float Eat(float amount)
            {
                return amount * 0.5f;
            }

            public override string MakeSound()
            {
                return "Miau";
            }

            public override int Move(int direction)
            {
                return direction;
            }
        }

        public class Figure
        {
            public void Draw() { }
            public void Move(int dx, int dy) { }
        }

        public class Circle : Figure
        {
        }

        public class Rectangle : Figure
        {
        }


        public object Method1(int i, string str, object obj)
        {
            return new Cat();
        }

        public object Method2(int i, string str, object obj)
        {
            return new object[2] { new Circle(), new Rectangle() };
        }

        public object Method3(int i, string str, object obj)
        {
            throw new NotImplementedException();
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
