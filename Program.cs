namespace readInt;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RequestNumber());
    }

    static int RequestNumber()
    {
        bool isWorkingProgram = true;

        while (isWorkingProgram)
        {
            Console.Write("Введите число: ");

            try
            {
                int numberUser = int.Parse(Console.ReadLine());
                return numberUser;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Вы ввели некорректное число. Пожалуйста, попробуйте снова.");
            }
        }
        
        return 0;
    }
}
