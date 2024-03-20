using System;

namespace Introduction
{
    class forrec
    {
        ////int count = 0;
        void Per(string str)
        {
            Per(str, "");
        }
        void Per(string str1, string prefix)
        {
            if (str1.Length == 0)
            {
                ////count++;
                Console.WriteLine(prefix);
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    ////count++;
                    // Console.WriteLine("{0}", i);
                    string rem = str1.Substring(0, i) + str1.Substring(i + 1);
                    // Console.Write("{0}", rem);
                    Per(rem, prefix + str1[i]);
                }
            }
        }
        public static void Run()
        {
            string s = "dilip";
            forrec fr = new forrec();
            // fr.Per("abcdefghijklmnopkrstuvwzyz");
            //Console.WriteLine("{0}", fr.count);
            for (int i = 0; i <= s.Length; i++)
            {
                string r = s.Substring(0);//+s.Substring(i + 1);
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }
}
