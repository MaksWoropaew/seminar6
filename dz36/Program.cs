//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

namespace Task1
{
    class Program
    {
        static void FillArray(int[] numbers) // генерация массива с параметрами передоваемыми в метод
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(0, 100);
            }
        } 

        static void WriteArray(int[] numbers) //печать массива
        {
            for (int i = 0; i < numbers.Length; i++ )
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
        public static void OddPosition(int[] numbers)//проход по массиву(поиск нечетных индексов, ссумирование чисел)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + numbers[i];
                    Console.WriteLine($"Индекс/число {i} = {numbers[i]}");
                }
            }
            Console.WriteLine($"Сумма чисел нечетных индексов: {sum}");
        }
        static void Main() //инициализация массива(), 
        //печать его,обработка индексов массива и подсчет сумму чисел
        {
            int[] numbers = new int[new Random().Next(5, 21)];
            FillArray(numbers);
            Console.WriteLine();
            WriteArray(numbers);
            OddPosition(numbers);
        }
    }
}