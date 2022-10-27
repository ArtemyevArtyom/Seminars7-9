/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых
оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void changeToSquareInEvenPosition(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < Matrix.GetLength(1); j+=2)
        {
            Matrix[i,j] *= Matrix[i,j];
        }
    }
}
//int[,] generateArray = generate2DArray(7, 5, -100, 100);
int[,] generateTwoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
print2DArray(generateTwoDArray);
Console.WriteLine();
changeToSquareInEvenPosition(generateTwoDArray);
print2DArray(generateTwoDArray);