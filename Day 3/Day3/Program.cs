using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsAll = File.ReadAllLines("items.txt").ToList();
            /* var compartment = Populate(itemsAll);
           PART ONE
            List<string> firstCompartment = compartment.Item1; 
            List<string> secondCompartment = compartment.Item2;
            int results = Points(firstCompartment, secondCompartment);*/

            int result = ResultTwo(itemsAll);

            Write(result);

            ReadKey();
        }
        //PART TWO

        static int ResultTwo(List<string> items)
        {
            List<int> pointList = new();
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < items.Count; i+=3)
            {
            
                foreach (char letter in letters)
                {
                    bool trueOne = items[i].Contains(letter);
                    bool trueTwo = items[i + 1].Contains(letter);
                    bool trueThree = items[i + 2].Contains(letter);

                    if (trueOne && trueTwo  && trueThree)
                    {
                        pointList.Add(letters.IndexOf(letter)+1);
                        break;
                    }
                }

            }
            int sum = pointList.Sum();
            return sum;


        }

        /*  //PART ONE
          static (List<string>, List<string>) Populate(List<string> items)
          {
              List<string> firstCompartment = new();
              List<string> secondCompartment = new();

              foreach (string item in items)
              {
                  firstCompartment.Add(item.Substring(0, item.Length /2));      
                  secondCompartment.Add(item.Substring(item.Length / 2, item.Length - (item.Length / 2)));  
              }

              return (firstCompartment, secondCompartment);
          }

          static int Points (List<string> first, List<string> second)
          {
              List<int> pointList = new();
              for(int i =0; i < first.Count; ++i)
              { 
                  string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
                  string one = first[i];
                  string two = second[i];

                  foreach(char letter in two)
                  {
                      bool trues = one.Contains(letter.ToString());

                      if (trues == true)
                      {
                          int index = letters.IndexOf(letter);

                          if (char.IsUpper(letter))
                              pointList.Add(index+1);
                          else
                              pointList.Add(index+1);

                          WriteLine(one);
                          WriteLine(two);
                          Write(letter);
                          Write(index + 1 + "\n");
                          break;
                      } 
                  }
              }
              int sum = pointList.Sum();
              return sum;
          }*/
    }
}