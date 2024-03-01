using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива, разделяя их запятой:");
        string[] inputArray = Console.ReadLine().Split(',');

        string[] newArray = FilterArray(inputArray);

        Console.WriteLine("Новый массив:");
        foreach (string item in newArray)
        {
            Console.WriteLine(item);
        }

    }
    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;

        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }
        string[] newArray = new string[count];

        int index = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                newArray[index] = item;
                index++;
            }
        }

        return newArray;
    }
}

