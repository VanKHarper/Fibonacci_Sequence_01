using System;

namespace Fib_Sequencer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fibString = "Fibinachi Number: ";
            int fibCalculatedInt = 0;
            string fibDisplayString = "";
            int i = 0;
            int x = 1;
            int y = 0;
            int z = 0;

            string evenString = "Even ";
            string oddString = "Odd ";
            string initialFibString = "The first fib Number is ";

            int evenI = 0;
            int oddI = 0;
            int evenInt = 0;
            int oddInt = -1;
            int countI = 0;
            int arraySize = 1001;
            int countArraySize = arraySize * 2;
            int[] countArray = new int[countArraySize];
            int[] evenArray = new int [arraySize];
            int[] oddArray = new int[arraySize];


            do
            {
                countArray[countI] = countI;                
                Console.WriteLine("Count Array " + countI + " : " + countArray[countI]);
                countI++;
            } while (countI < countArraySize);

            do
            {                
                evenInt = evenInt + 2;
                string displayEven = $"Even Nubmber {evenI}: {evenInt}";
                Console.WriteLine(displayEven);
                evenArray[evenI] = evenInt;
                Console.WriteLine("Even Array " + evenI + " : " + evenArray[evenI]);
                evenI++;
            } while (evenI < arraySize);   
            
            do
            {                
                oddInt = oddInt + 2;
                string displayOdd = $"Odd Nubmber {oddI}: {oddInt}";
                Console.WriteLine(displayOdd);
                oddArray[oddI] = oddInt;
                Console.WriteLine("Odd Array "+ oddI + " : " + oddArray[oddI]);
                oddI++;
            } while (oddI < arraySize);

            while (i < 1)            
            {
                fibCalculatedInt = x + y + z;
                z = fibCalculatedInt;
                x = x + x;

                fibDisplayString = initialFibString + fibCalculatedInt;
                Console.WriteLine(fibDisplayString);
                i++;
            }
                                    

                    while (i == evenArray[i])
                    {
                        fibCalculatedInt = x + y;
                        z = fibCalculatedInt;

                        fibDisplayString = evenString + fibString + fibCalculatedInt;
                        Console.WriteLine(fibDisplayString);
                        i++;
                    }
                    while (i == oddArray[i])
                    {
                        fibCalculatedInt = z + y;
                        z = fibCalculatedInt;

                        fibDisplayString = oddString + fibString + fibCalculatedInt;
                        Console.WriteLine(fibDisplayString);
                        i++;
                    }

            while (i == countArray[i])
            {
                i++;
            }

                    //if (i == countArraySize || i > countArraySize)
                    //{
                    //    break;
                    //}
                    //else
                    //{
                    //    i++;
                    //}

               
                
                                         
        }
    }
}