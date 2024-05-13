using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDIOTestesTDD
{
    public class Calculadora
    {
        private List<String> listarHistorico;
        private string data;
        public Calculadora(string data) 
        { 
            listarHistorico = new List<String>(); 
            this.data = data;
        }
        public int somar(int val1, int val2) 
        { 
            int resultado = val1 + val2;
            listarHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);
            return resultado;
        }

        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listarHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);
            return resultado;
        }

        public int multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            listarHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);
            return resultado;
        }

        public int dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            listarHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);
            return resultado;
        }

        public List<String> historicoCalculos() 
        { 
            listarHistorico.RemoveRange(3, listarHistorico.Count - 3);
            return listarHistorico;
        }
    }
}
