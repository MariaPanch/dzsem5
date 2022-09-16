// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double []array ={3,7,22,2,78} ;

(double, double)MinMax=MinMaxFun(array);
System.Console.WriteLine(MinMax.Item2-MinMax.Item1);



(double, double)MinMaxFun(double[] array)
{
    double Min=array[0];
    double Max=array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (Min>array[i]) Min=array[i];
        if (Max<array[i]) Max=array[i];
    }
    return (Min, Max); 
}