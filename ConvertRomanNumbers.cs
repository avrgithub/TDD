using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
      
        static void Main(string[] args)
        {
          string romanNum = "MMXVI";
          int result = RomanToInteger(roamNum);
          
          Console.WriteLine("Roman: %s  Integer:%d", romanNum, result);
            return;
        }
    

private static Dictionary<char, int> RomanIntMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };


public static int RomanToInteger(string roman)
{
    int number = 0;
    for (int i = 0; i < roman.Length; i++)
    {
        if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
        {
            number -= RomanMap[roman[i]];
        }
        else
        {
            number += RomanMap[roman[i]];
        }
    }
    return number;
}

}
}
