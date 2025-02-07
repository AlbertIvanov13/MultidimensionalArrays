
int rowsCount = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rowsCount][];

for (int row = 0; row < jaggedArray.Length; row++)
{
    int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
    jaggedArray[row] = elements;
}

string[] arguments = Console.ReadLine().Split();
bool isValid = false;

while (arguments[0] != "END")
{
    string operation = arguments[0];
    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int newElement = int.Parse(arguments[3]);
    if (row < 0 || col < 0)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else if (row == jaggedArray.Length || col == jaggedArray[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else
    {
        for (int i = row; i < jaggedArray.Length; i++)
        {
            for (int j = col; j < jaggedArray[row].Length; j++)
            {
                if (row < jaggedArray.Length && col < jaggedArray[row].Length)
                {
                    if (operation == "Add")
                    {
                        jaggedArray[i][j] += newElement;
                        break;
                    }
                    else
                    {
                        jaggedArray[i][j] -= newElement;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            break;
        }
    }
    arguments = Console.ReadLine().Split();
}

for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = row; col < jaggedArray[row].Length; col++)
    {
        Console.WriteLine(string.Join(" ", jaggedArray[row]));
        break;
    }
}