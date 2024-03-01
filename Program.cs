using System;

class Program
{
    static void Main(string[] args){
    
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
    }    
}
