namespace JaggedArray;

internal class ArrayGenerator
{
    private readonly int _column;

    public ArrayGenerator()
    {
        _column = Random.Shared.Next(2, 11);
    }
    public ArrayGenerator(int column)
    {
        _column = column;
    }

    public int[][] Generate()
    {
        var generateArray = new int[_column][];
        for (var i = 0; i < _column; i++)
        {
            var size = Random.Shared.Next(1, 10);
            generateArray[i] = new int[size];
            for (var j = 0; j < size; j++)
            {
                generateArray[i][j] = Random.Shared.Next(-10, 10);
            }
        }
        return generateArray;
    }
}
