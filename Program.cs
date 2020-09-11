using System;

namespace aula_entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeDoUsuario;
            string SobreNome;
            string nomeCompleto;

            Console.Write("Por favor, digite seu nome: ");
            nomeDoUsuario = Console.ReadLine();
            
            Console.Write("agora seu sobrenome: ");
            SobreNome = Console.ReadLine();

            nomeCompleto = $"{nomeDoUsuario} {SobreNome}";
            
            Console.WriteLine($"Obrigado, {nomeCompleto.ToUpper()}! Presione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
