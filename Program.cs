using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay3
{
    internal class Program
    {
        enum Monthsofyear { Jan =1, Feb =2, Mar -3 };
        static void Main(string[] args)
        {

            Console.WriteLine("First Month " + (int)Monthsofyear.Jan);
            Console.WriteLine("Second Month " + Monthsofyear.Feb);

            Console.ReadKey();
            //DataTypes

            /*byte myByte =12;
            sbyte mySbyte =1;
            short myShort =12;
            int myInt =12;
            long myLong = 12;
            float myFloat = 12.5F;
            double myDouble = 12.5;
            decimal myDecimal = 12  ;
            char myChar ='A';
            string myString ="Our String";
            DateTime myDateTime=new DateTime(day:12,month:12,year:2022);
            bool myBool = false;*/

            /*try
            {
                byte ourByte;
                Console.WriteLine("Enter a number");
                ourByte = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Number is " + ourByte);
                Console.ReadKey();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format exception "+ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("overflow exception "+ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!! "+ex.Message);
            }
            finally { 
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }*/




        }
    }
}
