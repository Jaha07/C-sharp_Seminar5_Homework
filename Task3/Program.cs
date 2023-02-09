// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов
// массива.
// [3 7 22 2 78] -> 76
Console.Clear();
double RandomDouble(int minNumber, int maxNumber)
{
    double randomDouble = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
    return randomDouble;
}
double[] RandomArray(int length, int minNumber, int maxNumber)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++) array[i] = RandomDouble(minNumber, maxNumber);
    return array;
}
void DivMaxMin(double[] array)
{
    double min = array[0], max = array[0], total = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    total = max - min;
    Console.WriteLine($"min = {min} ; max = {max}");
    Console.WriteLine($"max - min = {total}");
}
double[] randomArray = RandomArray(10, 1, 10);
Console.WriteLine(string.Join(" ", randomArray));
DivMaxMin(randomArray);
