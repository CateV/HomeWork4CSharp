// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray (int []array)
{
    for(int i=0;i<array.Length;i++)
    array[i]=new Random().Next(1,10);
}
void PrintArray (int[] massive)
{
for(int i=0;i<massive.Length;i++)
System.Console.Write($"{massive[i]}\t");
}
int[] arr = new int [8];
FillArray(arr);
PrintArray(arr);