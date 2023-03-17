// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int [] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i<size;i++)
    {
        result [i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int unevenPosition (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum=sum+array[i];
    }
    return sum;
} 

Console.Clear();
int [] array = GetRandomArray (4, 2, 15);
Console.WriteLine($"[   {String.Join(", ", array)}   ] -> {unevenPosition(array)}");
