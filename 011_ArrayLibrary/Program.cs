﻿void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index<Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}


void FillArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index]==find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = index0f(array, 4);
Console.WriteLine(pos);

