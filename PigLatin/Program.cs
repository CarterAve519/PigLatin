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
            
            

            Console.WriteLine("Welcome to the Pig Latin Translator!");
            while (true)
            {


                //start loop here bc you want the program to ask this over 
                Console.WriteLine("Enter a line to be translated");

                //Lowercasing a words put in UPPERCASE & Reading the line
                string response = Console.ReadLine().ToLower();
                


                //Telling the program what I want it to check for
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                //finds the vowel index = vowel space (finding where the vowel is inside of the word)
                int index = response.IndexOfAny(vowels);

                //if no vowels, IndexOfAny returns -1
                if (index > 0)
                {
                    //if the word starts with a vowel, index = 0
                    //This string is going to split at the start of a vowel
                    string end = response.Substring(index);
                    //This string is the 
                    string beginning = response.Substring(0, index);

                    Console.WriteLine(end);
                    Console.WriteLine(beginning);

                    //this string will create the PigLatin word
                    string Pig = (end + beginning + "ay");

                    //this string will "print out your word"
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
                //This means that yes is going to be in a box called answer (for pc)
                string answer = "yes";

                //Asking if user wants to translate again/
                Console.WriteLine("Would you like to translate another line?");

                //whatever their answer is it's going to print to the screen
                answer = Console.ReadLine();

                //comparing what user input is to see if it matches what program wants to be able to start again or not 
                if (answer == "yes")
                {
                    //program will "continue"
                    continue;
                }
                //if user inputs anything other that "yes" the program will break out
                else
                {
                    break;
                }


            }


                

            

             
        }
    }
}

