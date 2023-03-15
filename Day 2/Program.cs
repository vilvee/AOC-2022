namespace Day_2
{
    using System;
    using System.Numerics;
    using System.Reflection.Metadata.Ecma335;
    using System.Text.RegularExpressions;
    using static System.Console;

    internal class Program
    {
        /*
        Rock = 'A' 'X',
        Paper = 'B' 'Y', 
        Scissors = 'C' 'Z'*/
        static void Main()
        {
            int totalScore = 0; 

            string[] list = File.ReadAllLines("play.txt").ToArray();

            for (int i = 0; i < list.Length; i++)
            {
                string[] word = list[i].Split(null, 2);

                Enum.TryParse(word[0], out Op ops);
                Enum.TryParse(word[1], out Me me);

                int playScore = WinLoseDraw(ops, me);
                totalScore += playScore + (int)me;
            }

            Write(totalScore);

            ReadLine();
        }

        static int WinLoseDraw(Op one, Me two)
        {
            int lose = 0;
            int draw = 3;
            int win = 6;

            if ((int)one == (int)two)
            {
                return draw;
            }
            else if ((int)one == 1 && (int)two == 3 || (int)one == 2 && (int)two == 1 || (int)one == 3 && (int)two == 2)
            {
                return lose;
            }
            else
            {
                return win;
            }
        }

        enum Op
        {
            A = 1,
            B = 2,
            C = 3,
        }

        enum Me
        {
            X = 1,
            Y = 2,
            Z = 3,
        }
    }
}