using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IReceiver
    {
        void Read();

        void Write();

        void Save();
    }

    public class Receiver : IReceiver
    {
        public void Read()
        {
            //log好命令
            Console.WriteLine("Read1");
        }

        public void Write()
        {
            Console.WriteLine("Write1");
        }

        public void Save()
        {
            Console.WriteLine("Save1");
        }
    }
    public class ReceiverNew : IReceiver
    {
        public void Read()
        {
            Console.WriteLine("Read2");
        }

        public void Write()
        {
            Console.WriteLine("Write2");
        }

        public void Save()
        {
            Console.WriteLine("Save2");
        }
    }
}
