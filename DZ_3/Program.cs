// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] RandomArray(int lenght, int minValue, int maxValue)
{
    double[] array = new double[lenght];
    for (int i = 0; i < length; i++)
    {
        array[i] = RandomDouble(minValue, maxValue);
        return array;
    }
}
double[] array = RandomArray(5, 0, 10);