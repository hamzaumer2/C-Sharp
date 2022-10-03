//200789
//HAMZA UMER FAROOQ
//VISUAL PROGRAMMING
//ASSIGNMENT 1

using System;
using System.IO;
using System.Text;

namespace UTF_Conversion
{
    public class Hamza200789Bscs5B
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var lineNo = 1;

                Encoding 
                    u8 = Encoding.UTF8,
                    u16 = Encoding.BigEndianUnicode, 
                    u32 = Encoding.UTF32, 
                    asc = Encoding.ASCII;

                var lines =
                    System.IO.File.ReadAllLines(@"U:\5th SEMESTER\Visual Programming\Assignments\Assignemnt1\test.txt");
                foreach (var line in lines)
                {
                    Console.WriteLine("\nLine Number is: " + lineNo + "\nOriginal String is: " + line);
                    lineNo = lineNo + 1;
                    
                    Decoding(line, u8);
                    Decoding(line, u16);
                    Decoding(line, u32);
                    Decoding(line, asc);
                }
                //Console.WriteLine(line);
            }
        }

        private static void Decoding(string inputs, Encoding enc)
        {
            Console.Write(enc.ToString() + ":  "); //DISPLAYING WHICH ENCODING/DECODING HAPPENING
            var valueToDecode = enc.GetBytes(inputs); //CONVERTING TO RESPECTIVE UTF/ASCII
            foreach (var t in valueToDecode)
                Console.Write("{0:X2} ", t); //PRINTING IN HEX VALUES
            Console.WriteLine();
        }
    }
}