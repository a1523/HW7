/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int[,] GetArray ()
{
    int[,] array = new int[10,10];
    for(int i = 0; i <10; i++)
    {
        for(int j = 0; j<10; j++)
        {
            array[i,j] = new Random().Next(-50, 50);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int GetValueByIndex(int[,]array, int n, int m)
{
    int numberByIndex = 0;
    if(n<10 && m<10)
    {
        numberByIndex = array[n,m];
        Console.WriteLine($"Число по индексу ({n};{m}) = {numberByIndex}");
    }
    else 
    {
        Console.WriteLine($"Числа по индексу ({n};{m}) в данном массиве не существует");
    }
    return numberByIndex;
}

Console.WriteLine("Исходный массив: ");
int[,] array =  GetArray();

int m = 0;
int n = 0;

try
{
Console.Write("Введите первый индекс числа от 0 до 9: ");
n = int.Parse(Console.ReadLine());

Console.Write("Введите второй индекс числа от 0 до 9: ");
m = int.Parse(Console.ReadLine());

int numberByIndex = GetValueByIndex(array, n, m);
}
catch
{
    Console.WriteLine("Ошибка ввода значения индекса элемента массива. Введите целое число от 0 до 9");
}


