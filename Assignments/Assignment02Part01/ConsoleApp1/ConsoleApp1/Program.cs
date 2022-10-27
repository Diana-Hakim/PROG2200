using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;

            string theZone;
            do
            {
                // get the destination zone
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();

                // if the user wrote "exit" then terminate the program,
                // otherwise continue 
                if (!theZone.Equals("exit"))
                {
                    // given the zone, retrieve the associated shipping info
                    theDest = ShippingDestination.getDestinationInfo(theZone);

                    // if there's no associated info, then the user entered
                    // an invalid zone, otherwise continue
                    if (theDest != null)
                    {
                        // ask for the price and convert the string to a decimal number


                        // Each ShippingDestination object has a function called calcFees,
                        // use that as the delegate for calculating the fee
                        //
                        //CHANGES HERE: if itemPrice > 0 then exit
                        while (true)
                        {
                            Console.WriteLine("What is the item price?");
                            string thePriceStr = Console.ReadLine();
                            decimal itemPrice = decimal.Parse(thePriceStr);
                            //CHANGES HERE: if itemPrice > 0 then exit
                            if (itemPrice > 0)
                            {
                                theDel = theDest.calcFees;
                                // For high-risk zones, we tack on the delegate that adds more
                                if (theDest.m_isHighRisk)
                                {
                                    theDel += delegate (decimal thePrice, ref decimal itemFee)
                                    {
                                        itemFee += 25.0m;
                                    };
                                }
                                // CHANGES HERE: SET VALUE
                                decimal theFee = 0.0m;
                                theDel(itemPrice, ref theFee);
                                Console.WriteLine("The shipping fees are: {0}", theFee);
                                break;
                            }
                            else
                            {//CHANGES HERE: BAD INPUT WILL PROMPT USER AGAIN
                                Console.WriteLine("Bad Input Try Again");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hmm, you seem to have entered an uknown destination. Try again or 'exit'");
                    }
                }
            } while (theZone != "exit");
        }
    }
}
