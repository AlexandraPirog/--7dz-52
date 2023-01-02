/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("не удалось распознать число");

    }
    return number;
}

Console.Clear();
int m = inputNumber("Введите значение m");
int n = inputNumber("Введите значение n");
int[,] arr = new int[m, n];
FillArrayWithRandomNumbers(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    double value = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        value += arr[i, j];
    }
    value /= n;
    System.Console.WriteLine("среднее арифметическое: "+ value+ ";");
}

void FillArrayWithRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
