using System;
using HexToBase64;

namespace ConsoleProgram {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The resulting Base64 string is:");
            Console.WriteLine(Converter.CovertToBase64());
        }
    }
}