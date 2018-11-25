using System;
using System.Linq;
using System.Collections.Generic;

namespace LP2_P1
{
    class Library
    {
        public Dictionary<int, Games> games;
        public FileManager file;
        public List<Games> gamesList = new List<Games>() ;
        public Library(FileManager file)
        {
            this.file = file;
            games = CreateDictionary(file.list);
        }

        public Dictionary<int, Games> CreateDictionary(string[] list)
        {
            Dictionary<int, Games> lib = new Dictionary<int, Games>();
            
            for (int i = 1; i< list.Length; i++)
            {
                string[] s = file.SplitLine(file.list[i]);
                Games game = new Games(s);

                if (lib.TryGetValue(game.GetID(), out Games gm) == false)
                {
                    lib.Add(game.GetID(), game);
                }
            }
            return lib;
        }

        List<Games> Search(Dictionary<int, Games> lib)
        {
            Dictionary<int, Games> Search = new Dictionary<int, Games>();
            List<Games> list = new List<Games>();

            list = lib.Values.ToList();
            return list;
        }
    }
}
