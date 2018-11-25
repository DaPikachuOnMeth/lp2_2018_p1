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
            string path = "games.csv";
            FileManager File = new FileManager(path);
            Library lib = new Library(File);
            Render render = new Render();
            render.MainMenu();
        }
    }
}
