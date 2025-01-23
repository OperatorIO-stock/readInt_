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

            string numberUser = Console.ReadLine();

            if (int.TryParse(numberUser, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ошибка: Вы ввели некорректное число. Пожалуйста, попробуйте снова.");
                isWorkingProgram = false;
            }
        }

        return 0;
    }
}
