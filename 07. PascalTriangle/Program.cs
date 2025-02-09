
using System.Data;
using System.Runtime.InteropServices;

int triangleSize = int.Parse(Console.ReadLine());

long[][] jaggedArray = new long[triangleSize][];

int sum = 0;
for (int row = 0; row < jaggedArray.Length; row++)
{
	if (row == 0)
	{
		jaggedArray[row] = new long[1];
		jaggedArray[row][0] = 1;
	}
}

bool isSet = false;
for (int row = 1; row <= jaggedArray.Length - 1; row++)
{
	isSet = false;
	jaggedArray[row] = new long[jaggedArray[row - 1].Length + 1];
	for (int col = 0; col < jaggedArray[row - 1].Length; col++)
	{
        if (!isSet)
        {
            jaggedArray[row][0] = 1;
            jaggedArray[row][jaggedArray[row].Length - 1] = 1;
            isSet = true;
        }
    }
}

for (int row = 2; row <= jaggedArray.Length - 1; row++)
{
	for (int col = 1; col <= jaggedArray[row].Length - 1; col++)
	{
		if (jaggedArray[row][col] == 0)
		{
			jaggedArray[row][col] = jaggedArray[row - 1][col] + jaggedArray[row - 1][col - 1];
		}
	}
}

for (int row = 0; row < jaggedArray.Length; row++)
{
	for (int col = 0; col < jaggedArray[row].Length; col++)
	{
		Console.WriteLine(string.Join(" ", jaggedArray[row]));
		break;
	}
}