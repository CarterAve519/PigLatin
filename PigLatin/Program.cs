using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter;
            

            Console.WriteLine("Welcome to the Pig Latin Translator!");
             
            Console.WriteLine("Enter a line to be translated");
            string response = Console.ReadLine().ToLower();
            //string lowerResponse = response.ToLower();

            

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //finds the vowel index= vowel space
            int index = response.IndexOfAny(vowels);

            //if no vowels, IndexOfAny returns -1
            if (index > 0)
            {
                //if the word starts with a vowel, index = 0


                Console.WriteLine(index);

                string end = response.Substring(index);
                string beginning = response.Substring(0, index);


                string Pig = (end + beginning + "ay");

                Console.WriteLine($"Your new word is {Pig}");
            }
            else
            {
                if (index == 0)
                {
                    //if the 1st letter is a vowel user input +way
                    Console.WriteLine($"Your new word is {response}way");
                }
            }


            //for tab tab (for loop)
            //for (int i = 0; i < response.Length; i++)
            //{
            //    for (int j = 0; j < vowels.Length; j++)
            {

            }


                

            

             
        }
    }
}

