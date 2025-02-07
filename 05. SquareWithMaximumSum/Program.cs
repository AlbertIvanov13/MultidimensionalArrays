
int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = elements[col];
    }
}

int sum = int.MinValue;

int firstRow = 0;
int firstCol = 0;
int secondRow = 0;
int secondCol = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int possibleFirstRow = matrix[row, col];
        int possibleFirstCol = matrix[row, col + 1];
        int possibleSecondRow = matrix[row + 1, col];
        int possibleSecondCol = matrix[row + 1, col + 1];
        int result = possibleFirstRow + possibleFirstCol + possibleSecondRow + possibleSecondCol;

        if (result > sum)
        {
            sum = result;
            firstRow = matrix[row, col];
            firstCol = matrix[row, col + 1];
            secondRow = matrix[row + 1, col];
            secondCol = matrix[row + 1, col + 1];
        }
    }
}

Console.WriteLine($"{firstRow} {firstCol}");
Console.WriteLine($"{secondRow} {secondCol}");
Console.WriteLine(sum);