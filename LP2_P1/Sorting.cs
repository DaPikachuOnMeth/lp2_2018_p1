using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_P1
{
    class Sorting
    {
        public Render render = new Render();

        public List<Games> gameList;

        public Sorting(List<Games> gameList, Render rnd)
        {
            this.gameList = gameList;
            this.render = rnd;
        }

        //This shit right here gets thestuff and organizes it

        public void Sorter()
        {
            string[] valLib = render.val;
        }

    }
}
