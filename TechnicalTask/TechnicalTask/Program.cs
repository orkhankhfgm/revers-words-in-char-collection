using System;

namespace TechnicalTask
{
    class Program
    {
        static int index, current = 0;
        static char[] wordCollection = { 'a', 'p', 'p', 'l', 'e', ' ', 'd', 'o', 'g', ' ', 'c', 'a', 't', ' ', 'f', 'u', 'n' };

        static void Main(string[] args)
        {
            ReverseWord();
            
            for (int i = 0; i < wordCollection.Length; i++)
            {
                index = 0;
                
                for (int x = current; x < wordCollection.Length; x++)
                {
                    if (' ' == wordCollection[x])
                    {
                        index = x;
                        break;
                    }  
                }
                ReverseWord();

                current = (index < 1) ? wordCollection.Length : index + 1;

                if (current == wordCollection.Length)
                    break;
            }

            Console.ReadLine();
        }

        static void ReverseWord()
        {
            int x = current;
            int y = (index < 1) ? wordCollection.Length - 1 : index - 1;

            while (x < y)
            {
                char tmp = wordCollection[x];
                wordCollection[x] = wordCollection[y];
                wordCollection[y] = tmp;
                y--;
                x++;
            }
        }
    }
}
