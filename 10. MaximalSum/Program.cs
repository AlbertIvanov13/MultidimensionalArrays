
using System.Numerics;

int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

int[,] matrix =  new int[rows, cols];

int maxSum = -1;
int newSum = -1;

int firstRow = -1;
int secondRow = -1;
int thirdRow = -1;

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

List<int> firstRowList = new List<int>();
List<int> secondRowList = new List<int>();
List<int> thirdRowList = new List<int>();

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        firstRow = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
        secondRow = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
        thirdRow = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        newSum = firstRow;
        newSum += secondRow;
        newSum += thirdRow;

        if (newSum > maxSum)
        {
            maxSum = newSum;
            firstRowList = new List<int>();
            firstRowList.Add(matrix[row, col]);
            firstRowList.Add(matrix[row, col + 1]);
            firstRowList.Add(matrix[row, col + 2]);

            secondRowList = new List<int>();
            secondRowList.Add(matrix[row + 1, col]);
            secondRowList.Add(matrix[row + 1, col + 1]);
            secondRowList.Add(matrix[row + 1, col + 2]);

            thirdRowList = new List<int>();
            thirdRowList.Add(matrix[row + 2, col]);
            thirdRowList.Add(matrix[row + 2, col + 1]);
            thirdRowList.Add(matrix[row + 2, col + 2]);
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

Console.WriteLine(string.Join(" ", firstRowList));
Console.WriteLine(string.Join(" ", secondRowList));
Console.WriteLine(string.Join(" ", thirdRowList));