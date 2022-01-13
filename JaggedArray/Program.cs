using JaggedArray;

var arrayGenerator = new ArrayGenerator();
var array = arrayGenerator.Generate();
Print(array);
var task122 = new Task12(array).MaxAndMinElement();
Console.ReadLine();
var task12 = new Task12(new int[][] { }).MaxAndMinElement();
Console.WriteLine(task12.ToString());
var task1Array = new Task13(array);
var sortArray = task1Array.Sort();
Print(sortArray);

void Print(int[][] array)
{
    foreach (var innerArray in array)
        Console.WriteLine("[{0}]", string.Join(", ", innerArray));
}