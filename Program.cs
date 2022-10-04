var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();

public static class ProdutoRepository{
    public static List<Produto> Produtos;

    public static Produto ObterProduto(int id){
        return Produtos.FirstOrDefault(p => p.Id == id);
    }

    public static void AdicionarProduto(Produto produto){
        if(Produtos == null){
            Produtos = new List<Produto>();
        }
        Produtos.Add(produto);
    }

    public static void RemoverProdutos(Produto produto){
        Produtos.Remove(produto);
    }
}

public class Produto{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
}