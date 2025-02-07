
int matrixDimension = int.Parse(Console.ReadLine());

string[,] matrix = new string[matrixDimension, matrixDimension];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string elements = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        for (int i = col; i < elements.Length; i++)
        {
            matrix[row, col] = elements[i].ToString();
            break;
        }
    }
}

string searchedElement =  Console.ReadLine();

bool isFound = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == searchedElement)
        {
            isFound = true;
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}

if (!isFound)
{
    Console.WriteLine($"{searchedElement} does not occur in the matrix");
}