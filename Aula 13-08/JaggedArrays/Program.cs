using System.Globalization;

int[][] numbers =
    new int[4][];

numbers[0] =
    new int[]
        { 1, 2, 3 };

numbers[1] =
    new int[]
        { 4 };

numbers[2] =
    new int[]
        { 5, 6, 7, 8, 9 };

numbers[3] =
    new int[]
        { 6, 5, 4 };

int[][] numbers2 =
    {
        new int [] {1},
        new int [] {2},
        new int [] {3},
        new int [] {4},
    };

// para percorrer o JaggeArray utilizamos laços de repetição encadeados\nested loop

for (int i = 0; i < numbers.Length; i++)
{

    Console.Write('[');

    for (int j = 0; j < numbers[i].Length; j++)
    {

        Console.Write($"{numbers[i][j]}");

    }

    Console.Write(']');
    
    Console.WriteLine("");

}