/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] GetArrayDouble (int m, int n)
{
    double[,] array = new double[m, n];
    for(int i=0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    return array;
}

int m = 0;
int n = 0;

Console.Write("Введите число m: ");

bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if(!parseMIsOk)
    {
        Console.WriteLine("Введен неверный формат числа");
    }
else
    {
        m = numberM;
    }

Console.Write("Введите число n: ");

bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if(!parseNIsOk)
    {
        Console.WriteLine("Введен неверный формат числа");
    }
else
    {
        n = numberN;
    }

double [,] araryNewDouble = GetArrayDouble(m, n);



