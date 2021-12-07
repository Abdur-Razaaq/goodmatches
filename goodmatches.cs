using System.Text.RegularExpressions;
using System;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "Jack";
        string name2 = "Jill";

        string match = name1 + " matches " + name2;
        string removeBlanks = Regex.Replace(match, @"\s+", "").ToLower();

        while (removeBlanks.Length > 0)
        {
            int cal = 0;
            for (int j = 0; j < removeBlanks.Length; j++)
            {
                if (removeBlanks[0] == removeBlanks[j])
                {
                    cal++;
                }
            }
            removeBlanks = removeBlanks.Replace(removeBlanks[0].ToString(), "");
            string calc = cal.ToString();

            Console.WriteLine(calc);
        }
    }
}
