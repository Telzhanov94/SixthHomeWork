void FillArray(int [,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        array[i,j]=i+j;
    }
}
void PrintArray(int [,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
    }
}
int [,] Matrix(int number, int digit)
{
    int [,] NewMatrix=new int [number,digit];
    return NewMatrix;
}
Console.WriteLine("Enter the number of lines");
int lines = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Enter the number of columns");
int columns = int.Parse(Console.ReadLine()??"0");
int [,] Matr=Matrix(lines,columns);
PrintArray(Matr);
FillArray(Matr);
PrintArray(Matr);