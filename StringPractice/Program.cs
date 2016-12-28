using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Write a program in C# Sharp to input a string and print it.
            //string word = "The string you entered is : Welcome, w3resource ";

            //Console.WriteLine(word);


            //Write a program in C# Sharp to find the length of a string without using library
            //    string word1;
            //    int Lenth = 0;

            //    Console.WriteLine("Please input a string value");
            //    word1 = Console.ReadLine();

            //    foreach (Char charac in word1)
            //    {
            //        Lenth += 1;

            //    }
            //    Console.Write("The lenght of Array is: {0}", Lenth);
            //}

            //string wrd;
            //int len = 0;
            //Console.WriteLine("Enter the array word");
            //wrd = Console.ReadLine();

            //foreach (Char charact in wrd)
            //{
            //    len += 1;

            //}
            //Console.WriteLine("The length of array is {0}", len);

            // Write a program in C# Sharp to separate the individual characters from a string. 

            //int letter = 0;
            //string word;
            //Console.WriteLine("Please enter  string value");
            //word = Console.ReadLine();
            //while (letter < word.Length - 1)
            //{
            //    Console.Write(" {0}", word[letter]);
            //    letter++;

            //}
            //Console.Write("\n\n");
            // Write a program in C# Sharp to print individual characters of the string in reverse order
            //int let = 0;
            //string wrd;
            //Console.WriteLine("Please Enter the string ");
            //wrd = Console.ReadLine();

            //let = wrd.Length - 1;

            //while (let >= 0)
            //{
            //    Console.WriteLine("{0}", wrd[let]);
            //    let--;

            //}
            //Console.Write("\n\n");

            // Write a program in C# Sharp to count the total number of words in a string

            // int count = 0;
            // string str;
            //int wrd = 1;
            // Console.WriteLine("Please Enter the string ");
            // str = Console.ReadLine();

            // while (count <= str.Length - 1)
            // {
            //     if (str[count] == ' ' || str[count] == '\n' || str[count] == '\t')
            //         wrd++;

            // }
            // count++;
            // Console.WriteLine("The word count is: {0}\n", wrd);


            string str;
            int i, wrd, l;

            Console.Write("\n\nCount the total number of words in a string :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of words in the string is : {0}\n", wrd);
        }

    }

}
