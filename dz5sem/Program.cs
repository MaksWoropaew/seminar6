//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

namespace Task1
{
    class Program
    {
        static Random random = new Random();
        void FillArray(int[] array, int min, int max) // генерация массива с параметрами передоваемыми в метод
        {
            for (int i = 0; i < array.Length; i++ )
            {
                array[i] = new Random().Next(min, max);
            }
        } 

        void WriteArray(int[] array) //печать массива
        {
            for (int i = 0; i < array.Length; i++ )
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        int QuantityPositive(int[] array)// счетчик четных чисел в массиве
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++ )
            {
                if (array[i] % 2 == 1)
                {
                quantity++;
                }
            }
            return quantity;
        }
        static void Main(string[] asgs) //инициализация массива(10 элементов), 
        //печать его,присвоение счетчика в переменную и вывод этого числа.
        {
            int[] numbers = new int[10];
            FillArray(numbers, 100, 1000);
            WriteArray(numbers);
            Console.WriteLine();
            int quantity = QuantityPositive(numbers);
            Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
        }
    }
}



