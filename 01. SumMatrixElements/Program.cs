
int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

int sum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
	int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = elements[col];
		sum += elements[col];
	}
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);