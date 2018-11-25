using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dest = args[0];
            FileManager File = new FileManager(dest);
            Library lib = new Library(File);
            Render render = new Render();
        }
    }
}
