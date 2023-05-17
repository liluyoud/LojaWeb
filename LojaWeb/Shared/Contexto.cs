namespace LojaWeb.Shared;

using System.Text.Json;

public class Contexto {
    public List<Produto> Produtos { get; set; }
    public List<Vendedor> Vendedores { get; set; }

    public Contexto()
    {
        Produtos = new List<Produto>();
        Vendedores = new List<Vendedor>();
    }

    public void Salvar() {
		var jsonString = JsonSerializer.Serialize(Produtos, new JsonSerializerOptions{ WriteIndented = true });
        File.WriteAllText("Produtos.json", jsonString);
    }

    public void Restaurar() {
        string json = File.ReadAllText("Produtos.json");
        if (!string.IsNullOrEmpty(json)) {
            var produtos = JsonSerializer.Deserialize<List<Produto>>(json);
            if (produtos != null)
                Produtos = produtos;
        }
        var maxId = Produtos.Max(p => p.Id);
        Produto.UpdateNextId(maxId);
    }
}