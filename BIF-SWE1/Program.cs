using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.SWE1.Exam
{
    /// <summary>
    /// Main program
    /// This program enables YOUR testing.
    /// You may change this class in any way you like.
    /// It's not part of the submission. (But it has to compile)
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BIF/SWE1 - Exam");
            Console.WriteLine("===============");
            Console.WriteLine();

            Exercise1();
            Console.WriteLine();
            Exercise2();
            Console.WriteLine();
            Exercise3();
            Console.WriteLine();
            Exercise4();
            Console.WriteLine();
            Exercise5();
        }

        private static void Trap(Action a)
        {
            try
            {
                a();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Remove/Change anything you need to test your submission
        /// </summary>
        private static void Exercise1()
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine("----------");
            IExercise1 test = new Exercise1Impl();
            Trap(() => { test.Method1(0, string.Empty, null); });
            Trap(() => { test.Method2(0, string.Empty, null); });
            Trap(() => { test.Method3(0, string.Empty, null); });
            Trap(() => { test.Method4(0, string.Empty, null); });
            Trap(() => { test.Method5(0, string.Empty, null); });
        }
        /// <summary>
        /// Remove/Change anything you need to test your submission
        /// </summary>
        private static void Exercise2()
        {
            Console.WriteLine("Exercise 2");
            Console.WriteLine("----------");
            IExercise2 test = new Exercise2Impl();
            Trap(() => { test.Method1(0, string.Empty, null); });
            Trap(() => { test.Method2(0, string.Empty, null); });
            Trap(() => { test.Method3(0, string.Empty, null); });
            Trap(() => { test.Method4(0, string.Empty, null); });
            Trap(() => { test.Method5(0, string.Empty, null); });
        }
        /// <summary>
        /// Remove/Change anything you need to test your submission
        /// </summary>
        private static void Exercise3()
        {
            Console.WriteLine("Exercise 3");
            Console.WriteLine("----------");
            IExercise3 test = new Exercise3Impl();
            Trap(() => { test.Method1(0, string.Empty, null); });
            Trap(() => { test.Method2(0, string.Empty, null); });
            Trap(() => { test.Method3(0, string.Empty, null); });
            Trap(() => { test.Method4(0, string.Empty, null); });
            Trap(() => { test.Method5(0, string.Empty, null); });
        }
        /// <summary>
        /// Remove/Change anything you need to test your submission
        /// </summary>
        private static void Exercise4()
        {
            Console.WriteLine("Exercise 4");
            Console.WriteLine("----------");
            IExercise4 test = new Exercise4Impl();
            Trap(() => { test.Method1(0, string.Empty, null); });
            Trap(() => { test.Method2(0, string.Empty, null); });
            Trap(() => { test.Method3(0, string.Empty, null); });
            Trap(() => { test.Method4(0, string.Empty, null); });
            Trap(() => { test.Method5(0, string.Empty, null); });
        }
        /// <summary>
        /// Remove/Change anything you need to test your submission
        /// </summary>
        private static void Exercise5()
        {
            Console.WriteLine("Exercise 5");
            Console.WriteLine("----------");
            IExercise5 test = new Exercise5Impl();
            Trap(() => { test.Method1(0, string.Empty, null); });
            Trap(() => { test.Method2(0, string.Empty, null); });
            Trap(() => { test.Method3(0, string.Empty, null); });
            Trap(() => { test.Method4(0, string.Empty, null); });
            Trap(() => { test.Method5(0, string.Empty, null); });
        }
    }
}
