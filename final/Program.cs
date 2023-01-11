// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.WriteLine("Введите элементы массива через Enter:");

string[] CreateStringArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}


int FindCountElementsNewArray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count++;
    }
    return count;
}

string[] NewArray (string [] array, int count)
{
    int k = 0;
    string[] newarr = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarr[k] =  array[i];
            k++;
        }
    }
    return newarr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] arr = CreateStringArray (4);
PrintArray(arr);
int amount = FindCountElementsNewArray(arr);
Console.WriteLine("Элементы массива, длина которых строго меньше 4 символов:");
string[] newArray = NewArray (arr, amount);
PrintArray(newArray);