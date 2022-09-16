// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0


int size = 4;
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine(SumInOddPos(array));

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 99);

}
int SumInOddPos (int[] array)
{
    int Sum=0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i%2)!=0) Sum+=array[i];
        }
        return Sum;
}