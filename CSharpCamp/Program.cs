using System;

namespace CSharpCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<String, String> colleagues = new MyDictionary<string, string>();
            DictionaryResult dictionaryResult=new DictionaryResult();

            dictionaryResult = colleagues.Add("Phyton", "Tony Stark");
            dictionaryResult = colleagues.Add("Java", "Bruce Banner");
            dictionaryResult = colleagues.Add("Javascript", "Steve Rogers");
            dictionaryResult = colleagues.Add("C#", "Natasha Romanova");
            dictionaryResult = colleagues.Add("Angular", "Scarlett Witch");

            //Eleman sayısını yazdırma
            Console.WriteLine("Count of MyDictionary example: {0}", colleagues.Length);

            // Key değerlerini yazdırma
            Console.WriteLine("KEYS:");
            string[] keys = colleagues.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            // Value değerlerini yazdırma
            Console.WriteLine("\nVALUES:");
            string[] values = colleagues.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }


            //Doğrudan atama ile ekleme
            colleagues["Ruby"] = "Hawkeye";


            //Bir key ile kaydedilmiş value değerini yazdırma
            Console.WriteLine("\nHawkeye's workplace: {0} -> ", colleagues["Ruby"]);
            
            Console.WriteLine("\n*** Hawkeye's change ***");
            //Güncelleme
            colleagues["Ruby"] = "Hawkeye";

            Console.WriteLine("COLLEAGUES: \n");
            foreach (var key in keys)
            {
                Console.WriteLine("{0} Colleague => {1} \n", key, colleagues[key]);
            }

            int count = colleagues.Length;
            Console.WriteLine("Total Colleague: " + count);

            colleagues.Remove("9-B");
            count = colleagues.Length;
            Console.WriteLine("Total Colleague: " + count);

        }
    }
}
