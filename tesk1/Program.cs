//1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]

//[6 7 3 6] -> [6 3 7 6]


//2. Напишите программу, которая будет создавать 
   //копию заданного массива с помощью поэлементного копирования.


namespace Task1
{
    class Program
    {
        static Random random = new Random();
        static int[] FullRandomArrayGenerator()
        {
            int[] array = new int[random.Next(5,11)]; //[5, 10]
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(40) + 1; //[1, 40]
            }
            return array;
        }
        static void ViewArray(int[] array)
        {
            Console.Write("Массив: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine("{0}]", array.Last());
        }
        static void ViewArray(int[] array, int degree)
        {
            Console.Write("Массив: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0}, ", Math.Pow(array[i], degree));
            }
            Console.WriteLine("{0}]", Math.Pow(array.Last(), degree));
        }
            
        static void Main(string[] asgs)
        {
            int[] array = FullRandomArrayGenerator();
            ViewArray(array);
            ViewArray(array, 2);
        }
    }
}

