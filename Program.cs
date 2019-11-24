using System;

namespace Fib_Sequencer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fibString = "Fibinachi Number";
            int i = 1;
            int x = 1;
            int y = 1;
            int z = 2;

            int evenI = 0;
            int oddI = 0;
            int evenInt = 0;
            int oddInt = -1;
            int[] evenArray = new int [1001];
            int[] oddArray = new int[1001];
           

            do
            {                
                evenInt = evenInt + 2;
                string displayEven = $"Even Nubmber {evenI}: {evenInt}";
                Console.WriteLine(displayEven);
                evenArray[evenI] = evenInt;
                Console.WriteLine("Even Array " + evenI + " : " + evenArray[evenI]);
                evenI++;
            } while (evenI < 1001);   
            
            do
            {                
                oddInt = oddInt + 2;
                string displayOdd = $"Odd Nubmber {oddI}: {oddInt}";
                Console.WriteLine(displayOdd);
                oddArray[oddI] = oddInt;
                Console.WriteLine("Odd Array "+ oddI + " : " + oddArray[oddI]);
                oddI++;
            } while (oddI < 1001);

            do
            {
                if (i < 2)
                {
                    string msg_01 = $"{fibString} {i}: {x}";
                    Console.WriteLine(msg_01);
                    i++;
                }               
                else
                {
                    break;
                }

            } while (i < 2);

            do
            {              
                if(i > 2 && i < 3)
                {
                    z = x + y;
                    string msg_02 = $"{fibString} {i}: {z}";
                    Console.WriteLine(msg_02);
                    i++;
                }               
                else
                {
                    break;
                }

            } while (i < 3 && i > 2);

            do
            {               
                if (i < 1001)
                {
                    y = z + y;
                    string msg_02 = $"{fibString} {i}: {y}";
                    Console.WriteLine(msg_02);
                    i++;
                }
                else if (i == 1000)
                {
                    break;
                }
                else
                {
                    break;
                }

            } while (i < 1001);

        }
    }
}