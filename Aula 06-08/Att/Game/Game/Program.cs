public enum TerrainEnum
{
    GRASS,
    SAND,
    WATER,
    WALL
}
public static class TerrainEnumExtensions
{
    public static ConsoleColor GetColor (this TerrainEnum terrain)
    {

        switch (terrain)
        {
            case TerrainEnum.GRASS: return ConsoleColor.Green;
            case TerrainEnum.SAND: return ConsoleColor.Yellow;
            case TerrainEnum.WATER: return ConsoleColor.Blue;
            default: return ConsoleColor.Gray;
        }

    }

    public static char GetChar (this TerrainEnum terrain)
    {

        switch (terrain)
        {
            case TerrainEnum.GRASS: return '\u201c';
            case TerrainEnum.SAND: return '\u25cb';
            case TerrainEnum.WATER: return '\u2248';
            default: return '\u25cf';
        }

    }
}

//----------------------------------------- 

TerrainEnum[,] map =
 {
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS }, (...)
    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,
      TerrainEnum.WATER }
 };
  Console.OutputEncoding = UTF8Encoding.UTF8;
 for (int row = 0; row < map.GetLength(0); row++)
 {
    for (int column = 0; column < map.GetLength(1); column++)
    {
        Console.ForegroundColor = map[row, column].GetColor();
        Console.Write(map[row, column].GetChar() + " ");
    }
    Console.WriteLine();
 }
 Console.ForegroundColor = ConsoleColor.Gray;
