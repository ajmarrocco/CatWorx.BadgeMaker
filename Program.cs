using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variable myScoreboard, a dictionary has a string key and an integer value
            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
            // // Adds multiple lines to the data
            // myScoreBoard.Add("firstInning", 10);
            // myScoreBoard.Add("secondInning", 20);
            // myScoreBoard.Add("thirdInning", 30);
            // myScoreBoard.Add("fourthInning", 40);
            // myScoreBoard.Add("fifthInning", 50);
            // Equivalent of top
            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
            //     { "firstInning", 10 },
            //     { "secondInning", 20},
            //     { "thirdInning", 30},
            //     { "fourthInning", 40},
            //     { "fifthInning", 50}
            // };
            // Console.WriteLine("----------------");
            // Console.WriteLine("  Scoreboard");
            // Console.WriteLine("----------------");
            // Console.WriteLine("Inning |  Score");
            // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);
            // Console.WriteLine($"score is {myScoreBoard["firstInning"]}");
            string[] favFoods = new string[3]{"pizza", "doughnuts", "icecream"};
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("My favorite foods are {0}, {1}, and {2}", firstFood, secondFood, thirdFood);
            Console.WriteLine($"I like {firstFood}, {secondFood}, and {thirdFood}");
        }
    }
}
