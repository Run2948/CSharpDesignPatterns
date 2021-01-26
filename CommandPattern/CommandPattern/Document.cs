using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Read()
        {
            Console.WriteLine("Read");
        }

        public void Write()
        {
            Console.WriteLine("Write");
        }


    }
}
