// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("Enter number of rows");
// double[] rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number of colums");
// double[] colums = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, colums];

// for(int i=0; i< rows; i++)
// {
//     for(int j=0; j<colums; j++)
//     {
//         array[i, j] = i+j;
//     }
// }

// void PrintArray(int[,] inArray)
// {
//     for(int i=0; i< inArray.GetLength(0); i++)
//     {
//         for(int j=0; j< inArray.GetLength(1); j++)
//         {
//             Console.WriteLine($"{inArray[i,j]}");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows= Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns= Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArrayMatrix(rows, columns, 0, 20);
// PrintArray(array);//вывели массив
// System.Console.WriteLine();//пробел в строке
// PrintArray(array);//вывели измененный массив

// double[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] result = new double[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble());
// //            result[i, j] = new Random().NextDouble() * (maxValue - minValue); //Вариант от Габиля
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]:f1} "); //:f1 -Ограничиваеи количество элементов 
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// Console.Write("Enter number of rows: ");
// int rows= int.Parse(Console.ReadLine());

// Console.Write("Enter number of colums: ");
// int columns= int.Parse(Console.ReadLine());




// int[,] array = GetArrayMatrix(rows, columns, 0, 10);
// PrintArray(array);
// System.Console.WriteLine();


// Console.Write("Enter int in massive to find: ");
// int findEl = int.Parse(Console.ReadLine());
//Решение 1. Криво работает
// FindElement(array);

// void FindElement(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (findEl == inArray[i,j])
//             {
//                 Console.Write($"The position of int: i={i}, j={j}");
//             }
//         }
//     }
//     Console.Write("No int in massive"); 
// }

//Решение 2. Совсем криво работает. Всегда пишет, что нет элемента в массиве 
// if ((rows >=0 && rows < array.GetLength(0)) && (columns >=0 && columns < array.GetLength(1)))
// {
//    Console.WriteLine($"The position of int: {array[rows, colums]}");

// }
// else
// {
//     Console.WriteLine("No int in massive"); 
// }



// int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] result = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} "); //:f1 -Ограничиваеи количество элементов 
//         }
//         Console.WriteLine();
//     }
// }

// // Решение 3. От Габиля. Рабочее
// if (FindElement(array, findEl, out int column, out int row))
// {
//     Console.WriteLine($"Int position: colums = {column}, row = {row}");
// }
// else
// {
//     Console.WriteLine("No int in massive"); 
// }

// static bool FindElement(int[,] array, int findEl, out int column, out int row)
// {
//     column = 0;
//     row = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
//         {
//             if(findEl== array[i,j])
//             {
//                 column =j;
//                 row = i;
//                 return true;
//             }            
//         }
//     }
//     return false;
// }


// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0 , 9);
PrintArray(array);
System.Console.WriteLine();
SumArray(array);


//Console.WriteLine ($"Arithmetic mean of each column = { String.Join(",", averageColumns)}");//не понял, что это у Габиля

//char input1 = Console.ReadKey().KeyChar;//не понял, что это у Габиля

int[,] GetArray(int rows, int columns, int minValue=0, int maxValue=100)
{
    int[,] result = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] SumArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+= array[i, j];
        }

        result[i] = sum / array.GetLength(0);
//        result[i] = Math.Round(sum / array.GetLength(0), 2);// вариан для округления
        Console.WriteLine ($"Arithmetic mean of each column = : {result[i]:f2}");//округление при помощи f2
    }
    return result;
}
