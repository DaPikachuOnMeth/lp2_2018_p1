using System;
using System.Linq;
using System.Collections.Generic;

namespace LP2_P1
{
    class Library
    {
        internal Dictionary<int, Games> games;
        internal FileManager file;
        public List<Games> gamesList = new List<Games>() ;
        internal Library(FileManager file)
        {
            this.file = file;
            games = CreateDictionary(file.list);
        }
        /// <summary>
        /// Returns a dictionary.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal Dictionary<int, Games> CreateDictionary(string[] list)
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
        /// <summary>
        /// Handles the list creation.
        /// </summary>
        /// <param name="dictio"></param>
        /// <returns></returns>
        internal List<Games> MakeList(Dictionary<int, Games> dictio)
        {
            List<Games> list = new List<Games>();
            list = dictio.Values.ToList();
            return list;
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
