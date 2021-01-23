using System;

namespace DictionaryDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictiionary<string, string, int> adSoyadYas = new MyDictiionary<string, string, int>();
            adSoyadYas.Add("Özgür", "Özen", 7964);
            Console.WriteLine(adSoyadYas.Lenght);
            adSoyadYas.Add("Michael", "Jackson", 9604);
            Console.WriteLine(adSoyadYas.Lenght);
            
            
        }
    }
}
