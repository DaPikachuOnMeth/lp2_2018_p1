using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_P1
{
    class Program
    {
        /// <summary>
        /// Function that creates everything necessary for the program to 
        /// work properly.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = args[0];
            FileManager File = new FileManager(path);
            Library lib = new Library(File);
            Render render = new Render();
            Sorting sorter = new Sorting(lib.MakeList(lib.games),render);
            sorter.MenuStart();
        }
    }
}
