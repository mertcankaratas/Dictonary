using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> isimler = new MyDictionary<int, string>();
            isimler.Add(111,"Mertcan");
            Console.WriteLine(isimler.Length);
            isimler.Add(122,"Mert");

            Console.WriteLine(isimler.Length);
            isimler.WriteConsoleListValue();
            isimler.WriteConsoleListKey();
        }
    }
}
