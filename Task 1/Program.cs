//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

int[,] GenerateArray(int rows, int columns, int minRange, int maxRange)
{
    var array = new int[rows, columns];
    var random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRange,maxRange);

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
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] ReplaceRows(int[,] arr)
{
    int tmp = 0;
    int lastpos = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        tmp = arr[0,i];
        arr[0,i] = arr[lastpos,i];
        arr[lastpos,i] = tmp;
    }
    return arr;
}

int rows = Prompt("Кол-во строк: ");
int cols = Prompt("Кол-во столбцов: ");
int[,] myArray = GenerateArray(rows, cols, 5, 10);
PrintArray(myArray);
myArray = ReplaceRows(myArray);
PrintArray(myArray);

