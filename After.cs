class Program
{
    static void Main(string[] args)
    {
        bool flag;
        string s;
        int num;
        int fact = 1;
        int sum = 0;
        int evenless = 0;

        Console.WriteLine($"Здравствуйте, Вас приветствует математическая программа, " +
            $"которая вычислит факториал вашего числа, подсчитает сумму от 1 до вашего числа" +
            " и найдет максимально четное число меньше вашего числа.");

        do
        {
            Console.WriteLine($"Пожалуйста введите ваше число:");
            s = Console.ReadLine();
            flag = int.TryParse(s, out num);
        }
        while (!flag);

        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }

        for (int i = 1; i <= num; i++)
        {
            sum = sum + i;
        }

        if (num % 2 == 0)
        {
            evenless = num - 2;
        }
        else
        {
            evenless = num - 1;
        }

        Console.WriteLine($"Факториал равен  {fact}.");
        Console.WriteLine($"Сумма от 1 до N равна  {sum}.");
        Console.WriteLine($"Максимально четное число меньше {num} равно {evenless}.");
        Console.ReadKey();
    }
}