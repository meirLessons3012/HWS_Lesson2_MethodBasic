using System;

namespace HWS_Lesson2_MethodBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exr 8:
            PrintNumberName(1);

            //Exr 9:
            PrintNumbers(2, 13);
            PrintNumbers(46, 50);

            //Exr 10:
            PrintNumbersWithoutLoop(1, 10);

            //Exr 11:
            bool isPrime1 = IsPrime(7);// true
            bool isPrime2 = IsPrime(15);// false

            //Exr 12:
            int[] myArrayToCheckPrimeNumbers = { 3, 5, 7, 11, 15, 22, 36 };
            PrintIfNumberFromArrayIsPrime(myArrayToCheckPrimeNumbers);

            //Exr 13:
            int[] firstArray = { 3, 11, 100, 52,13,77 };
            int[] secondArray = { 6, 15, 92, 48 };
            WhichArrayIsBigger(firstArray, secondArray);

            //Exr 14:
            int[,] mySuperArray = CreateRandomMatrix();
            PrintIfExist(mySuperArray);
            PrintIfExist(mySuperArray);
            PrintIfExist(mySuperArray);
        }

        //Exr 8
        public static void PrintNumberName(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }

        //Exr 9
        private static bool PrintNumbers(int fromNumber, int toNumber)
        {
            for (int i = fromNumber; i <= toNumber; i++)
            {
                Console.WriteLine(i);
            }
            if (toNumber > 10)
                return true;
            else
                return false;
        }

        //Exr 10
        private static void PrintNumbersWithoutLoop(int curNumber, int toNumber)
        {
            Console.WriteLine(curNumber++);
            if (curNumber <= toNumber)
                PrintNumbersWithoutLoop(curNumber, toNumber);
        }

        //Exr 11
        private static bool IsPrime(int number)
        {
            if (number <= 1)
                return false; 
            int curNumber = 2;
            while (curNumber < number)
            {
                if (number % curNumber == 0)
                    return false;
                curNumber++;
            }
            return true;
        }
    
        //Exr 12
        public static void PrintIfNumberFromArrayIsPrime(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(IsPrime(array[i]))
                    Console.WriteLine($"{array[i]} Is Prime");
            }
        }

        //Exr 13:
        private static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sumFirstArray = 0;
            int sumSecondArray = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sumFirstArray += arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                sumSecondArray += arr2[i];
            }
            //long way
            //if (sumFirstArray > sumSecondArray)
            //    return 1;
            //else if (sumFirstArray == sumSecondArray)
            //    return 0;
            //else
            //    return -1;
            //short way
            return sumFirstArray - sumSecondArray;

        }

        //Exr 14:
        private static int[,] CreateRandomMatrix()
        {
            Random r = new Random();
            //int[,] mySuperArray = new int[r.Next(1,11), r.Next(1,20)];
            int[,] mySuperArray = new int[10, 10];
            for (int i = 0; i < mySuperArray.GetLength(0); i++)
            {
                for (int j = 0; j < mySuperArray.GetLength(1); j++)
                {
                    mySuperArray[i, j] = r.Next(101);
                }
            }
            return mySuperArray;
        }

        private static void PrintIfExist(int[,] theMatrix)
        {
            int numFromUser = int.Parse(Console.ReadLine());
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    if (theMatrix[i, j] == numFromUser)
                    {
                        Console.WriteLine("exist");
                        return;
                    }
                }
            }
            Console.WriteLine("not exist");
        }
    }
}
