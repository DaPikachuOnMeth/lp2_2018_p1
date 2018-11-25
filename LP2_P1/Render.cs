using System;

namespace LP2_P1
{
    class Render
    {
        public Render() { }

        public string[] val = new string[15] { " ", " ", " ", " ", " ", " ",
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

            switch (input)
            {
                case 0:
                    System.Environment.Exit(1);
                    break;

                case 1:
                    SearchBy();
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
        public void SearchBy()
        {
            Console.WriteLine("Selected methods: {1} {2} {3} {4} {5} {6} {7} " +
                              "{8} {9} {10} {11} {12} {13} {14}", val[0],
                              val[1], val[2], val[3], val[4], val[5], val[6],
                              val[7], val[8], val[9], val[10], val[11], val[12], val[13]);

            Console.WriteLine("Search by: ");
            Console.WriteLine("1: Name");
            Console.WriteLine("2: Release date");
            Console.WriteLine("3: Age");
            Console.WriteLine("4: Metacritic");
            Console.WriteLine("5: Reccomendation score");
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
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Insert release date: ");
                    val[1] = Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Insert age: ");
                    val[2] = Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Insert metacritic score: ");
                    val[3] = Console.ReadLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Insert reccomendation count: ");
                    val[4] = Console.ReadLine();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Insert controller support (1 or 0): ");
                    val[5] = "false";
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Has Windows support (1 or 0): ");
                    val[6] = "false";
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("Has Linux support (1 or 0): ");
                    val[7] = "false";
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("Has Mac support (1 or 0): ");
                    val[8] = "false";
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine("Has singleplayer (1 or 0): ");
                    val[9] = "false";
                    break;

                case 11:
                    Console.Clear();
                    Console.WriteLine("Has multiplayer (1 or 0): ");
                    val[10] = "false";
                    break;

                case 12:
                    Console.Clear();
                    Console.WriteLine("Has multiplayer coop (1 or 0): ");
                    val[11] = "false";
                    break;

                case 13:
                    Console.Clear();
                    Console.WriteLine("Has level editor? (1 or 0): ");
                    val[12] = "false";
                    break;

                case 14:
                    Console.Clear();
                    Console.WriteLine("Supports VR? (1 or 0): ");
                    val[13] = "false";
                    break;

                case 15:
                    Console.Clear();
                    Console.WriteLine("Insert PlatformMac (1 or 0): ");
                    val[14] = "false";
                    break;
            }
        }

        //Prints Sorting menu
        public void SortBy()
        {
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
                    Console.WriteLine("By ID: ");
                    val[1] = Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("By Name: ");
                    val[2] = Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("By release date: ");
                    val[3] = Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("By Metacritic score: ");
                    val[4] = Console.ReadLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("By DLC count: ");
                    val[5] = Console.ReadLine();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("By recommendation count: ");
                    val[6] = Console.ReadLine();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("By nº of players: ");
                    val[7] = Console.ReadLine();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("By player count: ");
                    val[8] = Console.ReadLine();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("By achievment count: ");
                    val[9] = Console.ReadLine();
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

