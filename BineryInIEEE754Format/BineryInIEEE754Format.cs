using System;

class BineryInIEEE754Format
{
    static void Main()
    {
        float fl = float.Parse(Console.ReadLine());

        int bits = BitConverter.ToInt32(BitConverter.GetBytes(fl), 0);
        string numberInBinary = Convert.ToString(bits, 2);
        numberInBinary = numberInBinary.PadLeft(32, '0');

        Console.WriteLine("Binary representation: " + numberInBinary);
        Console.WriteLine("Sign: " + numberInBinary.Substring(0,1));
        Console.WriteLine("Exponent: " + numberInBinary.Substring(1, 8));
        Console.WriteLine("Mantissa: " + numberInBinary.Substring(9)); 
    }
}

