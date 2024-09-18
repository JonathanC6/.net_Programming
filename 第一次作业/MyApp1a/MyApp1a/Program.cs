using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*编写程序1a，以文本对齐方式输出下述数值类型:
  sbyte、byte、short、ushort、int、uint、long、ulong、float、double、decimal
  使用的内存字节数以及它们可能具有的最小值和最大值*/

namespace MyApp1a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-30} {3,-30}", "Type", "Size (bytes)", "Min Value", "Max Value");
            Console.WriteLine(new string('-', 90));

            PrintTypeInfo<sbyte>("sbyte");
            PrintTypeInfo<byte>("byte");
            PrintTypeInfo<short>("short");
            PrintTypeInfo<ushort>("ushort");
            PrintTypeInfo<int>("int");
            PrintTypeInfo<uint>("uint");
            PrintTypeInfo<long>("long");
            PrintTypeInfo<ulong>("ulong");
            PrintTypeInfo<float>("float");
            PrintTypeInfo<double>("double");
            PrintTypeInfo<decimal>("decimal");
            System.Console.ReadKey();
        }
        static void PrintTypeInfo<T>(string typeName) where T : struct
        {
            Type type = typeof(T);

            int size = System.Runtime.InteropServices.Marshal.SizeOf(type);
            dynamic minValue = type.GetField("MinValue").GetValue(null);
            dynamic maxValue = type.GetField("MaxValue").GetValue(null);

            Console.WriteLine("{0,-15} {1,-15} {2,-30} {3,-30}", typeName, size, minValue, maxValue);
        }
    }
}
