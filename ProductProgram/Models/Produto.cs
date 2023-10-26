namespace ProductProgram.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string produtoNome { get; set; }
        public string produtoDescricao { get; set; }
        public double produtoPreco { get; set; }
        public int qtdEstoque { get; set; }
    }
}
