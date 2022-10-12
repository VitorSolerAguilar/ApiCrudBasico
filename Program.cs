using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/Produtos" , (Produto produto) => {
    ProdutoRepository.AdicionarProduto(produto);
});

app.MapGet("/Produto/{code}", ([FromRoute] int code) => {
    var visualizarProduto = ProdutoRepository.ObterProduto(code);
    return visualizarProduto;
});

app.MapPut("/Produto", (Produto produto) => {
    var modificarProduto = ProdutoRepository.ObterProduto(produto.Id);
    modificarProduto.Nome = produto.Nome;
    modificarProduto.Preco = produto.Preco;
    modificarProduto.Descricao = produto.Descricao;
    modificarProduto.Quantidade = produto.Quantidade;
});

app.MapDelete("/Produto/{code}", ([FromRoute] int code) => {
    var deletarProduto = ProdutoRepository.ObterProduto(code);
    ProdutoRepository.RemoverProdutos(deletarProduto);
});

app.Run();
