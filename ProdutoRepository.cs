public static class ProdutoRepository{
    public static List<Produto> Produtos = Produtos = new List<Produto>();

    public static Produto ObterProduto(int id){
        return Produtos.FirstOrDefault(p => p.Id == id);
    }

    public static void AdicionarProduto(Produto produto){
        Produtos.Add(produto);
    }

    public static void RemoverProdutos(Produto produto){
        Produtos.Remove(produto);
    }
}
