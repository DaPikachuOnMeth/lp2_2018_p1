using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LP2_P1
{
    class Games
    {
        private int ID;
        private string Name;
        private DateTime releaseDate;
        private int RequiredAge;
        private int DLCCount;
        private int Metacritic;
        private int MovieCount;
        private int RecommendationCount;
        private int ScreenshotCount;
        private int Owners;
        private int NumberOfPlayers;
        private int AchievementCount;
        private bool ControllerSupport;
        private bool PlatformWindows;
        private bool PlatformLinux;
        private bool PlatformMac;
        private bool CategorySinglePlayer;
        private bool CategoryMultiplayer;
        private bool CategoryCoop;
        private bool CategoryIncludeLevelEditor;
        private bool CategoryVRSupport;
        private Uri SupportURL;
        private string AboutText;
        private Uri HeaderImage;
        private Uri Website;

        public Games(string[] s)
        {
            ID = Convert.ToInt32(s[0]);
            Name = s[1];
            releaseDate = Convert.ToDateTime(s[3]);
            RequiredAge = Convert.ToInt32(s[4]);
            DLCCount = Convert.ToInt32(s[5]);
            Metacritic = Convert.ToInt32(s[6]);
            MovieCount = Convert.ToInt32(s[7]);
            RecommendationCount = Convert.ToInt32(s[8]);
            ScreenshotCount = Convert.ToInt32(s[9]);
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
        public Uri ShowULR(string str)
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
        public DateTime ReleaseDate(string str)
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
        public Uri PickedURL(string str)
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

        public string PrintURL(Uri url)
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

        public int GetID()
        {
            return this.ID;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void PrintInfo()
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
    }
}
