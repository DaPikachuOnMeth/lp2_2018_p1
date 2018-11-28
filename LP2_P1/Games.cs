using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LP2_P1
{
    class Games
    {
        internal int ID { get; }
        internal string Name { get; }
        internal DateTime releaseDate { get; }
        internal int RequiredAge { get; }
        internal int DLCCount { get; }
        internal int Metacritic { get; }
        private int MovieCount;
        internal int RecommendationCount { get; }
        private int ScreenshotCount;
        internal int Owners { get; }
        internal int NumberOfPlayers { get; }
        internal int AchievementCount { get; }
        internal bool ControllerSupport { get; }
        internal bool PlatformWindows { get; }
        internal bool PlatformLinux { get; }
        internal bool PlatformMac { get; }
        internal bool CategorySinglePlayer { get; }
        internal bool CategoryMultiplayer { get; }
        internal bool CategoryCoop { get; }
        internal bool CategoryIncludeLevelEditor { get; }
        internal bool CategoryVRSupport { get; }
        private Uri SupportURL;
        private string AboutText;
        private Uri HeaderImage;
        private Uri Website;

        internal Games(string[] s)
        {
            ID = Convert.ToInt32(s[0]);
            Name = s[1];
            releaseDate = ReleaseDate(s[2]);
            RequiredAge = Convert.ToInt32(s[3]);
            DLCCount = Convert.ToInt32(s[4]);
            Metacritic = Convert.ToInt32(s[5]);
            MovieCount = Convert.ToInt32(s[6]);
            RecommendationCount = Convert.ToInt32(s[7]);
            ScreenshotCount = Convert.ToInt32(s[8]);
            Owners = Convert.ToInt32(s[9]);
            NumberOfPlayers = Convert.ToInt32(s[10]);
            AchievementCount = Convert.ToInt32(s[11]);
            ControllerSupport = Convert.ToBoolean(s[12]);
            PlatformWindows = Convert.ToBoolean(s[13]);
            PlatformLinux = Convert.ToBoolean(s[14]);
            PlatformMac = Convert.ToBoolean(s[15]);
            CategorySinglePlayer = Convert.ToBoolean(s[16]);
            CategoryMultiplayer = Convert.ToBoolean(s[17]);
            CategoryCoop = Convert.ToBoolean(s[18]);
            CategoryIncludeLevelEditor = Convert.ToBoolean(s[19]);
            CategoryVRSupport = Convert.ToBoolean(s[20]);
            SupportURL = PickedURL(s[21]);
            AboutText = s[22];
            HeaderImage = PickedURL(s[23]);
            Website = PickedURL(s[24]);
        }

        //Check if link is valid
        internal Uri ShowULR(string str)
        {
            Uri url;

            if(str == "none")
            {
                url = null;              
                return url;
            }

            else
            {
                bool validURL = Uri.TryCreate(str, UriKind.RelativeOrAbsolute, out url);
                if(validURL == false)
                {
                    url = null;
                }
                return url;
            }
        }

        //Check if date is valid
        internal DateTime ReleaseDate(string str)
        {
            DateTime dateTime;
            if (str == "none" || str == " ")
            {
                dateTime = default(DateTime);
                return dateTime;
            }

            else
            {
                bool validDate = DateTime.TryParse(str, out dateTime);
                if (validDate == false)
                {
                    dateTime = default(DateTime);
                    return dateTime;
                }
                return dateTime;
            }
        }

        //Check if date is valid
        internal Uri PickedURL(string str)
        {
            Uri url;
            if (str == "none" || str == " ") 
            {
                url = null;
                return url;
            }

            else
            {
                bool URL = Uri.TryCreate(str, UriKind.RelativeOrAbsolute, out url);
                if(URL == false)
                {
                    url = null;
                }
                return url;
            }
        }

        internal string PrintURL(Uri url)
        {
            string s;
            if (url == null)
            {
                s = "No URL.";
            }
            else
            {
                s = url.ToString();
            }
            return s;
        }

        internal int GetID()
        {
            return this.ID;
        }

        internal string GetName()
        {
            return this.Name;
        }


        internal void PrintInfo()
        {
            Console.WriteLine("id: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Rlease date: " + releaseDate.ToString());
            Console.WriteLine("Minimum age:" + RequiredAge);
            Console.WriteLine("DLCs:" + DLCCount);
            Console.WriteLine("Metacritic: " + Metacritic);
            Console.WriteLine("Movies: " + MovieCount);
            Console.WriteLine("Recomendation: " + RecommendationCount);
            Console.WriteLine("Screenshots :" + ScreenshotCount);
            Console.WriteLine("Purchases: " + Owners);
            Console.WriteLine("Players: " + NumberOfPlayers);
            Console.WriteLine("Achievements: " + AchievementCount);
            Console.WriteLine("Have controls: " + ControllerSupport);
            Console.WriteLine("Windows?: " + PlatformWindows);
            Console.WriteLine("Linux?: " + PlatformLinux);
            Console.WriteLine("MacOS?: " + PlatformMac);
            Console.WriteLine("Has sigle player?: " + CategorySinglePlayer);
            Console.WriteLine("Has multiplayer?: " + CategoryMultiplayer);
            Console.WriteLine("Has coop?: " + CategoryCoop);
            Console.WriteLine("Has level editor?: " + CategoryIncludeLevelEditor);
            Console.WriteLine("Has vr support?: " + CategoryVRSupport);
            Console.WriteLine("Client support: " + PrintURL(SupportURL));
            Console.WriteLine("About: " + AboutText);
            Console.WriteLine("Image url: " + PrintURL(HeaderImage));
            Console.WriteLine("Website: " + PrintURL(Website));
        }

        /*
        internal static int CompareById(Games game1, Games game2)
        {
            return game1.ID.CompareTo(game2.ID);
        }

        internal static int CompareByName(Games game1, Games game2)
        {
            return string.Compare(game1.Name, game2.Name);
        }

        internal static int CompareByDLC(Games game1, Games game2)
        {

        }
        */
    }
}
