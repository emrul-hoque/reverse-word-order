using System;

class Program

{

    static void Main()
    {
        Console.WriteLine("Type a sentence and the program will reverse its word order.");
        string? sentence = Console.ReadLine();

        //split the sentence into words
        if (sentence != null)
        {
            string[] words = sentence.Split(' ');

            //Reverse the order of the words
            Array.Reverse(words);

            //Join the words back into a sentence
            string reversed = string.Join(" ", words);

            Console.WriteLine(reversed);

        }

        else
        {
            //do nothing;
        }

    }

}