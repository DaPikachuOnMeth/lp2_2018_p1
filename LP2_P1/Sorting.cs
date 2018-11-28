using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_P1
{
    /// <summary>
    /// Handles the sorting filtering and also handles some of the program
    /// function calling.
    /// </summary>
    class Sorting
    {
        internal Render render = new Render();

        internal List<Games> gameList;

        /// <summary>
        /// Constructor to give the class sorting its necessary variables.
        /// </summary>
        /// <param name="gameList"></param>
        /// <param name="rnd"></param>
        internal Sorting(List<Games> gameList, Render rnd)
        {
            this.gameList = gameList;
            this.render = rnd;
        }
        /// <summary>
        /// Handles menu info and calling the specific functions.
        /// </summary>

       // Updated upstream
        internal void MenuStart()
        {
            for(int i = 1; i >= 1;)
            {
                i = render.MainMenu();
                if (i == 1)
                    render.FilterMenu();
                else if (i == 2)
                    render.SortBy();
                else if(i == 3)
                {
                    Filter();
                    foreach(Games p in gameList)
                    {
                        p.PrintInfo();
                    }
                    Console.ReadKey();
                }
            }

        }
        /// <summary>
        /// Sorts the lists according to paramenters taken from renderer.
        /// Specificly uses val2 array of strings.
        /// </summary>
=======
        //Apperantly it only gets info from the render array, oops
>>>>>>> Stashed changes

        internal void Sorter()
        {
<<<<<<< Updated upstream
            string[] valLib = render.val2;

            for (int x = 0; x < valLib.Length; x++)
            {
                switch (x)
                {
                    case 0:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.ID).ToList();
                        }
                        break;
                    case 1:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.Name).ToList();
                        }
                        break;
                    case 2:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.releaseDate ).ToList();
                        }
                        break;
                    case 3:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.releaseDate).ToList();
                        }
                        break;
                    case 4:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.Metacritic).ToList();
                        }
                        break;
                    case 5:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.DLCCount).ToList();
                        }
                        break;
                    case 6:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.Owners).ToList();
                        }
                        break;
                    case 7:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.NumberOfPlayers).ToList();
                        }
                        break;
                    case 8:
                        if (valLib[x] != " ")
                        {
                            gameList = gameList.OrderBy(y => y.AchievementCount).ToList();
                        }
                        break;
                }
            }
=======
            string[] valLib = render.val;


>>>>>>> Stashed changes
        }

        /// <summary>
        /// Filters the list of games according to filters taken from renderer.
        /// Specificly uses val1 array of strings.
        /// </summary>
        internal void Filter()
        {
            string[] valLib = render.val1;
            DateTime temp;

            for (int i = 0; i < valLib.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(y => y.Name.Contains(valLib[i])).ToList();
                        }
                        break;
                    case 1:
                        if (valLib[i] != " ")
                        {
                            DateTime.TryParse(valLib[i], out temp);
                            gameList = gameList.Where(y => y.releaseDate >= temp).ToList();
                        }
                        break;
                    case 2:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.RequiredAge >= Convert.ToInt32(valLib[i])).ToList();
                        }
                        break;
                    case 3:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.Metacritic >= Convert.ToInt32(valLib[i])).ToList();
                        }
                        break;
                    case 4:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.RecommendationCount == Convert.ToInt32(valLib[i])).ToList();
                        }
                        break;
                    case 5:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.ControllerSupport == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 6:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.PlatformWindows == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 7:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.PlatformLinux == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 8:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.PlatformMac == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 9:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.CategorySinglePlayer == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 10:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.CategoryMultiplayer == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 11:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.CategoryCoop == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 12:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.CategoryIncludeLevelEditor == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                    case 13:
                        if (valLib[i] != " ")
                        {
                            gameList = gameList.Where(game => game.CategoryVRSupport == Convert.ToBoolean(valLib[i])).ToList();
                        }
                        break;
                }

            }
        }



    }
}
