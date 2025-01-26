namespace readInt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReadInt());
    }

    static int ReadInt()
    {
        int number;
        
        Console.Write("Введите число: ");

        while (int.TryParse(Console.ReadLine(), out number) == false)
        {
            Console.WriteLine("Ошибка: Введите корректные данные.");
        }

        return number;
    }
}
