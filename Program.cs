namespace readInt;

class Program
{
    static void Main(string[] args)
    {
        int number = RequestNumber();
        Console.WriteLine(number);
    }

    static int RequestNumber()
    {
        int number;
        
        Console.Write("Введите число: ");

        string numberUser = Console.ReadLine();

        while (int.TryParse(numberUser, out number) == false)
        {
            Console.WriteLine("Ошибка: Введите корректные данные.");
        }

        return number;
    }
}
