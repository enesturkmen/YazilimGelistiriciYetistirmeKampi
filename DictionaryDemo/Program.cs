using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(101, "Enes");
            myDictionary.Add(102, "Mikail");
            myDictionary.Add(103, "Ali Murat");

        }
    }
}
