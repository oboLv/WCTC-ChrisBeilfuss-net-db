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
            Console.WriteLine("1. View All Movies");
            Console.WriteLine("2. Add Movie");
            string userInput = Console.ReadLine();
            //populate dictionaries
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
            while(!sR.EndOfStream)
            {

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
