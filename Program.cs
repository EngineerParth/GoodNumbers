using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var line1 = Console.ReadLine().Trim();
                var N = Convert.ToUInt64(line1);
                string[] testCases = new string[N];
                for (UInt64 i = 0; i < N; i++)
                {
                    testCases[i] = Console.ReadLine().Trim();
                }
                foreach (string s in testCases)
                {
                    string[] subs = s.Split(new char[] { ' ' });
                    UInt64 li = Convert.ToUInt64(subs[0]);
                    UInt64 ri = Convert.ToUInt64(subs[1]);

                    int count = 0;
                    for (UInt64 number = li; number <= ri; number++)
                    {
                        if (isGoodNumber(number)) count++;
                    }

                    Console.WriteLine(count);
                }

                //int input = Convert.ToUInt64(Console.ReadLine());
                //Console.WriteLine(isGoodNumber(input));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static bool isGoodNumber(UInt64 number){
            string input = number.ToString();
            char[] digits;
            digits=new char[input.Length];
            digits = input.ToCharArray();
            bool isGood = true;
            foreach(char c in digits){
                UInt64 tempDigit = Convert.ToUInt64(c.ToString());
                if (tempDigit != 0){
                    if (number % tempDigit != 0){
                        isGood = false;
                        break;
                    }
                }
            }
            return isGood;
        }
    }
}
