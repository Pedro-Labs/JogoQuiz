using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas = {
                "Qual é a capital do Brasil?",
                "Quem pintou a Mona Lisa?",
                "Qual é o maior planeta do Sistema Solar?",
                "Qual é o framework de desenvolvimento web da Microsoft que utiliza C# .NET para criar aplicativos web?",
                "Como se chama o desenvolvedor que está começando a trabalhar na área de programação?",
                "Qual é o operador utilizado em C# .NET para verificar igualdade de valor e tipo entre duas variáveis?",
                "Qual é o método utilizado para iniciar a execução de um programa C# .NET?",
                "Qual é o tipo de dado utilizado em C# .NET para representar um número inteiro?",

            };

            string[] respostas = {
                "Brasília",
                "Leonardo da Vinci",
                "Júpiter",
                "ASP.NET",
                "Junior",
                "==",
                "Main()",
                "int",
            };

            int pontos = 0;

            for (int i = 0; i < perguntas.Length; i++)
            {
                Console.WriteLine(perguntas[i]);
                string respostaUsuario = Console.ReadLine();

                if (respostaUsuario.ToLower() == respostas[i].ToLower())
                {
                    Console.WriteLine("Resposta correta!");
                    pontos++;
                }
                else
                {
                    Console.WriteLine($"Resposta incorreta! A resposta correta é: {respostas[i]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Pontuação final: {pontos} de {perguntas.Length}");

        }
    }
}
