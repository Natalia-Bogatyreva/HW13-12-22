// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// (можно использовать готовую функцию)

Console.WriteLine("Создаем двумерный массив, элементы которого нужно будет ввести Вам. Введите количество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array = new double[m,n];

FillArray(array);
PrintArray(array);
StMinSum(array);

double[,] FillArray(double[,] array)                    
{
    for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Введите элементы {i+1} строки через пробел(' '). Их должно быть ровно {n}!");
            double[] array1 = Console.ReadLine().Split(' ').Select(х => double.Parse(х)).ToArray();
            if (array1.Length != n) 
            { 
                Console.WriteLine("Вы ввели неверное количество элементов.");
                break;
            }
            else 
            {
                int index = 0;
                for (int j = 0; j < n; ++j)
                {
                    array[i,j] = array1[index];
                    index++;
                }
            }
        }
    return array;
}

void PrintArray(double[,] array) 
{
    Console.WriteLine("Введенный массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
    }
}

void StMinSum(double[,] array)
{
    double sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum+array[1,j];
    }
    int index = 0;
    double [] array1 = new double[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
           {
                array1[j] = array [i,j];
            }
        if (array1.Sum()<sum)
        {
            sum = array1.Sum();
            index = i;
             
        }             

    }
    Console.WriteLine($"{index+1} - cтрока с наименьшей суммой элемнтов ({sum}).");
}