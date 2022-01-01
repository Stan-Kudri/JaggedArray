
using JaggedArray;

var arrayGenerator = new ArrayGenerator();
var array = arrayGenerator.Generate();
Print(array);
Console.ReadLine();

void Print(int [][] array)
{
    foreach(var innerArray in array)
        Console.WriteLine("[{0}]", string.Join(", ", innerArray));
}