namespace LojaWeb.Shared;

public class Vendedor {
    public int Id { get; set; }
	public string? Nome { get; set; }
	public string? Cpf { get; set; }
	public string? Sexo { get; set; }
	public DateTime DataNascimento { get; set; }
    public bool Ativo { get; set; }
	
	public Vendedor() {}
	
	public Vendedor(int id, string nome, string cpf) {
		Id = id;
		Nome = nome;
		Cpf = cpf;
		Ativo = true;
	}
	
	public override string ToString() {
		return $"({Id}) {Nome}";
	}
}