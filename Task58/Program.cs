// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Создаем две матрицы (содержащие натуральные числы до 10), чтобы посчитать их произведение.");
Console.WriteLine("Для этого должно выполняться условие: количество строк 1 матрицы должно равняться количеству столбцов 2.");
Console.WriteLine("Введите количество строк(столбцов) в 1(2) матрице:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов(строк) в 1(2) матрице:");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array1 = new int[m,n];
int[,]array2 = new int[n,m];
int[,] array = new int[array1.GetLength(0),array2.GetLength(1)];

FillArrayRandom(array1);
FillArrayRandom(array2);
Console.WriteLine("Матрица 1:");
PrintArray(array1);
Console.WriteLine("Матрица 2:");
PrintArray(array2);
Console.WriteLine("Их произведение:");
MultiArray(array1,array2,array);
PrintArray(array);

int[,] FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
        }

    }
    return array;
}
void PrintArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
    }
}

int[,] MultiArray(int[,]array1,int[,]array2,int[,]array)
{
//if (array1.GetLength(1) == array2.GetLength(0))   // если бы задавали вручную, нужно было бы проверить.
//    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
                for (int a = 0; a < array1.GetLength(1); a++)
                {
                    array[i, j] = array[i,j] + array1[i, a] * array2[a, j];
                }
            }
        }
  /*  }
   else
    {
        Console.WriteLine("Эти матрицы нельзя умножить.");
    }*/
    return array;
}
