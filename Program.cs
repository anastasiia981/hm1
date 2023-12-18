// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 


using System;

class Program
{
    static void Main()
    {
        
        char[,] charArray = 
        {
            {'A', 'B', 'C'},
            {'D', 'E', 'F'},
            {'G', 'H', 'I'}
        };

        string resultString = ArrayToString(charArray);
        Console.WriteLine(resultString);
   
    }
    static string ArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);
      
        System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                stringBuilder.Append(charArray[row, col]);
            }
        }
        return stringBuilder.ToString();
    }
}

      


      

        