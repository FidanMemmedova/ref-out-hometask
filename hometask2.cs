using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Fidan Mammadova";
            Console.WriteLine(Nospace(ref name));

        }
        static string Nospace(ref string name)
        {
            string newname = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {

                if (name[i] != ' ')
                {

                    newname += name[i];
                }

            }
            name = newname;
            return name;
        }
    }
}