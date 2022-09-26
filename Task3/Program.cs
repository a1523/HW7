/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10, 10);
            Console.Write($"{array[i,j]}" + " ");
        }
        Console.WriteLine();
    }
    return array;
}

double[] GetArithmeticMeanByColumns (int[,] array)
{
    double[] arithmeticMeanByColumns = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticMeanByColumns[i] = arithmeticMeanByColumns[i] + array[j, i];
        }
        arithmeticMeanByColumns[i] = arithmeticMeanByColumns[i] / array.GetLength(0);
    }
    return arithmeticMeanByColumns;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
    return;
}

try
{
Console.Write("Введите число строк (m): ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число столбцов (n): ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Исходный массив: ");
int[,] array = GetArray(m, n);

Console.WriteLine("Среднее арифметическое по столбцам: ");

double[] result = GetArithmeticMeanByColumns(array);

PrintArray(result);
}
catch
{
    Console.WriteLine("Ошибка ввода размерности массива. Введите целые числа!");
}