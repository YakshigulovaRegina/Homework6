/**
* Метод ввода массива с клавиатуры.
*/
int[] enterArray(int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array;
}

void printArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]};");
    }
    Console.WriteLine();
}


int search (int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            number = number + 1;
        }
    }
    return number;
} 

Console.WriteLine("Введите количество чисел: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = enterArray(arraySize);
printArray(array);
int number = search(array);
Console.WriteLine("Количество чисел > 0 = " + number);