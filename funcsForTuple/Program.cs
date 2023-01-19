        //Программа состоит из 2х функций, первая создаёт массив случайных чисел, заданного размера
        //вторая функция выводит элементы массива

int[] arrayCreationAndFilling(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array [i] = rand.Next(0, 9);
    }
    return array;
}

void arrayPrinting(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int num;
int[] arr;
Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine()!);

arr = arrayCreationAndFilling(num);
arrayPrinting(arr);
