using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NETDBassign3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. View Movies");
            Console.WriteLine("2. Add Movie");
            Console.WriteLine("3. Exit App");
            string userInput = Console.ReadLine();
            //dictionaries/lists
            Dictionary<int, int> movieIDs = new Dictionary<int, int>();
            Dictionary<int, string> movieTitles = new Dictionary<int, string>();
            List<int> action = new List<int>();
            List<int> adventure = new List<int>();
            List<int> drama = new List<int>();
            List<int> comedy = new List<int>();
            List<int> musical = new List<int>();
            List<int> fantasy = new List<int>();
            List<int> scifi = new List<int>();
            List<int> thriller = new List<int>();
            List<int> children = new List<int>();
            List<int> horror = new List<int>();
            List<int> animation = new List<int>();
            List<int> crime = new List<int>();
            List<int> war = new List<int>();
            List<int> noir = new List<int>();
            List<int> western = new List<int>();
            List<int> documentary = new List<int>();
            List<int> imax = new List<int>();
            List<int> mystery = new List<int>();

            StreamReader sR = new StreamReader("movies.csv");
            while(!sR.EndOfStream)//populate dictionaries
            {
                string rough = sR.ReadLine();
                string[] split = rough.Split(',');

                int splitLength = split.Length();//fix broken titles
                bool brokenTitle = false;
                string fixedTitle = "";
                if(splitLength > 3)
                    {
                        for(int i = 1; i <= splitLength-1; i++)
                        {
                            fixedTitle = $"{fixedTitle} + {split[i]}";
                        }
                        brokenTitle = true;
                    }

                string[] genres = split[splitLength - 1].Split('|');
                int movieID = Convert.ToInt32(split[0]);
                movieIDs.Add(movieID, movieID);
                if(!brokenTitle)
                    {
                        movieTitles.Add(movieID, fixedTitle);
                    }
                else
                    {
                        movieTitles.Add(movieID, split[1]);
                    }
                foreach(string genre in genres) //sort movies into genres
                    {
                        if(genres.Contains<string>("Action"))
                        {
                            action.Add(movieID);
                        }
                        if(genres.Contains<string>("Adventure"))
                        {
                            adventure.Add(movieID);
                        }
                        if(genres.Contains<string>("Drama"))
                        {
                            drama.Add(movieID);
                        }
                        if(genres.Contains<string>("Comedy"))
                        {
                            comedy.Add(movieID);
                        }
                        if(genres.Contains<string>("Musical"))
                        {
                            musical.Add(movieID);
                        }
                        if(genres.Contains<string>("Fantasy"))
                        {
                            fantasy.Add(movieID);
                        }
                        if(genres.Contains<string>("Sci-Fi"))
                        {
                            scifi.Add(movieID);
                        }
                        if(genres.Contains<string>("Thriller"))
                        {
                            thriller.Add(movieID);
                        }
                        if(genres.Contains<string>("Children"))
                        {
                            children.Add(movieID);
                        }
                        if(genres.Contains<string>("Horror"))
                        {
                            horror.Add(movieID);
                        }
                        if(genres.Contains<string>("Animation"))
                        {
                            animation.Add(movieID);
                        }
                        if(genres.Contains<string>("Crime"))
                        {
                            crime.Add(movieID);
                        }
                        if(genres.Contains<string>("War"))
                        {
                            war.Add(movieID);
                        }
                        if(genres.Contains<string>("Film-Noir"))
                        {
                            noir.Add(movieID);
                        }
                        if(genres.Contains<string>("Western"))
                        {
                            western.Add(movieID);
                        }
                        if(genres.Contains<string>("Documentary"))
                        {
                            documentary.Add(movieID);
                        }
                        if(genres.Contains<string>("IMAX"))
                        {
                            imax.Add(movieID);
                        }
                        if(genres.Contains<string>("Mystery"))
                        {
                            mystery.Add(movieID);
                        }
                        
                    }
            }

            if(userInput == "1")
            {
                

            }
            else if(userInput == "2")
            {

            }
            else
            {

            }
        }
    }
}
