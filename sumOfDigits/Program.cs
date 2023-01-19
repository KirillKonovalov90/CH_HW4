            // Программа принимает число и возвращает сумму его цифр

int sumOfDigits (int number)
{
    int digit, summ = 0;

    while (number != 0)
    {
        digit = number % 10;
        summ = summ + digit;
        number /= 10;
    }
    return summ;
}
int num;

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine()!);

Console.WriteLine(sumOfDigits(num));