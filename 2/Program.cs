
int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}



int SumNumbers(int min, int max) // рекурсивный метод сложения чисел от min до max
{
    if (max == 0)
    {
        return 0;
    }
    return max + SumNumbers(min, max - 1);
}


int min = InputInt("введитме минимальный порог");
int max = InputInt("введите максимальный порог");

if (min > max)
{
    System.Console.WriteLine("минимальное число не может быть больше максимального");
}
else
{
    System.Console.WriteLine($"сумма чисел от {min} до {max} = {SumNumbers(min, max)}");
}

