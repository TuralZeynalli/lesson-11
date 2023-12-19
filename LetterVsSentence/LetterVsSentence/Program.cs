using System;
using System.Collections.Generic;
using System.Text;

namespace LetterVsSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = LetterVsSentences(" ou");
            Console.WriteLine(result);
        }

        static string LetterVsSentences (string word)
        {
        string sentence = "You can't kill me, cause i'm already inside you...";

            if (sentence.Contains(word.Trim()))
            {
                return "this word included in this sentences...";
            }
            else
            {
                return "this word isn't included in this sentences...";
            }
        }
/*
        static void Sdajsk() 
        
        {
            string name = "hahahahuhehassshu asdasd asdasd";
            string[] surname = name.Split('u');

            foreach (var item in surname)
            {
                Console.WriteLine(item);
            }
        
        }*/
        
        
    }
}
