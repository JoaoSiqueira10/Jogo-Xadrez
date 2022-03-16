using System.Globalization;


namespace SintaxeThis
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Os 3 construtores funciona juntos
        //O 1 funciona sozinho
        //O 1 e 2 funcionam sem o 3 
         
        public Produto()
        {
            Quantidade = 10;
        }
    
        //aproveita o argumento do primeiro construtor
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        
        //aproveita os argumentos do construtor de 2 argumentos
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
       

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
