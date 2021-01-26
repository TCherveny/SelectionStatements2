using System;

namespace SelectionStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is Your favorite beverage?");

            var beverage = Console.ReadLine();
            
            switch (beverage)
            {
                case "water": 
                    Console.WriteLine("Water is healthy for you.");
                    break;

               case "milk":
                    Console.WriteLine("Ice cold milk with dinner is delicious");
                    break;

                case "soda":
                    Console.WriteLine("Soda is ok in moderation.");
                    break;

                case "kool-aid":
                    Console.WriteLine("Kool-Aid is good in moderation.");
                    break;


                case "beer":
                    Console.WriteLine("Beer is good ice cold");
                    break;

                case "whiskey":
                    Console.WriteLine("Different types of whiskey is an interesting topic.");
                    break;

                case "scotch":
                    Console.WriteLine("The history of scotch is interesting");
                    break;

                case "absinthe":
                    Console.WriteLine("Have you ever tripped out and seen the absinthe fairy?");
                    break;

                default:
                    Console.WriteLine($"Oh wow i dont know what to say to that!!! What does{beverage} taste like?");
                    break;











            }
        }
    }
}
