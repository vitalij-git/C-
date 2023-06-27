namespace _12._Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1_1();
            //Task1_2();
            Task1_3();
            //Task1_4();

        }

        static void Task1_1()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] powNumersArray = new int[10];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                powNumersArray[i] =(int)Math.Pow(numbersArray[i], 2);
            }
            foreach (int i in powNumersArray)
            {
                Console.WriteLine(i);
            }
        }

        static void Task1_2()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = 0;
            foreach (int i in numbersArray)
            {
                result += i;
            }
            Console.WriteLine(result);
        }

        static void Task1_3()
        {
            int[] numbersArray = { 1, 2, 3,70, 5, 6, 7, 80, 9, 10 };
            Console.WriteLine(numbersArray.Max());
            int maxValue = 0;
            for ( int i = 0;i < numbersArray.Length;i++) 
            { 
                if (numbersArray[i] > maxValue)
                {
                    maxValue = numbersArray[i];
                }
            }
            Console.WriteLine(maxValue);
        }

        static void Task1_4()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] reverseArray = new int[10];
            int reverseindex = 0;
            for ( int i = numbersArray.Length-1; i >= 0; i--)
            {
                reverseArray[reverseindex] = numbersArray[i]; 
                reverseindex++;
            }
            foreach (int i in reverseArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}