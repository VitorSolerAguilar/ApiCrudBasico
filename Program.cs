var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();

public class Produto{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
}