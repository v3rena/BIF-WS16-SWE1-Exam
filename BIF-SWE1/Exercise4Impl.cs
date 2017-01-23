using BIF.SWE1.Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BIF.SWE1.Exam
{
    public class Exercise4Impl : IExercise4
    {
        public object Method1(int i, string str, object obj)
        {
            /*Stream myStream = new MemoryStream();
            //StreamWriter writer = new StreamWriter(myStream);
            BinaryWriter writer = new BinaryWriter(myStream);
            writer.Write("Hallo");
            writer.Write(1);
            writer.Write(true);
            return myStream;*/

            var s = new MemoryStream();
            var sw = new BinaryWriter(s);
            sw.Write("Hallo");
            sw.Write(1);
            sw.Write(true);
            return s;
        }

        public object Method2(int i, string str, object obj)
        {
            BinaryReader reader = new BinaryReader((Stream)obj);
            reader.ReadInt32();
            reader.ReadBoolean();
            return reader.ReadString();
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
