using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd.Class
{

    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }
        public int Somar(int val1, int val2){

            int result = val1 + val2;
            historico.Insert(0, "Res: "+ result);
            return result;
        }

        public int Subtrair(int val1, int val2){
             int result = val1 - val2;
            historico.Insert(0, "Res: "+ result);
            return result;
        }

        public int Multiplicar(int val1, int val2){
            int result = val1 * val2;
            historico.Insert(0, "Res: "+ result);
            return result;
        }

        public int Dividir(int val1, int val2){
            int result = val1 / val2;
            historico.Insert(0, "Res: "+ result);
            return result;
        }

        public List<string> HistoricoDasOperacoes()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }

    }
}