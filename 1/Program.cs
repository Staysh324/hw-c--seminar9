//благодаря этой задаче я понял, что Вы объясняли на семинаре в первой задаче! =)


int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


void ShowEvenNumbers(int min, int max) // рекурсивный метод вывода чётных чисел от введенного минимума до максимума
{
    if (max == 0)
    {
        return;
    }
    ShowEvenNumbers(min, max - 1);
    if (max % 2 == 0)
    {
        System.Console.Write($"{max}; ");
    }
}


int min = InputInt("введите минимальный порог:");
int max = InputInt("введите максимальный порог:");
if (min > max)
{
    System.Console.WriteLine("минимальное число не может быть больше максимального");
    Environment.Exit(1);
}
if (max == 0 | max == 1)
{
    System.Console.WriteLine("в заданном диапазоне четных чисел нет");
}
else
{
    System.Console.WriteLine($"чётные числа от {min} до {max}:");
    ShowEvenNumbers(min, max);
}