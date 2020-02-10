using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;
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
            List<int> movieIDs = new List<int>();
            Dictionary<int, string> movieTitles = new Dictionary<int, string>();
            Dictionary<int, string> movieGenres = new Dictionary<int, string>();
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
            //populate dictionaries
            while (!sR.EndOfStream)
            {
                string rough = sR.ReadLine();
                string[] split = rough.Split(',');

                int splitLength = split.Length;//fix broken titles
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
                Console.WriteLine(fixedTitle);
                int movieID;
                
                string[] genres = split[splitLength - 1].Split('|');
                try 
	            {	        
		            movieID = Convert.ToInt32(split[0]);
	            }
	            catch (FormatException)
	            {
		            break;
	            }
          
                movieIDs.Add(movieID);
                movieGenres.Add(movieID, split[splitLength-1]);
                if (!brokenTitle)
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
            sR.Close();
            bool exit = false;
            while (!exit)
            {
                //view movies
                if (userInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("1. View All Movies");
                    Console.WriteLine("2. View Action Movies");
                    Console.WriteLine("3. View Adventure Movies");
                    Console.WriteLine("4. View Drama Movies");
                    Console.WriteLine("5. View Comedy Movies");
                    Console.WriteLine("6. View Musical Movies");
                    Console.WriteLine("7. View Fantasy Movies");
                    Console.WriteLine("8. View Sci-Fi Movies");
                    Console.WriteLine("9. View Thriller Movies");
                    Console.WriteLine("10. View Children Movies");
                    Console.WriteLine("11. View Horror Movies");
                    Console.WriteLine("12. View Animation Movies");
                    Console.WriteLine("13. View Crime Movies");
                    Console.WriteLine("14. View War Movies");
                    Console.WriteLine("15. View Film-Noir Movies");
                    Console.WriteLine("16. View Western Movies");
                    Console.WriteLine("17. View Documentary Movies");
                    Console.WriteLine("18. View IMAX Movies");
                    Console.WriteLine("19. View Mystery Movies");
                    Console.WriteLine("20. Return To Menu");
                    
                    bool view = false;
                    while (!view)
                    {
                        string viewInput = Console.ReadLine();
                        string displayFormat = "{0,-6}\t{1,-45}\t{2}";
                        if(viewInput == "1")
                        {
                            //Console.Clear();
                            Console.WriteLine(displayFormat, "ID", "Title", "Genres");
                            for(int i = 0; i < movieIDs.Count(); i++)
                            {
                                int id = movieIDs[i];
                                string title = movieTitles[id];
                                Console.WriteLine(displayFormat, id, title, "edfrba");
                                view = true;
                                exit = true;
                            }
                        }
                        else if (viewInput == "2")
                        {
                            Console.Clear();

                        }
                        else if (viewInput == "3")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "4")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "5")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "6")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "7")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "8")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "9")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "10")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "11")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "12")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "13")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "14")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "15")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "16")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "17")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "18")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "19")
                        {
                            Console.Clear();
                        }
                        else if (viewInput == "20")
                        {
                            Console.Clear();
                            view = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter a number 1-20");
                        }
                        
                    }


                }
                //add movie
                else if (userInput == "2")
                {

                }
                else
                {

                }
            }
        }
    }
}
