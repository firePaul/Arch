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

        Console.WriteLine($"������������, ��� ������������ �������������� ���������, " +
            $"������� �������� ��������� ������ �����, ���������� ����� �� 1 �� ������ �����" +
            " � ������ ����������� ������ ����� ������ ������ �����.");

        do
        {
            Console.WriteLine($"���������� ������� ���� �����:");
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

        Console.WriteLine($"��������� �����  {fact}.");
        Console.WriteLine($"����� �� 1 �� N �����  {sum}.");
        Console.WriteLine($"����������� ������ ����� ������ {num} ����� {evenless}.");
        Console.ReadKey();
    }
}