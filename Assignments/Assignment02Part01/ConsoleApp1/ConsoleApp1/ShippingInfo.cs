using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
        // declare the delegate type used to calculate the fees
        public delegate void ShippingFeesDelegate(decimal thePrice, ref decimal fee);

        // This is a base class that is used as a foundation 
        // for each of the destination zones
        abstract class ShippingDestination
        {
            public bool m_isHighRisk;
            public virtual void calcFees(decimal price, ref decimal fee) { }


            // This static method returns an actual ShippingDestination object
            // given the name of the destination, or null if none exists

            public static ShippingDestination getDestinationInfo(string dest)
            {
            dest = dest.ToLower(); //CHANGES
                if (dest.Equals("zone1"))
                {
                    return new Dest_Zone1();
                }
                else if (dest.Equals("zone2"))
                {
                    return new Dest_Zone2();
                }
                else if (dest.Equals("zone3"))
                {
                    return new Dest_Zone3();
                }
                else if (dest.Equals("zone4"))
                {
                    return new Dest_Zone4();
            }//CHANGES HERE: ADDED ABILTIY FOR USERS TO ACCESS CLASS
            else if (dest.Equals("zone5"))
                {
                    return new Dest_Zone5();
                }
            else return null;
            }
}

        // Now we define implementation classes for each of the real shipping
        // destinations. We can add as many as we like as the need arises

        class Dest_Zone1 : ShippingDestination
        {
            public Dest_Zone1()
            {
                this.m_isHighRisk = false;
            }
            public override void calcFees(decimal price, ref decimal fee)
            {
           
                fee = price * 0.25m;
            fee = Sale.calcSales(fee, this.m_isHighRisk);
        }
        }

        class Dest_Zone2 : ShippingDestination
        {
            public Dest_Zone2()
            {
                this.m_isHighRisk = true;
            }
            public override void calcFees(decimal price, ref decimal fee)
            {
                fee = price * 0.12m;
            fee = Sale.calcSales(fee, this.m_isHighRisk);
        }
        }

        class Dest_Zone3 : ShippingDestination
        {
            public Dest_Zone3()
            {
                this.m_isHighRisk = false;
            }
            public override void calcFees(decimal price, ref decimal fee)
            {
                fee = price * 0.08m;
            fee = Sale.calcSales(fee, this.m_isHighRisk);
        }
        }

        class Dest_Zone4 : ShippingDestination
        {
            public Dest_Zone4()
            {
                this.m_isHighRisk = true;
            }
            public override void calcFees(decimal price, ref decimal fee)
            {
                fee = price * 0.04m;
            fee = Sale.calcSales(fee, this.m_isHighRisk);
        }
        }
    //CHANGES HERE: ADDED ZONE 5: LOW RISK AND 0.02M
    class Dest_Zone5 : ShippingDestination
    {
        public Dest_Zone5()
        {
            this.m_isHighRisk = false;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {//CHANGES HERE: CALC FEE SAME AS OTHER METHODS
            fee = price * 0.02m;
            fee = Sale.calcSales(fee, this.m_isHighRisk);
        }
    }
    // CHANGES HERE: ANONYMOUS DELEGATE  
    class Sale : ShippingDestination {
            public static decimal calcSales(decimal fee, bool rate){
            // CHANGES HERE: IF FEE IS OVER 100 AND THE RISK IS LOW 
                if (!rate && (100 < fee)){
                    int reducedPrice = 10;
                    Console.Write("SALE: price was: " + fee);
                    fee -= reducedPrice;
                    Console.WriteLine(", price was reduced by $" + reducedPrice + " for low risk zones over 100$");
                }
                return fee;
            }

        }

    }


///// Explain the new modifications on this program using comment lines added inside the project’s codes. 
/// CTL + F to find CHANGES in document 
///
//// Also, explain the character ‘m’ stands for what and why it is included in the following code: fee = price * 0.12m 
///
/// m or M is used to represnts a literal decimal. Often used for decimal money, like in example provided.
///