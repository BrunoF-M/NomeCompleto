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
            
            Console.WriteLine($"Obrigado, {nomeCompleto}! Presione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine($"Nome de catalogo: {SobreNome.ToUpper()} {nomeDoUsuario}");
            Console.WriteLine("enter para finalizar");
            Console.ReadKey();
        }
    }
}
