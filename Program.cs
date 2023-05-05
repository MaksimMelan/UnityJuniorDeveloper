namespace UnityJuniorDeveloper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minRandomValue = 1;
            int maxRandomValue = 100;

            int number = random.Next(minRandomValue, maxRandomValue + 1 );
            int sum = 0;
            int divider1 = 3;
            int divider2 = 5;

            Console.WriteLine($"цифра рандома{number}");

            for (int i = 1; i <= number; i++)
            {
                if (i % divider1 == 0 || i % divider2 == 0)
                {
                    sum += i;
                    Console.WriteLine($"значение {i},  сумма {sum}");
                }              
            }

            Console.WriteLine($"Число полученное с помощю Рандома: {number}" +
                $"\nСумма всех чисел кратная {divider1} или {divider2} равна: {sum}");
        }
    }
}