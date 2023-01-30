/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

int [,] get2DArray (int colLength, int rowLength, int start, int end)
{
    int [,]array = new int [colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, end+1) ;
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
int [,] array = get2DArray(rows,colums,0,10);
print2DArray(array);

Console.WriteLine("---------------------------");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ") ;
}