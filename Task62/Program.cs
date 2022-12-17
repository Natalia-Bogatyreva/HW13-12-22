// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,]array = new int[4,4];
FillArrSpiral(array);
PrintArray(array);

void FillArrSpiral(int[,]array)
{
    for (int i = 0; i < 4; i++)
    switch (i)
    {
        case 0: for (int j = 0; j < 4; j++)
                {
                    array[0,j] = j+1;
                }
                break;
        case 1: array[1,0] = 12; array[1,1] = 13; array[1,2] = 14; array[1,3] = 5;
                break; 
        case 2: array[2,0] = 11; array[2,1] = 16; array[2,2] = 15; array[2,3] = 6;
                break;
        case 3: for (int j = 0; j < 4; j++)
                {
                    array[3,j] =10-j;
                }
                break;
    }
}


void PrintArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           {
                if (array[i,j]<10)
                {
                    Console.Write("0" + array[i, j] + " ");
                }
                else
                {
                    Console.Write(array[i, j] + " ");
                }
                
            }
        Console.WriteLine();
    }
}