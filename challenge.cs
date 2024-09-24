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
            char[,] array = { { '&', '\'', '(', '\0' }, { 'A', 'B', 'C', '\0' }, { 'D', 'E', 'F', '\0' }, { 'G', 'H', 'I', '\0' }, { 'J', 'K', 'L', '\0' }, { 'M', 'N', 'O', '\0' }, { 'P', 'Q', 'R', 'S' }, { 'T', 'U', 'V', '\0' }, { 'W', 'X', 'Y', 'Z' } };

            int length = input.Length;

            List<string> newArray = new List<string>();
            List<char> resultArray = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {

                    newArray.Add(input[i].ToString());
                    continue;
                }

                if (input[i] == ' ' || input[i] == '#')
                {
                    continue;
                }

                if (input[i] == '*')
                {
                    newArray.RemoveAt(newArray.Count - 1);
                    continue;
                }

                if (input[i] == input[i - 1])
                {

                    newArray[newArray.Count - 1] = newArray[newArray.Count - 1] + input[i];

                }
                else
                {

                    newArray.Add(input[i].ToString());
                }

            }

            for(int i = 0; i < newArray.Count; i++)
            {

                int strlen = newArray[i].Length;
                char axe = newArray[i][0];
                int axe2 = axe - '0';
                char k = array[axe2 - 1, strlen - 1];
                resultArray.Add(k);

            }

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
