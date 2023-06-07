namespace LojaWeb.Shared;

public class Produto {
	public int Id { get; set; }
	public string? Descricao { get; set; }
	public int Quantidade { get; set; }
	public double Valor { get; set; }
	public bool Ativo { get; set; }
	
	public Produto() {
	}
	
	public Produto(string? descricao, double valor) {
		Descricao = descricao;
		Quantidade = 0;
		Valor = valor;
		Ativo = true;
	}
	
	public override string ToString() {
		return $"({Id}) {Descricao}: {Quantidade} unidades à R$ {Valor.ToString("N2")}";
	}

}