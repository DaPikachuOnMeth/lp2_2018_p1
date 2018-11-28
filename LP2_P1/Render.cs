using System;

namespace LP2_P1
{
    /// <summary>
    /// Renders and handles most of the menus.
    /// </summary>
    class Render
    {
        /// <summary>
        /// Initializes all of the required variables for this class.
        /// </summary>
        internal Render() { }

        DateTime tempdate;
        string tempstring;
        int tempint;
        bool tempbool;

        internal string[] val1 = new string[] { " ", " ", " ", " ", " ", " ",
                                                  " ", " ", " ", " ", " ", " ",
                                                                  " "," "};
        internal string[] val2 = new string[] { "ID.", " ", " ", " ", " ", " ",
                                                  " ", " ", " "};
        /// <summary>
        /// Returns info to sorting to know what menu to do next.
        /// </summary>
        /// <returns></returns>
        internal int MainMenu()
        {
            Console.WriteLine("Select search menthod: ");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Filters:");
            Console.WriteLine("2: Sort by:");
            Console.WriteLine("3: Search");


            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (input)
            {
                case 0:
                    System.Environment.Exit(1);
                    break;

                case 1:
                    return 1;

                case 2:
                    return 2;

                case 3:
                    return 3;
            }

            return input;
        }
        
        /// <summary>
        /// Prints and handles the filter menu, allows the change of filters
        /// for the specific search.
        /// </summary>
        internal void FilterMenu()
        {

            Console.WriteLine("Selected methods: \n Name:             <{0,18}> " +
                "Release Date:     <{1,18}> Age:              <{2,18}>" +
                "\n Metacritic:       <{3,18}> Recommendation Nº:<{4,18}> " +
                "\n Controller:       <{5,18}> Windows:          <{6,18}>" +
                " Linux:            <{7,18}> \n Mac:              <{8,18}> " +
                "Singleplayer:     <{9,18}> Multiplayer:      <{10,18}>" +
                "\n Coop Multiplayer: <{11,18}> Level Editor:     <{12,18}> " +
                "VR:               <{13,18}>",
                              val1[0], val1[1], val1[2], val1[3], val1[4], val1[5], val1[6],
                              val1[7], val1[8], val1[9], val1[10], val1[11], val1[12], val1[13]);

            Console.WriteLine("\n \n \n Filter by: ");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Release date");
            Console.WriteLine("3: Age");
            Console.WriteLine("4: Metacritic");
            Console.WriteLine("5: Recommendation score");
            Console.WriteLine("6: Controller support");
            Console.WriteLine("7: Windows support");
            Console.WriteLine("8: Linux support");
            Console.WriteLine("9: Mac support");
            Console.WriteLine("10: Has singleplayer");
            Console.WriteLine("11: Has multiplayer");
            Console.WriteLine("12: Has coop multiplayer");
            Console.WriteLine("13: Has level editor");
            Console.WriteLine("14: Has VR support");
            Console.WriteLine("0: Return");


            int input = Convert.ToInt32(Console.ReadLine());

            // Checks for input.
            switch (input)
            {
                case 0:
                    Console.Clear();
                    MainMenu();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("Insert name: ");
                    val1[0] = Console.ReadLine();
                    FilterMenu();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Insert release date (Please use formating YYYY-MM-DD) : ");
                    if(DateTime.TryParse(tempstring = Console.ReadLine(), out tempdate))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[1] = tempstring;
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Insert age: ");
                    if (Int32.TryParse(tempstring = Console.ReadLine(), out tempint) && tempint >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[2] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Insert metacritic score: ");
                    if (Int32.TryParse(tempstring = Console.ReadLine(), out tempint)
                        && tempint <= 100 && tempint >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[3] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Insert recommendation count: ");
                    if (Int32.TryParse(tempstring = Console.ReadLine(), out tempint)
                        && tempint >= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[4] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Insert controller support (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[5] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Has Windows support (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[6] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("Has Linux support (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[7] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("Has Mac support (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[8] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine("Has singleplayer (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[9] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 11:
                    Console.Clear();
                    Console.WriteLine("Has multiplayer (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[10] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 12:
                    Console.Clear();
                    Console.WriteLine("Has multiplayer coop (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[11] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 13:
                    Console.Clear();
                    Console.WriteLine("Has level editor? (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[12] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

                case 14:
                    Console.Clear();
                    Console.WriteLine("Supports VR? (true or false): ");
                    if (bool.TryParse(tempstring = Console.ReadLine(), out tempbool))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val1[13] = tempstring;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect Value sending you back to menu. \n \n");
                    }
                    FilterMenu();
                    break;

            }
        }

        /// <summary>
        /// Prints and handles the sorting menu.
        /// </summary>

        internal void SortBy()
        {
            Console.WriteLine("Selected sort method: " + val2[0] + val2[1] + val2[2] +
                                  val2[3] + val2[4] + val2[5] + val2[6] + val2[7] + val2[8]);

            Console.WriteLine("Sort by: ");
            Console.WriteLine("1: ID");
            Console.WriteLine("2: Name");
            Console.WriteLine("3: Release Date");
            Console.WriteLine("4: Metacritic score:");
            Console.WriteLine("5: DLC count");
            Console.WriteLine("6: Recommendation");
            Console.WriteLine("7: Nº of owner");
            Console.WriteLine("8: Player count");
            Console.WriteLine("9: Achievment count");
            Console.WriteLine("0: Return");


            int input = Convert.ToInt32(Console.ReadLine());



            switch (input)
            {
                case 0:
                    Console.Clear();
                    MainMenu();
                    break;

                case 1:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[0] = "ID.";
                    SortBy();
                    break;

                case 2:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[1] = "Name.";
                    SortBy();
                    break;

                case 3:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[2] = "Release Date.";
                    SortBy();
                    break;

                case 4:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[3] = "Metacritic Score.";
                    SortBy();
                    break;

                case 5:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[4] = "DLC.";
                    SortBy();
                    break;

                case 6:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[5] = "Recommendations.";
                    SortBy();
                    break;

                case 7:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[6] = "Nº of Owners.";
                    SortBy();
                    break;

                case 8:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[7] = "Player Count.";
                    SortBy();
                    break;

                case 9:
                    Console.Clear();
                    Array.Clear(val2, 0, val2.Length);
                    val2[8] = "Achievement Count.";
                    SortBy();
                    break;
            }
        }

        /// <summary>
        /// Prints and handles the search menu.
        /// </summary>
        internal void Search()
        {
            Console.WriteLine("Search by: ");
            Console.WriteLine("1: ID");
            Console.WriteLine("2: Name");
            Console.WriteLine("3: Release Date");
            Console.WriteLine("4: Metacritic score:");
            Console.WriteLine("5: DLC count");
            Console.WriteLine("6: Recommendation");
            Console.WriteLine("7: Nº of owner");
            Console.WriteLine("8: Player count");
            Console.WriteLine("9: Achievment count");
            Console.WriteLine("0: Return");

            int input = Convert.ToInt32(Console.ReadLine());

            string[] str = new string[10];

            switch (input)
            {
                case 0:
                    Console.Clear();
                    MainMenu();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("By ID: ");
                    str[0] = Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("By Name: ");
                    str[1] = Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("By release date: ");
                    str[2] = Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("By Metacritic score: ");
                    str[3] = Console.ReadLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("By DLC count: ");
                    str[4] = Console.ReadLine();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("By recommendation count: ");
                    str[5] = Console.ReadLine();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("By nº of players: ");
                    str[6] = Console.ReadLine();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("By player count: ");
                    str[7] = Console.ReadLine();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("By achievment count: ");
                    str[8] = Console.ReadLine();
                    break;
            }
        }
    }
}

