using System;
using System.Globalization;

namespace Encapsulamento
{
    public class Produto2
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto2(string nome, double preco, int quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto2(){
            _quantidade = 10;
        }
        public Produto2(string nome, double preco) : this(){
            _mome = nome;
            _preco = preco;
        }

        public Produto2(string nome, double preco, int quantidade) : this(nome, preco){
            _quantidade = quantidade;
        }

        public void SetNome(string nome){
            if(nome != null && nome.Length > 1){
                _nome = nome;
            }
        }
        public string GetNome(){
            return _nome;
        }
        public double GetPreco(){
            return _preco;
        }
        public int GetQuantidade(){
            return _quantidade;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
            }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}