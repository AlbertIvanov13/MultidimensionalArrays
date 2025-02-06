
int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = dimensions[0];
int cols = dimensions[1];

int[,] matrix = new int[rows, cols];

int colSum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = numbers[col];
    }
}

List<int> sums = new List<int>();
int sum = 0;
for (int col = 0; col < cols; col++)
{
    for (int row = 0; row < rows; row++)
    {
        sum += matrix[row, col];
    }
    sums.Add(sum);
    sum = 0;
}

foreach (var item in sums)
{
    Console.WriteLine(item);
}