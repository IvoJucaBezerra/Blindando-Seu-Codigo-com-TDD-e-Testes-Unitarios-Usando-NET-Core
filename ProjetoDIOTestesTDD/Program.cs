using System;
using System.Collections.Generic;

namespace ProjetoDIOTestesTDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtém a data atual
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy");

            // Cria uma instância da Calculadora
            Calculadora calculadora = new Calculadora(dataFormatada);

            // Realiza algumas operações e imprime os resultados
            int resultadoSoma = calculadora.somar(10, 5);
            Console.WriteLine("Resultado da soma: " + resultadoSoma);

            int resultadoSubtracao = calculadora.subtrair(10, 5);
            Console.WriteLine("Resultado da subtração: " + resultadoSubtracao);

            int resultadoMultiplicacao = calculadora.multiplicar(10, 5);
            Console.WriteLine("Resultado da multiplicação: " + resultadoMultiplicacao);

            int resultadoDivisao = calculadora.dividir(10, 5);
            Console.WriteLine("Resultado da divisão: " + resultadoDivisao);

            // Imprime o histórico de cálculos
            List<string> historico = calculadora.historicoCalculos();
            Console.WriteLine("\nHistórico de cálculos:");
            foreach (string item in historico)
            {
                Console.WriteLine(item);
            }
        }
    }
}
