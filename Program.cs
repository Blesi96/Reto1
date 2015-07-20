using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Datos;

            Console.WriteLine("Escriba algún tipo de dato integrado de C#");

            Datos = Console.ReadLine();

            switch (Datos)
            {
                case "Byte":
                    Console.WriteLine("Width: 8  - Bits: 0 to 25");
                    break;

                case "Sbyte":
                    Console.WriteLine("Width: 8  - Bits:  -128 to 127");
                    break;

                case "Int":
                    Console.WriteLine("Width: 32  - Bits:  -2.147.483.648 to 2.147.483.647");
                    break;

                case "Uint":
                    Console.WriteLine("Width : 32 - Bits: 0 to 4294967295");
                    break;

                case "Short":
                    Console.WriteLine(" Width : 16 - Bits: -32.768 to 32.767");
                    break;

                case "Ushort":
                    Console.WriteLine("Width : 16 - Bits: 0 to 65535");
                    break;

                case "Long":
                    Console.WriteLine("Width: 64  - Bits: -922337203685477508 a 922337203685477507");
                    break;

                case "Ulong":
                    Console.WriteLine("Width: 64  - Bits: 0 a 18446744073709551615");
                    break;

                case "Float":
                    Console.WriteLine("Width: 32  - Bits: -3,402823e38 a 3,402823e38");
                    break;

                case "Double":
                    Console.WriteLine("Width: 64  - Bits: -1,79769313486232e308 To 1,79769313486232e308");
                    break;

                case "Char":
                    Console.WriteLine("Width: 16  - Bits: Símbolos Unicode utilizados en el texto");
                    break;

                case "Bool":
                    Console.WriteLine("Width: 8  - Bits: True o false");
                    break;

                case "Object":
                    Console.WriteLine("");
                    break;

                case "String":
                    Console.WriteLine(" Width: 8  - Bits: 0 to 25");
                    break;

                case "Decimal":
                    Console.WriteLine("Width: 128 - Bits: ±1.0 × 10e−28 a ±7.9 × 10e28");
                    break;



            }

            Console.ReadKey();
        }
    }
}
