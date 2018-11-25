using System;

namespace LP2_P1
{
    class Render
    {
        public Render() { }

        public string[] val = new string[] { " ", " ", " ", " ", " ", " ",
                                                  " ", " ", " ", " ", " ", " ",
                                                                  " "," "," "};

        public int MainMenu()
        {
            Console.WriteLine("Select search menthod: ");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Search by:");
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
                    FilterMenu();
                    break;

                case 2:
                    SortBy();
                    break;

                case 3:
                    Search();
                    break;
            }

            return input;
        }
        
        //Prints Search menu
        public void FilterMenu()
        {

            Console.WriteLine("Selected methods: \n Name:             <{0,18}> " +
                "Release Date:     <{1,18}> Age:              <{2,18}>" +
                "\n Metacritic:       <{3,18}> Recommendation Nº:<{4,18}> " +
                "\n Controller:       <{5,18}> Windows:          <{6,18}>" +
                " Linux:            <{7,18}> \n Mac:              <{8,18}> " +
                "Singleplayer:     <{9,18}> Multiplayer:      <{10,18}>" +
                "\n Coop Multiplayer: <{11,18}> Level Editor:     <{12,18}> " +
                "VR:               <{13,18}>",
                              val[0], val[1], val[2], val[3], val[4], val[5], val[6],
                              val[7], val[8], val[9], val[10], val[11], val[12], val[13], val[14]);

            Console.WriteLine("\n \n \n Search by: ");
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

            string inbetween;
            int metacritic;
            int age;
            int recommendation;
            bool controller;
            bool windows;
            bool linux;
            bool mac;
            bool sp;
            bool mp;
            bool mpCoop;
            bool levelEditor;
            bool vr;

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 0:
                    Console.Clear();
                    MainMenu();
                    break;

                case 1:
                    Console.Clear();
                    Console.WriteLine("Insert name: ");
                    val[0] = Console.ReadLine();
                    FilterMenu();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Insert release date (Please use formating YYYY-MM-DD) : ");
                    DateTime releaseDate;
                    if(DateTime.TryParse(inbetween = Console.ReadLine(), out releaseDate))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[1] = inbetween;
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
                    if (Int32.TryParse(inbetween = Console.ReadLine(), out age))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[2] = inbetween;
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
                    if (Int32.TryParse(inbetween = Console.ReadLine(), out metacritic) && metacritic <= 100)
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[3] = inbetween;
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
                    if (Int32.TryParse(inbetween = Console.ReadLine(), out recommendation))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[4] = inbetween;
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
                    Console.WriteLine("Insert controller support (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out controller))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[5] = inbetween;
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
                    Console.WriteLine("Has Windows support (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out windows))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[6] = inbetween;
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
                    Console.WriteLine("Has Linux support (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out linux))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[7] = inbetween;
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
                    Console.WriteLine("Has Mac support (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out mac))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[8] = inbetween;
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
                    Console.WriteLine("Has singleplayer (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out sp))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[9] = inbetween;
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
                    Console.WriteLine("Has multiplayer (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out mp))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[10] = inbetween;
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
                    Console.WriteLine("Has multiplayer coop (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out mpCoop))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[11] = inbetween;
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
                    Console.WriteLine("Has level editor? (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out levelEditor))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[12] = inbetween;
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
                    Console.WriteLine("Supports VR? (1 or 0): ");
                    if (bool.TryParse(inbetween = Console.ReadLine(), out vr))
                    {
                        Console.Clear();
                        Console.WriteLine("Hurrah! \n \n");
                        val[13] = inbetween;
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

        //Prints Sorting menu
        public void SortBy()
        {
            Console.WriteLine("Selected methods: {0}, " + val[0], val[1], val[2],
                                  val[3], val[4], val[5], val[6], val[7], val[8],
                                  val[9], val[10]);

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
            Console.WriteLine("10: Clear");
            Console.WriteLine("11: Results");
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
                    Console.WriteLine("By ID: ");
                    val[0] = Console.ReadLine();
                    SortBy();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("By Name: ");
                    val[1] = Console.ReadLine();
                    SortBy();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("By release date: ");
                    val[2] = Console.ReadLine();
                    SortBy();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("By Metacritic score: ");
                    val[3] = Console.ReadLine();
                    SortBy();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("By DLC count: ");
                    val[4] = Console.ReadLine();
                    SortBy();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("By recommendation count: ");
                    val[5] = Console.ReadLine();
                    SortBy();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("By nº of players: ");
                    val[6] = Console.ReadLine();
                    SortBy();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("By player count: ");
                    val[7] = Console.ReadLine();
                    SortBy();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("By achievment count: ");
                    val[8] = Console.ReadLine();
                    SortBy();
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine("Clear");
                    val[9] = Console.ReadLine();
                    Array.Clear(val, 0, val.Length);
                    SortBy();
                    break;

                case 11:
                    Console.Clear();
                    Console.WriteLine("Big search");
                    val[10] = Console.ReadLine();
                    SortBy();
                    break;
            }
        }

        //Prints Search menu
        public void Search()
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
                    str[1] = Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("By Name: ");
                    str[2] = Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("By release date: ");
                    str[3] = Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("By Metacritic score: ");
                    str[4] = Console.ReadLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("By DLC count: ");
                    str[5] = Console.ReadLine();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("By recommendation count: ");
                    str[6] = Console.ReadLine();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("By nº of players: ");
                    str[7] = Console.ReadLine();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("By player count: ");
                    str[8] = Console.ReadLine();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("By achievment count: ");
                    str[9] = Console.ReadLine();
                    break;
            }
        }
    }
}

