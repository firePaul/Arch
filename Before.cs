class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("������������ ��� ������������ �������������� ���������");
        Console.WriteLine("���������� ������� �����. ");
        String S = Console.ReadLine();
        if (S == "q")
        {
            return;
        }
        int M
      =
      Int32.Parse(S);
        int c1 = 1; int c2 = 0;
        int c3 = 0;
        for (int i = 1; i <= M; i++)
        {
            c1 = c1 * i;
            c2 = c2 + i;
            if (i % 2 == 0)
            {
                c3 = i;
            }
        }
        Console.WriteLine("��������� ����� " + c1); Console.WriteLine("���� �� 1 �� N ����� " +
        c2);
        Console.WriteLine("������������ ������ ����� ������ N �����" + c3);
        Console.ReadLine();
    }
}