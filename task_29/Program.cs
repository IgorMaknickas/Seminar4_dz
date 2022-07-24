// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void getNewArr()
{
    int[] array = new int[8];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(0, 10);
        Console.Write($"{array[i]} ");
    }
}
getNewArr();