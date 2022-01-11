using JaggedArray;

var arrayGenerator = new ArrayGenerator();
var array = arrayGenerator.Generate();
Print(array);

var task13 = new Task13(array);
var arraySortElement = task13.Sort();
Print(arraySortElement);

void Print(int[][] array)
{
    foreach (var innerArray in array)
        Console.WriteLine("[{0}]", string.Join(", ", innerArray));
}