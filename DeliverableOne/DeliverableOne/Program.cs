using System;
using System.Globalization;

namespace DeliverableOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //type conversion average needs to be double data type
            {

                Console.WriteLine("Please enter the first dollar amount.");
                decimal dollaramount1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the second dollar amount.");
                decimal dollaramount2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the third dollar amount.");
                decimal dollaramount3 = Convert.ToDecimal(Console.ReadLine());

                //total not displayed 
                //changed from double to decimal data type 

                decimal total = dollaramount1 + dollaramount2 + dollaramount3;

                Console.WriteLine("The average in US currency is {0:C2}", total / 3);

                if (dollaramount1 < dollaramount2 && dollaramount1 < dollaramount3)
                {
                    Console.WriteLine("the lowest number is {0}", dollaramount1);
                    if (dollaramount2 < dollaramount3)
                    {
                    }
                    else
                    {

                    }

                }
                else if (dollaramount2 < dollaramount1 && dollaramount2 < dollaramount3)
                {
                    Console.WriteLine("the lowest number is {0}", dollaramount2);

                }
                else if (dollaramount3 < dollaramount1 && dollaramount3 < dollaramount1)
                {
                    Console.WriteLine("the lowest number is {0}", dollaramount3);

                }
                else
                {
                    Console.WriteLine("The values are equal");

                }

                //Show output in requested formats


            }
        }
    }
}

