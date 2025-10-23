using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money230065.Classes
{
    internal class Stock
    {
        private string s_simbolo;
        private int s_qtd;
        private double s_preco;

        public string simbolo { get { return s_simbolo; } set {  s_simbolo = value; } }
        public int qtd { get { return s_qtd; } set { s_qtd = value; } }
        public double preco { get { return s_preco; } 
            set 
            { 
                if (value < 0) 
                    throw new ArgumentException("Nao pode ser menor que 0");
                else s_preco = value; 
            } 
        }
        public Stock(string symbol, int quantity, double price)
        {
            this.simbolo = symbol;
            this.qtd = quantity;
            this.preco = price;
        }
    }
}
