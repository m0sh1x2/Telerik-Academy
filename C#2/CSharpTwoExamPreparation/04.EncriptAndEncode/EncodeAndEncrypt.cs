using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EncodeAndEncrypt
{
    static string Encrypt(string message, string cypher)
    {
        string result = String.Empty;

        if (message.Length > cypher.Length)
        {
            result = EncryptWHenMessageIsLonger(message, cypher);
        }
        else
        {
            result = EncryptWhenCypherIsLonger(message, cypher);
        }

        return result;
    }
    private static string EncryptWHenMessageIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder();

        int cypherIndex = 0;

        for (int i = 0; i < message.Length; i++)
        {
            char messageSymbol = message[i];
            char cypherSymbol = cypher[cypherIndex];

            char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

            result.Append(encryptedSymbol);


            cypherIndex++;
            if (cypherIndex == cypher.Length)
            {
                cypherIndex = 0;
            }
        }

        return result.ToString();
    }

    private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
    {
        int messageSymbolCode = messageSymbol - 'A';
        int cypherSymbolCode = cypherSymbol - 'A';
        int xoredSymbol = messageSymbolCode ^ cypherSymbolCode;
        char encrypted = (char)(xoredSymbol + 'A');


        return encrypted;
    }

    private static string EncryptWhenCypherIsLonger(string message, string cypher)
    {
        StringBuilder result = new StringBuilder(message);

        int messageIndex = 0;

        for (int i = 0; i < cypher.Length; i++)
        {
            char messageSymbol = result[messageIndex];
            char cypherSymbol = cypher[i];

            char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);


            result[messageIndex] = encryptedSymbol;

            messageIndex++;
            if (messageIndex == message.Length)
            {
                messageIndex = 0;
            }
        }

        return result.ToString();
    }



    static string Encode(string text)
    {
        StringBuilder result = new StringBuilder();

        char previousSymbol = text[0];
        int counter = 1;

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == previousSymbol)
            {
                counter++;
            }
            else
            {
                if (counter == 1)
                {
                    result.Append(previousSymbol);
                }
                else if (counter == 2)
                {
                    result.Append(new String(previousSymbol, 2));
                }
                else
                {
                    result.Append(counter + previousSymbol.ToString());
                }
                counter = 1;
            }

            previousSymbol = text[i];
        }
        if (counter == 1)
        {
            result.Append(previousSymbol);
        }
        else if (counter == 2)
        {
            result.Append(new String(previousSymbol, 2));
        }
        else
        {
            result.Append(counter + previousSymbol.ToString());
        }


        return result.ToString();
    }
    static void Main()
    {

        

         
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();


        string finalResult = Encode(Encrypt(message, cypher) + cypher) + cypher.Length;
        Console.WriteLine(finalResult);

    }
}

