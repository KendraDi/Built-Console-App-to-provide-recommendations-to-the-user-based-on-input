using System;
using System.Globalization;
using System.Collections.Generic;

//added namespaces for country currencies, attempt to create a list

namespace DeliverableOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                //input from user proper conversion for money (decimal data type)
                Console.WriteLine("Please enter the first dollar amount.");
                decimal dollaramount1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the second dollar amount.");
                decimal dollaramount2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the third dollar amount.");
                decimal dollaramount3 = Convert.ToDecimal(Console.ReadLine());

            //total but instructions do not require total to be displayed

                decimal total = dollaramount1 + dollaramount2 + dollaramount3;

                //display the average

                Console.WriteLine("The Average is {0:C2}.", total / 3);

                if (dollaramount1 < dollaramount2 && dollaramount1 < dollaramount3)
                {
                    Console.WriteLine("The smallest amount is {0:C2}.", dollaramount1);
                    if (dollaramount2 < dollaramount3)
                    {
                        Console.WriteLine("The largest amount is {0:C2}.", dollaramount3);
                        Console.WriteLine("The total in the various currencies are:");
                        Console.WriteLine(total.ToString("C2", CultureInfo.CurrentCulture));
                        Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
                        Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
                        Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("th")));
                    }

                }
                else if (dollaramount2 < dollaramount1 && dollaramount2 < dollaramount3)
                {
                    Console.WriteLine("The smallest amount is {0:C2}.", dollaramount2);
                    if (dollaramount1 < dollaramount3)
                    {
                        Console.WriteLine("The largest number is {0:C2}.", dollaramount3);
                        Console.WriteLine("The total in the various currencies are:");
                        Console.WriteLine(total.ToString("C2", CultureInfo.CurrentCulture));
                        Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
                        Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
                        Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("th")));

                    }
                    else if (dollaramount3 < dollaramount1 && dollaramount3 < dollaramount2)
                    {
                        Console.WriteLine("The smallest amount is {0:C2}.", dollaramount3);
                        if (dollaramount2 < dollaramount3)
                        {
                            Console.WriteLine("The largest amount is {0:C2}.", dollaramount1);
                            Console.WriteLine("The total in the various currencies are:");
                            Console.WriteLine(total.ToString("C2", CultureInfo.CurrentCulture));
                            Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
                            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
                            Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("th")));

                        }
                        else
                        {
                            Console.WriteLine("The values are equal!");

                        }


                        //could not find the proper currency function for Thailand
                        //tested cases but still issues - need to work on how to use list function and arrays
                    }
                }
            }
        }
    }
}
