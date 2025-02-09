
using System.Threading.Tasks.Sources;

int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];

int equalsCount = 0;

for (int row = 0; row < rows; row++)
{
    string[] elements = Console.ReadLine().Split().ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = elements[col];
	}
}

for (int row = 0; row < rows - 1; row++)
{
	for (int col = 0; col < cols - 1; col++)
	{
		if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row, col] 
			&& matrix[row, col + 1] == matrix[row + 1, col + 1])
		{
			equalsCount++;
		}
	}
}

Console.WriteLine(equalsCount);