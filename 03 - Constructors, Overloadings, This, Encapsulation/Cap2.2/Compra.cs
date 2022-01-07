﻿using System.Globalization;
namespace Cap2._2
{
    public class Compra
    {
        private string _nome;
        public double Preco { get; private set; }
        public double Quantidade { get; private set; }
        

        public Compra()
        {
            
        }
        public Compra(string Nome, double Preco, int Quantidade)
        {
            _nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
        
        
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
                   + ", $ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: $ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}