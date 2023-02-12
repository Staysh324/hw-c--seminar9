int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


int AkkernanFunction(int n, int m) // рекурсивный метод вычисления функции Аккермана
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n > 0 && m == 0)
    {
        return AkkernanFunction(n - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return AkkernanFunction(n - 1, AkkernanFunction(n, m - 1));
    }
    return AkkernanFunction(n, m);
}


int n = InputInt("введите n");
int m = InputInt("введите m");
System.Console.WriteLine($"результатом для функции Аккермана со значениями A({n},{m}) = {AkkernanFunction(n, m)}");