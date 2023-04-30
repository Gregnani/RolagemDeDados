//fazer funcionar o random
using System.Security.Cryptography;
{
        Console.WriteLine("---Rolagem de Dados---\n");

        Console.Write("Quantos lados?");
        int lados = Convert.ToInt32(Console.ReadLine());

        int jogada = RandomNumberGenerator.GetInt32(1, lados + 1);

        Console.WriteLine($"\nRolagem: {jogada}");
}