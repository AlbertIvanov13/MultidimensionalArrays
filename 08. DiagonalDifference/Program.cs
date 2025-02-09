
int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;
int difference = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = elements[col];
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = row; col < matrix.GetLength(1); col++)
    {
        primaryDiagonalSum += matrix[row, col];
        break;
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        secondaryDiagonalSum += matrix[row, col + matrixSize - row - 1];
        break;
    }
}

difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

Console.WriteLine(difference);