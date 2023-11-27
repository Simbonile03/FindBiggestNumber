﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    internal class Words
    {
        public static string CapitalizeFirstWord(string inputString)
        {
            string returnString = " ";
            string[] words = inputString.Split(' ');
            //foreach (string word in split)


            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                char firstChar = char.ToUpper(word[0]);
                returnString += firstChar;
                for (int j = 1; j < word.Length; j++)
                {
                    char currentChar = word[j]; 
                    returnString = returnString + currentChar;
                }
                returnString += " ";
            }

            return returnString;
            
      
        }
    }


}
