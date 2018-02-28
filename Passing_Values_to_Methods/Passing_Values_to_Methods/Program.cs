using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPCSharp
{
    class Program
    {

        public static int myScore;

        static void Main(string[] args)
        {
            int delta = 100;
            int bravo = 500;
            myScore = 1000;
            Console.Write($"Setting the score to: {myScore}\n");
            ChangeScore(100);        // passing 200 to ChangeScore
            ChangeScore(400);
            ChangeScore(50);
            ChangeScore(-500);
            ChangeScore(200);
            ChangeScore(delta); // passing the value a variable to ChangeScore
            ChangeScore(bravo); 
            ChangeScore(delta + 200);  
            ChangeScore(bravo - 200); 
        }

        // A method   - void means it doesn't have a type
        public static void ChangeScore(int scoreDelta)
        {
            //DisplayScore();// the myScore before the change 1000
            Console.Write($"Changing the score by: {scoreDelta}  ");
            myScore = myScore + scoreDelta;
            DisplayScore(); // the myScore after the change 1200
            //Console.Write($"After ChangeScore\n\n");
        }

        // New method to display the score
        public static void DisplayScore()
        {
            Console.WriteLine($"Player score: {myScore}");
        }

    }
}


//Setting the score to: 1000
//Changing the score by: 100  Player score: 1100
//Changing the score by: 400  Player score: 1500
//Changing the score by: 50  Player score: 1550
//Changing the score by: -500  Player score: 1050
//Changing the score by: 200  Player score: 1250
//Changing the score by: 100  Player score: 1350
//Changing the score by: 500  Player score: 1850
//Changing the score by: 300  Player score: 2150
//Changing the score by: 300  Player score: 2450

//Press any key to continue...



