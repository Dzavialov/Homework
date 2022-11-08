namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compare("abcdr", "abcda"));
            Console.WriteLine(Analyze("as4,;'i  "));
            Console.WriteLine(Sort("Hello"));
            Console.WriteLine(Duplicate("aaabccddddd"));

            foreach(var i in Duplicate("aaabccddddd"))
            {
                Console.WriteLine(i);
            }
        }

        static bool Compare(string s1, string s2)
        {
            bool b = true;
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s2[i])
                    {
                        b &= true;
                    }
                    else
                    {
                        b = false;
                        break;
                    }
                }
            }
            else
            {
                b = false;
            }
            return b;
        }

        static int Analyze(string s)
        {
            int result = 0;
            for(int i = 0; i < s.Length; i++)
            {
                result++;
            }
            return result;
        }

        static string Sort(string s)
        {
            string newStr = s.ToLower();
            char[] chars = newStr.ToCharArray();

            for(int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = 0; j < chars.Length - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        var temp = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                    }
                }
            }

            return new string(chars);
        }

        static char[] Duplicate(string s)
        {
            string newStr = Sort(s).Replace(" ", String.Empty);
            List<char> charsList = new List<char>(); 
            for(int i = 0; i < newStr.Length-1; i++)
            {
                if (i != newStr.Length - 2)
                {
                    if (newStr[i] == newStr[i + 1] && newStr[i] != newStr[i + 2])
                    {
                        charsList.Add(newStr[i]);
                    }
                }
                else
                {
                    if (newStr[i] == newStr[i + 1])
                    {
                        charsList.Add(newStr[i]);
                    }
                }
            }
            return charsList.ToArray();
        }
    }
}