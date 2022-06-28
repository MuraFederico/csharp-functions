// See https://aka.ms/new-console-template for more information

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int GetSquared(int number)
{
    return number * number;
};

int[] GetSquaredArray(int[] array)
{
    int[] result = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = GetSquared(array[i]);
    }
    return result;
}

int GetSumArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    };

    return result;
}
