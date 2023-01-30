﻿/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int getIntFromUser(string message)  
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

int [,] get2DDoubleArray (int colLength, int rowLength, int start, int end)
{
    int [,]array = new int [colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

void print2DArray( int [,] array)
{
    Console.Write(" \t");
    for (int j =0; j < array.GetLength(1); j++)
    {
        PrintInColor( j+ "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
       PrintInColor(i +"\t");
       for (int j =0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i,j]+ "\t");
       }
       Console.WriteLine();
    }
}
int rows = getIntFromUser("Введите количество строк");
int colums = getIntFromUser("Введите количество столбцов");
int [,] array = get2DDoubleArray( rows,colums,0,100);
print2DArray(array);

if (rows < array.GetLength(0) && colums < array.GetLength(1)) Console.WriteLine(array[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
