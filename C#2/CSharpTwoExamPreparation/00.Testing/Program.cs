using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MultiverseCommunication
{
    static void Main()
    {
        string zergCode = Console.ReadLine();
        long result = 0;

        long power = zergCode.Length / 3 - 1;
        for (int i = 0; i < zergCode.Length; i += 3)
        {
            var currentMessage = zergCode.Substring(i, 3);

            result += decrytpedCode(currentMessage) * powerOf(power);
            power--;
        }
        Console.WriteLine(result);

    }

    static long powerOf(long power)
    {
        long result = 1;
        for (long i = 0; i < power; i++)
        {
            result *= 13;
        }
        return result;
    }

    private static long decrytpedCode(string zergCode)
    {
        long newCode = 0;
        switch (zergCode)
        {
            case "CHU": newCode = 0; break;
            case "TEL": newCode = 1; break;
            case "OFT": newCode = 2; break;
            case "IVA": newCode = 3; break;
            case "EMY": newCode = 4; break;
            case "VNB": newCode = 5; break;
            case "POQ": newCode = 6; break;
            case "ERI": newCode = 7; break;
            case "CAD": newCode = 8; break;
            case "K-A": newCode = 9; break;
            case "IIA": newCode = 10; break;
            case "YLO": newCode = 11; break;
            case "PLA": newCode = 12; break;
        }
        //Console.WriteLine(newCode);
        return newCode;
    }
}