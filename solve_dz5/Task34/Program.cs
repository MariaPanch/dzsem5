// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = 10;
int[] array = new int[size];
FillArray(array);
int NumEven = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array[i] % 2) == 0) NumEven++;
}
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine(NumEven);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);

}