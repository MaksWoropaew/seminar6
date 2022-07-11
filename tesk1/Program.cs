namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string? str = Console.ReadLine();
                int num = Convert.ToInt32(str);
            }
            catch
            {

                Console.WriteLine("Вы ввели не правильные данные");
            }
        }
     }
}

