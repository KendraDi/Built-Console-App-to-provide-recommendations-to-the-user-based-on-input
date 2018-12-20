using System;

namespace DeliverableTwo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello user, what are you in the mood for?");


            Console.Write("Here are your options: ");
            Console.Write(Environment.NewLine);
            Console.WriteLine("1. Action ");
            Console.WriteLine("2. Chill times ");
            Console.WriteLine("3. Danger ");
            Console.WriteLine("4. Good Food ");
            Console.WriteLine("Please enter 1, 2, 3 or 4 corresponding to the activities shown above.");
            

            //Recommendation

            int option;

            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {case 1:
                Console.WriteLine("How many people are you bringing with you?");
                    int x = Convert.ToInt32(Console.ReadLine());
                if (x==0) 
                    {
                      Console.WriteLine("Okay if you are in the mood for action, then you should go Stock Car Racing and travel in sneakers.");
                      Console.WriteLine("Goodbye!");

                    }

                if(x > 0 && x <= 4)
                    {
                        Console.WriteLine("Okay if you are in the mood for action, then you should go Stock Car Racing and travel in a sedan.");
                        Console.WriteLine("Goodbye!");

                    }
                    if (x >= 5 && x<= 10)
                    {
                        Console.WriteLine("Okay if you are in the mood for action, then you should go Stock Car Racing and travel in a Volkswagen bus.");
                        Console.WriteLine("Goodbye!");

                    }

                    if (x >= 11)
                    {
                        Console.WriteLine("Okay if you are in the mood for action, then you should go Stock Car Racing and travel in an airplane.");
                        Console.WriteLine("Goodbye!");

                    }
                    break;

            case 2:

                    Console.WriteLine("How many people are you bringing with you?");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 0)
                    {
                        Console.WriteLine("Okay if you are in the mood for chilling, then you should go Hiking and travel in sneakers.");
                        Console.WriteLine("Goodbye!");
                    }

                    if (y > 0 && y <= 4)
                    {
                        Console.WriteLine("Okay if you are in the mood for chilling, then you should go Hiking and travel in a sedan.");
                        Console.WriteLine("Goodbye!");

                    }
                    if (y >= 5 && y <= 10)
                    {
                        Console.WriteLine("Okay if you are in the mood for chilling, then you should go Hiking and travel in a Volkswagen bus.");
                        Console.WriteLine("Goodbye!");

                    }

                    if (y >= 11)
                    {
                        Console.WriteLine("Okay if you are in the mood for chilling, then you should go Hiking and travel in an airplane.");
                        Console.WriteLine("Goodbye!");

                    }
                    break;


                case 3:
                    Console.WriteLine("How many people are you bringing with you?");
                    int z = Convert.ToInt32(Console.ReadLine());
                    if (z == 0)
                    {
                        Console.WriteLine("Okay if you are in the mood for danger, then you should go Skydiving and travel in sneakers.");
                        Console.WriteLine("Goodbye!");
                    }

                    if (z > 0 && z <= 4)
                    {
                        Console.WriteLine("Okay if you are in the mood for danger, then you should go Skydiving and travel in a sedan.");
                        Console.WriteLine("Goodbye!");
                    }
                    if (z >= 5 && z <= 10)
                    {
                        Console.WriteLine("Okay if you are in the mood for danger, then you should go Skydiving and travel in a Volkswagen bus.");
                        Console.WriteLine("Goodbye!");
                    }

                    if (z >= 11)
                    {
                        Console.WriteLine("Okay if you are in the mood for danger, then you should go Skydiving and travel in an airplane.");
                        Console.WriteLine("Goodbye!");
                    }
                    break;


            case 4:
                    Console.WriteLine("How many people are you bringing with you?");
                    int w = Convert.ToInt32(Console.ReadLine());
                    if (w == 0)
                    {
                        Console.WriteLine("Okay if you are in the mood for good food, then you should go to Taco Bell and travel in sneakers.");
                        Console.WriteLine("Goodbye!");
                    }

                    if (w > 0 && w <= 4)
                    {
                        Console.WriteLine("Okay if you are in the mood for good food, then you should go to Taco Bell and travel in a sedan.");
                        Console.WriteLine("Goodbye!");

                    }
                    if (w >= 5 && w <= 10)
                    {
                        Console.WriteLine("Okay if you are in the mood for good food, then you should go to Taco Bell and travel in a Volkswagen bus.");
                        Console.WriteLine("Goodbye!");
                    }

                    if (w >= 11)
                    {
                        Console.WriteLine("Okay if you are in the mood for good food, then you should go to Taco Bell and travel in an airplane.");
                        Console.WriteLine("Goodbye!");
                    }
                    break;


                default:
                    Console.WriteLine("Your input was not understood.");

                    break;
           

            }



        } 
    } 
}
