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
            override public string Print()
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

        public abstract class Node
        {
            public string Name { get; set; }
        }

        public class File : Node
        {
            public byte[] Content { get; set; }
        }

        public class Directory : Node
        {
            public IEnumerable<Node> Nodes => NodeList;
            internal List<Node> NodeList { get; set; } = new List<Node>();
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
            List<object> newList = new List<object>();

            Directory settings = new Directory() { Name = "Settings" };
            settings.NodeList.Add(new File() { Name = "Properties.txt" });

            newList.Add(new File() { Name = "Hello.txt" });
            newList.Add(new Directory() { Name = "Empty" });
            newList.Add(settings);
        
            return newList;
        }

        public object Method5(int i, string str, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
