//Задача 38: Задайте массив целых чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int [] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i<size;i++)
    {
        result [i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int [] Difference (int [] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) {min = array[i];}
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) {max = array[i];}
    }
    int [] Diff = {max - min};
    return Diff;
} 

Console.Clear();
int [] array = GetRandomArray (4, 1, 100);
Console.WriteLine($"[   {String.Join(", ", array)}   ] -> {String.Join(", ", Difference(array))} ");