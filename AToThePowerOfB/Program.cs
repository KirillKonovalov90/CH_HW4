                // Программа принимает числа A и B и выводит результат равный A в степени B

double AToThePowerOfB (int A, int B)
{
    double result = A;
    if (B == 0)
    {
        return 1;        
    }
    else if (B < 0)                 //чуть усложнил программу и позволил брать отрицательные степени
    {
        for (int i = 1; i < B * (-1); i++)
        {
        result = result * A;
        }
        return (1 / result);
    }
    else
    {
         for (int i = 1; i < B; i++)
        {
        result = result * A;
        }
        return result;
    }     
}

int numA, numB;

Console.Write("Введите число A: ");
numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите желаемую степень B: ");
numB = int.Parse(Console.ReadLine()!);

Console.WriteLine(AToThePowerOfB (numA, numB));