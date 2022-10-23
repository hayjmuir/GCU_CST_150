using System;

public class WordChecker
{
    public static void Main()
    {
        
        int word, l;


        
        string @string = System.IO.File.ReadAllText("input.txt");

        l = 1;
        word = 1;

        // loop till end of string 
        while (l <= @string.Length - 1)
        {
            //check whether the current character is white space or new line or tab character
            if ((@string[l] == '.' || @string[l] == ' ' || @string[l] == '\t' || @string[l] == '!' || @string[l] == ',' || @string[l] == '?' || @string[l] == '\n') && (@string[l - 1] == 't' || @string[l - 1] == 'e'))
            {
                word++;
            }


            l++;
        }

        Console.Write("There are {0} words ending in t or e", word);
    }
}