using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDataStruct
{
    class Program
    {
        private static Dictionary<string, object> dict;
        private static void Add(string strKey, object dataType) 
        {
            if (!dict.ContainsKey(strKey))
            {
                dict.Add(strKey, dataType);
            }
            else 
            {
                dict[strKey] = dataType;
            }
        }

        public static T GetAnyValue<T>(string strKey) 
        {
            object obj;
            T retType;
            dict.TryGetValue(strKey, out obj);

            try
            {
                retType = (T)obj;
            }
            catch
            {
                retType = default(T);
            }
            return retType;
        }

        static void Main(string[] args)
        {
            dict = new Dictionary<string, object>();

            Add("pie", 3.4123);
            Add("Apple Tart", "340 calories");
            Add("Poltry", "Fried chickens");
            Add("i", 7);

            Console.WriteLine("pi = " + GetAnyValue<double>("pi"));
            Console.WriteLine("Apple Tart = " + GetAnyValue<string>("Apple Tart"));
            Console.WriteLine("Poltry = " + GetAnyValue<string>("Poltry"));
            Console.WriteLine("i = " + GetAnyValue<int>("i"));
            Console.ReadLine();
        }
    }
}
