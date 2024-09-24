using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
     class Program
    {

        public static String OldPhonePad(string input)
        {
           //First initialize all outputs in an array
             
            char[,] array = { { '&', '\'', '(', '\0' }, { 'A', 'B', 'C', '\0' }, { 'D', 'E', 'F', '\0' }, { 'G', 'H', 'I', '\0' }, { 'J', 'K', 'L', '\0' }, { 'M', 'N', 'O', '\0' }, { 'P', 'Q', 'R', 'S' }, { 'T', 'U', 'V', '\0' }, { 'W', 'X', 'Y', 'Z' } };

            int length = input.Length;

            List<string> newArray = new List<string>();
            List<char> resultArray = new List<char>();

             //Divide all inidividual inputs into separate arrays for execution, e.g. 44, 555, 66, *

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {

                     //Initial condition (special case)

                    newArray.Add(input[i].ToString());
                    continue;
                }

                if (input[i] == ' ' || input[i] == '#')
                {
                    //Case of blank spaces or # continue program
                     
                    continue;
                }

                if (input[i] == '*')
                {
                    //Case of * delete last item of list
                     
                    newArray.RemoveAt(newArray.Count - 1);
                    continue;
                }

                if (input[i] == input[i - 1])
                {
          

                    newArray[newArray.Count - 1] = newArray[newArray.Count - 1] + input[i];

                }
                else
                {

                     //Use ToString to convert char to string

                    newArray.Add(input[i].ToString());
                }

            }

             //Execute those individual inputs and map them to the outputs which we have initialized

            for(int i = 0; i < newArray.Count; i++)
            {

                int strlen = newArray[i].Length;
                char axe = newArray[i][0];
                int axe2 = axe - '0';
                char k = array[axe2 - 1, strlen - 1];
                resultArray.Add(k);

            }

             //Concat the answer and print

            string answer = string.Join("", resultArray);

            Console.WriteLine(answer);

            return answer;

        }

        static void Main(string[] args)
        {
            OldPhonePad("33#");
            OldPhonePad("227*#");
            OldPhonePad("533 338774448266#");
            OldPhonePad("8 88777444666*664#");
        }
    }
}
