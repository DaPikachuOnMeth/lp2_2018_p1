using System.IO;
using System;

namespace LP2_P1
{
    class FileManager
    {
        string path;
        internal string[] list;

        public FileManager(string path)
        {
            if (path.Length == 0)
            {
                path = "games.csv";
            }
            else { this.path = path; }

            list = File.ReadAllLines(path);
        }

        public string[] SplitLine(string str)
        {
            string[] data = str.Split(','); //splits string
            return data;
        }
    }
}