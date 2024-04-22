using System;

// Classe base Animal
public class Animal
{
	// Campo protegido idade
	protected int idade;

	// Evento público que é disparado quando a idade muda
	public event Action<string, int> IdadeAlterada;
	//public event Action<string, int>? IdadeAlterada;

	// Construtor da classe base
	public Animal(int idadeInicial) => idade = idadeInicial;

	// Método protegido para disparar o evento de mudança de idade
	protected void OnIdadeAlterada()
	{
		IdadeAlterada?.Invoke(this.GetType().Name, idade);
	}

	// Método para exibir a idade
	public void ExibirIdade()
	{
		Console.WriteLine($"Idade do {this.GetType().Name.ToLower()}: {idade} anos.");
	}

	// Método geral para aumentar a idade
	public void ComemorarAniversario()
	{
		idade++;
		OnIdadeAlterada();
	}
}