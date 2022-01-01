using JaggedArray;

var arrayGenerator = new ArrayGenerator();
var array = arrayGenerator.Generate();
Print(array);
Console.ReadLine();

/*var task2Array = new Task_12(array);
var maxmin = task2Array.MaxAndMinElement();
Console.WriteLine(maxmin);*/
var taskkk = new Task1(array);
var max = taskkk.Sum();
Console.WriteLine(max);

var task1Array = new Task13(array);
var sortArray = task1Array.BubbleTeethSort();
Print(sortArray);

void Print(int[][] array)
{
    foreach (var innerArray in array)
        Console.WriteLine("[{0}]", string.Join(", ", innerArray));
}