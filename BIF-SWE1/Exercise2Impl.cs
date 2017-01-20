using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIF.SWE1.Exam
{
    public class Exercise2Impl : IExercise2
    {
        public class Person
        {
            public string Name { get; set; }
            public virtual string Print()
            {
                return "My Name";
            }
            public virtual int GetAge()
            {
                return 42;
            }
        }

        public class CoolPerson : Person
        {
        }

        public class SuperCoolPerson : Person
        {
            override public virtual string Print()
            {
                return "Karin";
            }
        }

        public class MegaCoolPerson : Person
        {
            public virtual string Print(string prefix)
            {
                return prefix + "Karin";
            }
        }

        public class Dateisystem
        {

        }

        public class File
        {
            string Name { get; }
            string Content { get; }
        }

        public class Directory
        {
            string name { get; }
            List<File> Nodes;
        }

        public object Method1(int i, string str, object obj)
        {
            return new CoolPerson();
        }

        public object Method2(int i, string str, object obj)
        {
            return new SuperCoolPerson();
        }

        public object Method3(int i, string str, object obj)
        {
            return new MegaCoolPerson();
        }

        public object Method4(int i, string str, object obj)
        {
            return new Dateisystem();
        }

        public object Method5(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
